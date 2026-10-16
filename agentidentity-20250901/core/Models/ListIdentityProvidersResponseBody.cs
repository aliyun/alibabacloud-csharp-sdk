// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListIdentityProvidersResponseBody : TeaModel {
        [NameInMap("IdentityProviders")]
        [Validation(Required=false)]
        public List<ListIdentityProvidersResponseBodyIdentityProviders> IdentityProviders { get; set; }
        public class ListIdentityProvidersResponseBodyIdentityProviders : TeaModel {
            [NameInMap("AllowedAudience")]
            [Validation(Required=false)]
            public List<string> AllowedAudience { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-18T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ods_api_public_ios_wanxin_boxgame_user_behavior_integration_di</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://oauth.aliyun.com/.well-known/openid-configuration">https://oauth.aliyun.com/.well-known/openid-configuration</a></para>
            /// </summary>
            [NameInMap("DiscoveryURL")]
            [Validation(Required=false)]
            public string DiscoveryURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:identityprovider/identity-provider-okta</para>
            /// </summary>
            [NameInMap("IdentityProviderArn")]
            [Validation(Required=false)]
            public string IdentityProviderArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>identity-provider-okta</para>
            /// </summary>
            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-09T02:04:23</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6lsy4U8Dgz6TCndCo6o5TB8</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D325DF9D-7CA8-5C47-BA0C-9A74873F2BE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
