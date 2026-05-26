// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetSAMLServiceProviderInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SAMLServiceProviderInfo")]
        [Validation(Required=false)]
        public GetSAMLServiceProviderInfoResponseBodySAMLServiceProviderInfo SAMLServiceProviderInfo { get; set; }
        public class GetSAMLServiceProviderInfoResponseBodySAMLServiceProviderInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-beijing.aliyunagentid.com/up_xxxxxxxxxxxxxxxxxxxx/saml/acs">https://signin-cn-beijing.aliyunagentid.com/up_xxxxxxxxxxxxxxxxxxxx/saml/acs</a></para>
            /// </summary>
            [NameInMap("ACSURL")]
            [Validation(Required=false)]
            public string ACSURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-beijing.aliyunagentid.com/up_xxxxxxxxxxxxxxxxxxxx">https://signin-cn-beijing.aliyunagentid.com/up_xxxxxxxxxxxxxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <?xml version=\\"1.0\\" encoding=\\"UTF-8\\" standalone=\\"no\\"?><para>\n&lt;md:EntityDescriptor entityID=\&quot;<a href="https://signin">https://signin</a>......</para>
            /// </summary>
            [NameInMap("SPMetadataDocument")]
            [Validation(Required=false)]
            public string SPMetadataDocument { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>up_xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

        }

    }

}
