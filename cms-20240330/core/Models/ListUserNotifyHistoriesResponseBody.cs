// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListUserNotifyHistoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The notification history list.</para>
        /// </summary>
        [NameInMap("historyList")]
        [Validation(Required=false)]
        public List<ListUserNotifyHistoriesResponseBodyHistoryList> HistoryList { get; set; }
        public class ListUserNotifyHistoriesResponseBodyHistoryList : TeaModel {
            /// <summary>
            /// <para>The notification channel. The valid values are the same as those of the <c>channel</c> request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DING</para>
            /// </summary>
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <para>The list of contacts. Multiple contacts are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San, Li Si</para>
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public string Contacts { get; set; }

            /// <summary>
            /// <para>The list of contact groups. Multiple contact groups are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>O&amp;M group, on-call group</para>
            /// </summary>
            [NameInMap("groups")]
            [Validation(Required=false)]
            public string Groups { get; set; }

            /// <summary>
            /// <para>The incident ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5d41402abc4b2a76b9719d911017c592</para>
            /// </summary>
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public string IncidentId { get; set; }

            /// <summary>
            /// <para>The notification job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3fa85f64-5717-4562-b3fc-2c963f66afa8</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Indicates whether the notification record has no actual delivery channel. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The notification record has no actual delivery channel, and the notifyResult is NO_CHANNEL.</description></item>
            /// <item><description>false: The notification record has an actual delivery channel.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("noChannel")]
            [Validation(Required=false)]
            public bool? NoChannel { get; set; }

            /// <summary>
            /// <para>The notification policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e</para>
            /// </summary>
            [NameInMap("notifyStrategyId")]
            [Validation(Required=false)]
            public string NotifyStrategyId { get; set; }

            /// <summary>
            /// <para>The notification policy name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default notification policy</para>
            /// </summary>
            [NameInMap("notifyStrategyName")]
            [Validation(Required=false)]
            public string NotifyStrategyName { get; set; }

            /// <summary>
            /// <para>The recipient address, such as a phone number, email address, or webhook URL, depending on the notification channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13800138000</para>
            /// </summary>
            [NameInMap("receiver")]
            [Validation(Required=false)]
            public string Receiver { get; set; }

            /// <summary>
            /// <para>The notification delivery result details. This is the raw response content returned by the channel, such as the API response from a DingTalk or Lark bot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;errcode&quot;:0,&quot;errmsg&quot;:&quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>The alert rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3fa85f64-5717-4562-b3fc-2c963f66afa6</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The alert rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU usage alert</para>
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The notification delivery type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUBSCRIBE: subscription notifications</description></item>
            /// <item><description>DIRECT: direct event notifications</description></item>
            /// <item><description>ITSM: ticket or action notifications</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUBSCRIBE</para>
            /// </summary>
            [NameInMap("sendType")]
            [Validation(Required=false)]
            public string SendType { get; set; }

            /// <summary>
            /// <para>The alert severity. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CRITICAL: critical</description></item>
            /// <item><description>ERROR: error</description></item>
            /// <item><description>WARNING: warning</description></item>
            /// <item><description>INFO: information</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <para>The incident status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TRIGGERED: triggered</description></item>
            /// <item><description>RESOLVED: resolved</description></item>
            /// <item><description>ACK: acknowledged</description></item>
            /// <item><description>ESCALATED: escalated</description></item>
            /// <item><description>MANUAL_RESOLVED: manually resolved</description></item>
            /// <item><description>TIMEOUT: automatically resolved due to timeout</description></item>
            /// <item><description>RETRIGGERED: retriggered</description></item>
            /// <item><description>PARTIAL_RESOLVED: partially resolved</description></item>
            /// <item><description>INVALID: invalid</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TRIGGERED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subscription ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d</para>
            /// </summary>
            [NameInMap("subscriptionId")]
            [Validation(Required=false)]
            public string SubscriptionId { get; set; }

            /// <summary>
            /// <para>The subscription name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default subscription</para>
            /// </summary>
            [NameInMap("subscriptionName")]
            [Validation(Required=false)]
            public string SubscriptionName { get; set; }

            /// <summary>
            /// <para>Indicates whether the notification was delivered successfully. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The notification was delivered successfully.</description></item>
            /// <item><description>false: The notification delivery failed.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The time when the notification record was generated. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729400000</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public int? Timestamp { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the notification record belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5884500827389836</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned by this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. It is an opaque string generated and encrypted by the server. An empty value indicates that no more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f8aKz3mNq9p****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-************</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of notification history entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
