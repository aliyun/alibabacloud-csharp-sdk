// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JarArtifact : TeaModel {
        /// <summary>
        /// <para>The full URL of the additional dependency file. You can enter the dependency file for the JAR deployment.</para>
        /// </summary>
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        /// <summary>
        /// <para>The entry class. You must enter the full name of the class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>org.apapche.flink.test</para>
        /// </summary>
        [NameInMap("entryClass")]
        [Validation(Required=false)]
        public string EntryClass { get; set; }

        /// <summary>
        /// <para>The full URL for the JAR deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://oss/bucket/test.jar">https://oss/bucket/test.jar</a></para>
        /// </summary>
        [NameInMap("jarUri")]
        [Validation(Required=false)]
        public string JarUri { get; set; }

        /// <summary>
        /// <para>The parameters required by the entry class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start from main</para>
        /// </summary>
        [NameInMap("mainArgs")]
        [Validation(Required=false)]
        public string MainArgs { get; set; }

    }

}
