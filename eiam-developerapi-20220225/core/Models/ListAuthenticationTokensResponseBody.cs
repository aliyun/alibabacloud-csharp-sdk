// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListAuthenticationTokensResponseBody : TeaModel {
        /// <summary>
        /// <para>List of resource entities.</para>
        /// </summary>
        [NameInMap("entities")]
        [Validation(Required=false)]
        public List<ListAuthenticationTokensResponseBodyEntities> Entities { get; set; }
        public class ListAuthenticationTokensResponseBodyEntities : TeaModel {
            /// <summary>
            /// <para>Authentication token ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>atntkn_01kqflm0sxxx8nmdc1cb5dskxxxxx</para>
            /// </summary>
            [NameInMap("authenticationTokenId")]
            [Validation(Required=false)]
            public string AuthenticationTokenId { get; set; }

            /// <summary>
            /// <para>Authentication token type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>jwt: JWT authentication token</para>
            /// </description></item>
            /// <item><description><para>oauth_access_token: OAuth Access Token authentication token</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>jwt</para>
            /// </summary>
            [NameInMap("authenticationTokenType")]
            [Validation(Required=false)]
            public string AuthenticationTokenType { get; set; }

            /// <summary>
            /// <para>ID of the authentication token consumer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_jwt_subject</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>Type of the authentication token consumer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>application: Application</para>
            /// </description></item>
            /// <item><description><para>custom: Custom type</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("consumerType")]
            [Validation(Required=false)]
            public string ConsumerType { get; set; }

            /// <summary>
            /// <para>Creation time of the authentication token, as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>ID of the authentication token creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_ngtkgrrxxxxktg5eao6z4xxxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>Type of the authentication token creator. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>application: Application</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>application</para>
            /// </summary>
            [NameInMap("creatorType")]
            [Validation(Required=false)]
            public string CreatorType { get; set; }

            /// <summary>
            /// <para>Credential provider ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>atp_01kr2cmj5gxxx4fvmls2e93dxxxxx</para>
            /// </summary>
            [NameInMap("credentialProviderId")]
            [Validation(Required=false)]
            public string CredentialProviderId { get; set; }

            /// <summary>
            /// <para>Expiration time of the authentication token, as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1772693568000</para>
            /// </summary>
            [NameInMap("expirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the authentication token is revoked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("revoked")]
            [Validation(Required=false)]
            public bool? Revoked { get; set; }

            /// <summary>
            /// <para>Last update time of the authentication token, as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830225000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Maximum number of records returned in this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>Token returned by this call. Use it for the next paged query to get the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Total number of resource entities that match the query criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
