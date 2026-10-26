// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListUserNotifyHistoriesResponseBody : TeaModel {
        [NameInMap("historyList")]
        [Validation(Required=false)]
        public List<ListUserNotifyHistoriesResponseBodyHistoryList> HistoryList { get; set; }
        public class ListUserNotifyHistoriesResponseBodyHistoryList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>DING</para>
            /// </summary>
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三,李四</para>
            /// </summary>
            [NameInMap("contacts")]
            [Validation(Required=false)]
            public string Contacts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>运维组,值班组</para>
            /// </summary>
            [NameInMap("groups")]
            [Validation(Required=false)]
            public string Groups { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5d41402abc4b2a76b9719d911017c592</para>
            /// </summary>
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public string IncidentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3fa85f64-5717-4562-b3fc-2c963f66afa8</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("noChannel")]
            [Validation(Required=false)]
            public bool? NoChannel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e</para>
            /// </summary>
            [NameInMap("notifyStrategyId")]
            [Validation(Required=false)]
            public string NotifyStrategyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>默认通知策略</para>
            /// </summary>
            [NameInMap("notifyStrategyName")]
            [Validation(Required=false)]
            public string NotifyStrategyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13800138000</para>
            /// </summary>
            [NameInMap("receiver")]
            [Validation(Required=false)]
            public string Receiver { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;errcode&quot;:0,&quot;errmsg&quot;:&quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3fa85f64-5717-4562-b3fc-2c963f66afa6</para>
            /// </summary>
            [NameInMap("ruleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CPU使用率告警</para>
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUBSCRIBE</para>
            /// </summary>
            [NameInMap("sendType")]
            [Validation(Required=false)]
            public string SendType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("severity")]
            [Validation(Required=false)]
            public string Severity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TRIGGERED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d</para>
            /// </summary>
            [NameInMap("subscriptionId")]
            [Validation(Required=false)]
            public string SubscriptionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>默认订阅</para>
            /// </summary>
            [NameInMap("subscriptionName")]
            [Validation(Required=false)]
            public string SubscriptionName { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1729400000</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public int? Timestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5884500827389836</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2f8aKz3mNq9p****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-************</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
