// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMessengerSubscriptionTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>A return value of OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For a list of other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListMessengerSubscriptionTokenResponseBodyData> Data { get; set; }
        public class ListMessengerSubscriptionTokenResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the security token was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172546854885</para>
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public long? CreationTimestamp { get; set; }

            /// <summary>
            /// <para>The custom audience ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example</para>
            /// </summary>
            [NameInMap("CustomAudienceId")]
            [Validation(Required=false)]
            public string CustomAudienceId { get; set; }

            /// <summary>
            /// <para>The time when the application can send the next marketing message to the recipient.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172546854885</para>
            /// </summary>
            [NameInMap("NextEligibleTime")]
            [Validation(Required=false)]
            public long? NextEligibleTime { get; set; }

            /// <summary>
            /// <para>The re-subscription status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example</para>
            /// </summary>
            [NameInMap("NotificationMessagesReoptin")]
            [Validation(Required=false)]
            public string NotificationMessagesReoptin { get; set; }

            /// <summary>
            /// <para>The customer\&quot;s time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example</para>
            /// </summary>
            [NameInMap("NotificationMessagesTimezone")]
            [Validation(Required=false)]
            public string NotificationMessagesTimezone { get; set; }

            /// <summary>
            /// <para>The page-scoped ID of the customer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example</para>
            /// </summary>
            [NameInMap("NotificationMessagesToken")]
            [Validation(Required=false)]
            public string NotificationMessagesToken { get; set; }

            /// <summary>
            /// <para>The page ID for Messenger.</para>
            /// 
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
            /// <para>Example</para>
            /// </summary>
            [NameInMap("RecipientId")]
            [Validation(Required=false)]
            public string RecipientId { get; set; }

            /// <summary>
            /// <para>The expiration time of the security token.</para>
            /// 
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
            /// <para>Example</para>
            /// </summary>
            [NameInMap("TopicTitle")]
            [Validation(Required=false)]
            public string TopicTitle { get; set; }

            /// <summary>
            /// <para>The status of the security token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Example</para>
            /// </summary>
            [NameInMap("UserTokenStatus")]
            [Validation(Required=false)]
            public string UserTokenStatus { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The identifier for the next page. Pass this value to query the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3399***</para>
        /// </summary>
        [NameInMap("NextPage")]
        [Validation(Required=false)]
        public string NextPage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ei**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: successful.</para>
        /// </description></item>
        /// <item><description><para>false: failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
