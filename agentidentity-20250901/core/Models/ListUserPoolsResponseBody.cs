// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListUserPoolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to query the next page of data. An empty value indicates that no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFVzZXJQb29sczo6MjA=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AABD6E03-4B3A-5687-88FF-72232670ED0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of user pools that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of user pools.</para>
        /// </summary>
        [NameInMap("UserPools")]
        [Validation(Required=false)]
        public List<ListUserPoolsResponseBodyUserPools> UserPools { get; set; }
        public class ListUserPoolsResponseBodyUserPools : TeaModel {
            /// <summary>
            /// <para>The creation time in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>User pool example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The OpenID Connect (OIDC) discovery URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-beijing.aliyunagentid.com/up_7b6908bcb9ba4c****c8e187/.well-known/openid-configuration">https://signin-cn-beijing.aliyunagentid.com/up_7b6908bcb9ba4c****c8e187/.well-known/openid-configuration</a></para>
            /// </summary>
            [NameInMap("OIDCDiscoveryURL")]
            [Validation(Required=false)]
            public string OIDCDiscoveryURL { get; set; }

            /// <summary>
            /// <para>The base sign-in URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://pre-signin-cn-hangzhou.aliyunagentid.com/up_e14d889*****716841">https://pre-signin-cn-hangzhou.aliyunagentid.com/up_e14d889*****716841</a></para>
            /// </summary>
            [NameInMap("SigninBaseURL")]
            [Validation(Required=false)]
            public string SigninBaseURL { get; set; }

            /// <summary>
            /// <para>The creation source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            /// <summary>
            /// <para>The update time in ISO 8601 format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-07T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>up-xxxxxxxxxxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

            /// <summary>
            /// <para>The name of the user pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent-userpool</para>
            /// </summary>
            [NameInMap("UserPoolName")]
            [Validation(Required=false)]
            public string UserPoolName { get; set; }

        }

    }

}
