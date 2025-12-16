// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class ReadSchedulerxNotificationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial details.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public ReadSchedulerxNotificationPolicyResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class ReadSchedulerxNotificationPolicyResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The authentication operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edas:ReadSchedulerxNotificationPolicy</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The principal name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>209312833131416xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The account of the principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1827811800526xxx</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The principal type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encoded diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQFn/cLPZ/3Cz0YxQkZBMjVGLTY0REUtNTlGNS05NzUwLTgyMUE4M0MwMTFDRQ==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The permission denial type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccountLevelIdentityBasedPolicy</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadSchedulerxNotificationPolicyResponseBodyData Data { get; set; }
        public class ReadSchedulerxNotificationPolicyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The maximum number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>When data that matches the query conditions has not been fully retrieved, the server returns nextToken. You can then use nextToken to continue retrieving the remaining data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>O39nXKu5XafATl3/cJjSJw==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The data records.</para>
            /// </summary>
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<ReadSchedulerxNotificationPolicyResponseBodyDataRecords> Records { get; set; }
            public class ReadSchedulerxNotificationPolicyResponseBodyDataRecords : TeaModel {
                /// <summary>
                /// <para>The configuration of the notification policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;isUnifiedSetting&quot;: false,
                ///   &quot;timezone&quot;: &quot;GMT+8&quot;,
                ///   &quot;webhookIsAtAll&quot;: &quot;false&quot;,
                ///   &quot;timeRanges&quot;: {
                ///     &quot;webhook&quot;: [
                ///       {
                ///         &quot;startTime&quot;: &quot;08:00&quot;,
                ///         &quot;endTime&quot;: &quot;18:00&quot;,
                ///         &quot;daysOfWeek&quot;: [
                ///           1,
                ///           2,
                ///           3,
                ///           4,
                ///           5
                ///         ]
                ///       }
                ///     ],
                ///     &quot;sms&quot;: [
                ///       {
                ///         &quot;startTime&quot;: &quot;08:00&quot;,
                ///         &quot;endTime&quot;: &quot;18:00&quot;,
                ///         &quot;daysOfWeek&quot;: [
                ///           1,
                ///           2,
                ///           3,
                ///           4,
                ///           5
                ///         ]
                ///       }
                ///     ],
                ///     &quot;mail&quot;: [
                ///       {
                ///         &quot;startTime&quot;: &quot;08:00&quot;,
                ///         &quot;endTime&quot;: &quot;18:00&quot;,
                ///         &quot;daysOfWeek&quot;: [
                ///           1,
                ///           2,
                ///           3,
                ///           4,
                ///           5
                ///         ]
                ///       }
                ///     ],
                ///     &quot;phone&quot;: [
                ///       {
                ///         &quot;startTime&quot;: &quot;08:00&quot;,
                ///         &quot;endTime&quot;: &quot;18:00&quot;,
                ///         &quot;daysOfWeek&quot;: [
                ///           1,
                ///           2,
                ///           3,
                ///           4,
                ///           5
                ///         ]
                ///       }
                ///     ]
                ///   }
                /// }</para>
                /// </summary>
                [NameInMap("ChannelTimeRange")]
                [Validation(Required=false)]
                public string ChannelTimeRange { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-17 11:21:01</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>201576653956616970</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The description of the notification policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Monday-Friday only</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the notification policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-weekdays</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// <para>The list of applications associated with the notification policy.</para>
                /// </summary>
                [NameInMap("ReferenceApps")]
                [Validation(Required=false)]
                public List<ReadSchedulerxNotificationPolicyResponseBodyDataRecordsReferenceApps> ReferenceApps { get; set; }
                public class ReadSchedulerxNotificationPolicyResponseBodyDataRecordsReferenceApps : TeaModel {
                    /// <summary>
                    /// <para>The ID of the task group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("AppGroupId")]
                    [Validation(Required=false)]
                    public long? AppGroupId { get; set; }

                    /// <summary>
                    /// <para>The ID of the application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-app</para>
                    /// </summary>
                    [NameInMap("GroupId")]
                    [Validation(Required=false)]
                    public string GroupId { get; set; }

                    /// <summary>
                    /// <para>The name of the namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Notification strategy testing namespace</para>
                    /// </summary>
                    [NameInMap("NamespaceName")]
                    [Validation(Required=false)]
                    public string NamespaceName { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>18271388-aa16-4eab-9a6f-55f65d7e4391</para>
                    /// </summary>
                    [NameInMap("NamespaceUid")]
                    [Validation(Required=false)]
                    public string NamespaceUid { get; set; }

                }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-09-17 11:21:01</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The updater.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1144881807903942</para>
                /// </summary>
                [NameInMap("Updater")]
                [Validation(Required=false)]
                public string Updater { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>unknown exception occurred</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>71BCC0E3-64B2-4B63-A870-AFB64EBCB5A7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
