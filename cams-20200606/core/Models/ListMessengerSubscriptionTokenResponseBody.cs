// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMessengerSubscriptionTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMessengerSubscriptionTokenResponseBodyData> Data { get; set; }
        public class ListMessengerSubscriptionTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>172546854885</para>
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public long? CreationTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值</para>
            /// </summary>
            [NameInMap("CustomAudienceId")]
            [Validation(Required=false)]
            public string CustomAudienceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172546854885</para>
            /// </summary>
            [NameInMap("NextEligibleTime")]
            [Validation(Required=false)]
            public long? NextEligibleTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("NotificationMessagesReoptin")]
            [Validation(Required=false)]
            public string NotificationMessagesReoptin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("NotificationMessagesTimezone")]
            [Validation(Required=false)]
            public string NotificationMessagesTimezone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("NotificationMessagesToken")]
            [Validation(Required=false)]
            public string NotificationMessagesToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>239***</para>
            /// </summary>
            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            /// <summary>
            /// <para>The customer\&quot;s Page-scoped ID (PSID)</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("RecipientId")]
            [Validation(Required=false)]
            public string RecipientId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>172546854885</para>
            /// </summary>
            [NameInMap("TokenExpiryTimestamp")]
            [Validation(Required=false)]
            public long? TokenExpiryTimestamp { get; set; }

            /// <summary>
            /// <para>The message\&quot;s title</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("TopicTitle")]
            [Validation(Required=false)]
            public string TopicTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
            /// </summary>
            [NameInMap("UserTokenStatus")]
            [Validation(Required=false)]
            public string UserTokenStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3399***</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ei**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
