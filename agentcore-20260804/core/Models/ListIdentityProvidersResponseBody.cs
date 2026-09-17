// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListIdentityProvidersResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of external identity providers.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListIdentityProvidersResponseBodyItems> Items { get; set; }
        public class ListIdentityProvidersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC, formatted according to RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The event subscription callback URL. Configure this URL in the external identity provider application to receive organization change events. An empty string is returned if the user pool has not been activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456">http://auth.cn-hangzhou.agentteams.aliyuncs.com/roa/dingtalk/event/up-123456</a></para>
            /// </summary>
            [NameInMap("eventSubscriptionCallbackUrl")]
            [Validation(Required=false)]
            public string EventSubscriptionCallbackUrl { get; set; }

            /// <summary>
            /// <para>The type of the external identity provider. Valid values: DingTalk, Feishu.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("identityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            /// <summary>
            /// <para>The logon callback URL. Configure this URL in the external identity provider application. An empty string is returned if the user pool has not been activated.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback">https://signin-cn-hangzhou.aliyunagentid.com/up-123456/dingtalk/callback</a></para>
            /// </summary>
            [NameInMap("loginCallbackUrl")]
            [Validation(Required=false)]
            public string LoginCallbackUrl { get; set; }

            /// <summary>
            /// <para>Indicates whether workspace users are allowed to log on through this external identity provider.</para>
            /// </summary>
            [NameInMap("loginEnabled")]
            [Validation(Required=false)]
            public bool? LoginEnabled { get; set; }

            /// <summary>
            /// <para>The application configuration of the external identity provider. Application secret configurations are not returned.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public ListIdentityProvidersResponseBodyItemsMetadata Metadata { get; set; }
            public class ListIdentityProvidersResponseBodyItemsMetadata : TeaModel {
                /// <summary>
                /// <para>The App ID of the Lark application. This parameter is required when the binding type is Feishu.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cli_exampleappid01</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The AppKey of the DingTalk application. This parameter is required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexampleappkey01</para>
                /// </summary>
                [NameInMap("appKey")]
                [Validation(Required=false)]
                public string AppKey { get; set; }

                /// <summary>
                /// <para>The CorpId of the DingTalk organization. This parameter is required when the binding type is DingTalk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dingexamplecorpid01</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

            }

            /// <summary>
            /// <para>The binding status. Valid values: CONFIGURED (The configuration has been accepted and the user pool is pending activation.), SYNCING (Organization members are being synchronized.), SYNCED (Organization member synchronization is complete.), READY (The binding is active.), SYNC_FAILED (Organization member synchronization failed.), UPDATING (The configuration is being updated.), UPDATE_FAILED (The configuration update failed.), DISCONNECTING (The binding is being removed.), DISCONNECT_FAILED (The unbinding failed.).</para>
            /// 
            /// <b>Example:</b>
            /// <para>READY</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether organization member synchronization is enabled. When enabled, the external identity provider synchronizes organization members as workspace users.</para>
            /// </summary>
            [NameInMap("syncEnabled")]
            [Validation(Required=false)]
            public bool? SyncEnabled { get; set; }

            /// <summary>
            /// <para>The time of the last modification in UTC, formatted according to RFC 3339.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-12T03:04:05Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-123456</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records per page that took effect for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response message. An error description is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. This parameter is empty if no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aWRlbnRpdHktcHJvdmlkZXItb2Zmc2V0OjEw</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of external identity providers that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
