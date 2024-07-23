// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Artifact : TeaModel {
        [NameInMap("jarArtifact")]
        [Validation(Required=false)]
        public JarArtifact JarArtifact { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SQLSCRIPT</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        [NameInMap("pythonArtifact")]
        [Validation(Required=false)]
        public PythonArtifact PythonArtifact { get; set; }

        [NameInMap("sqlArtifact")]
        [Validation(Required=false)]
        public SqlArtifact SqlArtifact { get; set; }

    }

}
