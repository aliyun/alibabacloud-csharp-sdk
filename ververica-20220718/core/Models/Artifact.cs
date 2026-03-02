// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Artifact : TeaModel {
        /// <summary>
        /// <para>The information required for the SQL deployment.</para>
        /// </summary>
        [NameInMap("jarArtifact")]
        [Validation(Required=false)]
        public JarArtifact JarArtifact { get; set; }

        /// <summary>
        /// <para>The type of the deployment. This parameter is required and cannot be modified after the deployment is created.</para>
        /// <list type="bullet">
        /// <item><description>SQLSCRIPT</description></item>
        /// <item><description>JAR</description></item>
        /// <item><description>PYTHON</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQLSCRIPT</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The information required for the Python deployment.</para>
        /// </summary>
        [NameInMap("pythonArtifact")]
        [Validation(Required=false)]
        public PythonArtifact PythonArtifact { get; set; }

        /// <summary>
        /// <para>The information required for the JAR deployment.</para>
        /// </summary>
        [NameInMap("sqlArtifact")]
        [Validation(Required=false)]
        public SqlArtifact SqlArtifact { get; set; }

    }

}
