// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JarArtifact : TeaModel {
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>org.apapche.flink.test</para>
        /// </summary>
        [NameInMap("entryClass")]
        [Validation(Required=false)]
        public string EntryClass { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://oss//bucket//test.jar">https://oss//bucket//test.jar</a></para>
        /// </summary>
        [NameInMap("jarUri")]
        [Validation(Required=false)]
        public string JarUri { get; set; }

        [NameInMap("mainArgs")]
        [Validation(Required=false)]
        public string MainArgs { get; set; }

    }

}
