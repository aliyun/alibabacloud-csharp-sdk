// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListUserNotifyHistoriesRequest : TeaModel {
        /// <summary>
        /// <para>The notification batch ID. Used to filter the notification history for notifications delivered in the same batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3fa85f64-5717-4562-b3fc-2c963f66afa7</para>
        /// </summary>
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This is an internal reserved parameter used only for business source filtering in internal platform scenarios. Do not pass this parameter in external calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        [Obsolete]
        public string BizSource { get; set; }

        /// <summary>
        /// <para>The notification channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALI_YUNGE_SMS: text message</description></item>
        /// <item><description>ALI_YUNGE_CALL: voice call</description></item>
        /// <item><description>ALI_YUNGE_MAIL: email</description></item>
        /// <item><description>ALI_YUNGE_ALIUID: internal message</description></item>
        /// <item><description>DING: DingTalk</description></item>
        /// <item><description>DING_COOL_APP: DingTalk Cool App</description></item>
        /// <item><description>FEISHU: Lark</description></item>
        /// <item><description>WEIXIN: WeCom</description></item>
        /// <item><description>SLACK: Slack</description></item>
        /// <item><description>TEAMS: Teams</description></item>
        /// <item><description>PAGERDUTY: PagerDuty</description></item>
        /// <item><description>WEBHOOK: custom webhook</description></item>
        /// <item><description>ALIYUN_SLS: Simple Log Service</description></item>
        /// <item><description>ALIYUN_FC: Function Compute</description></item>
        /// <item><description>ALIYUN_FC3: Function Compute 3.0</description></item>
        /// <item><description>ALIYUN_MNS: Message Service</description></item>
        /// <item><description>ALIYUN_OOS: CloudOps Orchestration Service</description></item>
        /// <item><description>ALIYUN_ESS: elastic scaling</description></item>
        /// <item><description>ALIYUN_EB: event bus</description></item>
        /// <item><description>ALIYUN_OPENAPI: OpenAPI</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DING</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <para>The channel category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WEBHOOK: webhook-based channels, such as DingTalk, Lark, WeCom, Slack, Teams, and custom webhooks</description></item>
        /// <item><description>YUNGE: Yunge communication channels, such as text messages, voice calls, and emails</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WEBHOOK</para>
        /// </summary>
        [NameInMap("channelCategory")]
        [Validation(Required=false)]
        public string ChannelCategory { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds. Default value: 6 hours before the <c>to</c> parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1729400000</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <para>The contact group. Used to filter the notification history by contact group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>O&amp;M contact group</para>
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The incident ID. Used to filter the notification history associated with a specified incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5d41402abc4b2a76b9719d911017c592</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        /// <summary>
        /// <para>Specifies whether to include notification records that have no actual delivery channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The records are included.</description></item>
        /// <item><description>false: The records are not included. Only records that were actually delivered through a channel are returned.
        /// Default value: true.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("includeNoChannel")]
        [Validation(Required=false)]
        public bool? IncludeNoChannel { get; set; }

        /// <summary>
        /// <para>Specifies whether to sort the results in descending order of time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The results are sorted in descending order, with the latest records appearing first.</description></item>
        /// <item><description>false: The results are sorted in ascending order.
        /// Default value: true.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("isDesc")]
        [Validation(Required=false)]
        public bool? IsDesc { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Used to retrieve the next page of data. It is an opaque string generated and encrypted by the server. You do not need to specify this parameter for the first query. For subsequent queries, pass the token returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2f8aKz3mNq9p****</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The notification policy ID. Used to filter the notification history for a specified notification policy. It is a 32-character string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d7e</para>
        /// </summary>
        [NameInMap("notifyStrategyId")]
        [Validation(Required=false)]
        public string NotifyStrategyId { get; set; }

        /// <summary>
        /// <para>The notification policy name. Used to filter the notification history by notification policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default notification policy</para>
        /// </summary>
        [NameInMap("notifyStrategyName")]
        [Validation(Required=false)]
        public string NotifyStrategyName { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> This is an internal reserved parameter used only for dedicated notification history query paths in internal platform scenarios. Do not pass this parameter in external calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        [Obsolete]
        public string PartitionKey { get; set; }

        /// <summary>
        /// <para>The recipient. Used to filter the notification history by recipient address, such as a phone number, email address, or webhook URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("receiver")]
        [Validation(Required=false)]
        public string Receiver { get; set; }

        /// <summary>
        /// <para>The alert rule ID. Used to filter the notification history triggered by a specified alert rule. Exact match is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3fa85f64-5717-4562-b3fc-2c963f66afa6</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The alert rule name. Used to filter the notification history by rule name.</para>
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
        /// <para>The subscription ID. Used to filter the notification history for a specified subscription. It is a 32-character string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6d</para>
        /// </summary>
        [NameInMap("subscriptionId")]
        [Validation(Required=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// <para>The subscription name. Used to filter the notification history by subscription name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default subscription</para>
        /// </summary>
        [NameInMap("subscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <para>Specifies whether to filter by delivery result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only successfully delivered records are returned.</description></item>
        /// <item><description>false: Only failed delivery records are returned.
        /// If you do not specify this parameter, the results are not filtered by delivery result.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds. Default value: the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1729421600</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default-cms-5884500827389836-cn-hangzhou</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
