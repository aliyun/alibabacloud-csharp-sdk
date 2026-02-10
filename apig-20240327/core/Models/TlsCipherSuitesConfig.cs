// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class TlsCipherSuitesConfig : TeaModel {
        /// <summary>
        /// <para>The configuration type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>tlsCipherSuite</para>
        /// </summary>
        [NameInMap("tlsCipherSuite")]
        [Validation(Required=false)]
        public List<TlsCipherSuitesConfigTlsCipherSuite> TlsCipherSuite { get; set; }
        public class TlsCipherSuitesConfigTlsCipherSuite : TeaModel {
            /// <summary>
            /// <para>The suite name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECDHE-ECDSA-AES256-GCM-SHA384</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The supported versions.</para>
            /// </summary>
            [NameInMap("supportVersions")]
            [Validation(Required=false)]
            public List<string> SupportVersions { get; set; }

        }

    }

}
