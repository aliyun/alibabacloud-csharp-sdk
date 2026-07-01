// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Artifact : TeaModel {
        /// <summary>
        /// <para>Required for a data ingestion job.</para>
        /// </summary>
        [NameInMap("cdcYamlArtifact")]
        [Validation(Required=false)]
        public CdcYamlArtifact CdcYamlArtifact { get; set; }

        /// <summary>
        /// <para>Required for a JAR job.</para>
        /// </summary>
        [NameInMap("jarArtifact")]
        [Validation(Required=false)]
        public JarArtifact JarArtifact { get; set; }

        /// <summary>
        /// <para>Specifies the kind of job. This field is required and cannot be changed after creation.</para>
        /// <list type="bullet">
        /// <item><description><para>SQLSCRIPT: An SQL job.</para>
        /// </description></item>
        /// <item><description><para>JAR: A JAR job.</para>
        /// </description></item>
        /// <item><description><para>PYTHON: A Python job.</para>
        /// </description></item>
        /// <item><description><para>CDCYAML: A CDC data ingestion job.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SQLSCRIPT</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>Required for a Python job.</para>
        /// </summary>
        [NameInMap("pythonArtifact")]
        [Validation(Required=false)]
        public PythonArtifact PythonArtifact { get; set; }

        /// <summary>
        /// <para>Required for an SQL job.</para>
        /// </summary>
        [NameInMap("sqlArtifact")]
        [Validation(Required=false)]
        public SqlArtifact SqlArtifact { get; set; }

    }

}
