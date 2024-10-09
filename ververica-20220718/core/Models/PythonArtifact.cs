// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class PythonArtifact : TeaModel {
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        [NameInMap("additionalPythonArchives")]
        [Validation(Required=false)]
        public List<string> AdditionalPythonArchives { get; set; }

        [NameInMap("additionalPythonLibraries")]
        [Validation(Required=false)]
        public List<string> AdditionalPythonLibraries { get; set; }

        [NameInMap("entryModule")]
        [Validation(Required=false)]
        public string EntryModule { get; set; }

        [NameInMap("mainArgs")]
        [Validation(Required=false)]
        public string MainArgs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss//bucket//test.py">https://oss//bucket//test.py</a></para>
        /// </summary>
        [NameInMap("pythonArtifactUri")]
        [Validation(Required=false)]
        public string PythonArtifactUri { get; set; }

    }

}
