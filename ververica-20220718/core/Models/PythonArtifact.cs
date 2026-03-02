// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class PythonArtifact : TeaModel {
        /// <summary>
        /// <para>The URL of the additional dependency file.</para>
        /// </summary>
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        /// <summary>
        /// <para>The Python archive file on which the deployment depends.</para>
        /// </summary>
        [NameInMap("additionalPythonArchives")]
        [Validation(Required=false)]
        public List<string> AdditionalPythonArchives { get; set; }

        /// <summary>
        /// <para>The Python library file on which the deployment depends.</para>
        /// </summary>
        [NameInMap("additionalPythonLibraries")]
        [Validation(Required=false)]
        public List<string> AdditionalPythonLibraries { get; set; }

        /// <summary>
        /// <para>The startup module for the Python deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.py</para>
        /// </summary>
        [NameInMap("entryModule")]
        [Validation(Required=false)]
        public string EntryModule { get; set; }

        /// <summary>
        /// <para>The startup parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start from main</para>
        /// </summary>
        [NameInMap("mainArgs")]
        [Validation(Required=false)]
        public string MainArgs { get; set; }

        /// <summary>
        /// <para>The full URL for the Python deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss/bucket/test.py">https://oss/bucket/test.py</a></para>
        /// </summary>
        [NameInMap("pythonArtifactUri")]
        [Validation(Required=false)]
        public string PythonArtifactUri { get; set; }

    }

}
