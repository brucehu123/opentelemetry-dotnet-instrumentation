//------------------------------------------------------------------------------
// <auto-generated />
// This comment is here to prevent StyleCop from analyzing a file originally from Serilog.
//------------------------------------------------------------------------------

// Copyright 2013-2019 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.IO;
using System.Text;

namespace OpenTelemetry.AutoInstrumentation.Loader
{
    internal sealed class FileSink : IDisposable
    {
        readonly TextWriter _output;
        readonly FileStream _underlyingStream;
        readonly object _syncRoot = new object();

        public FileSink(string path, Encoding encoding = null)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));

            var directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrWhiteSpace(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            Stream outputStream = _underlyingStream = System.IO.File.Open(path, FileMode.Append, FileAccess.Write, FileShare.Read);

            _output = new StreamWriter(outputStream, encoding ?? new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        }

        public void Info(string message, params object[] args)
        {
            _output.Write(message, args);
            FlushToDisk();
        }

        public void Dispose()
        {
            lock (_syncRoot)
            {
                _output.Dispose();
            }
        }

        private void FlushToDisk()
        {
            lock (_syncRoot)
            {
                _output.Flush();
                _underlyingStream.Flush(true);
            }
        }
    }
}
