// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListUserNotifyHistoriesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3fa85f64-5717-4562-b3fc-2c963f66afa7</para>
        /// </summary>
        [NameInMap("batchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>arms</para>
        /// </summary>
        [NameInMap("bizSource")]
        [Validation(Required=false)]
        [Obsolete]
        public string BizSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DING</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WEBHOOK</para>
        /// </summary>
        [NameInMap("channelCategory")]
        [Validation(Required=false)]
        public string ChannelCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1729400000</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>运维联系人组</para>
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5d41402abc4b2a76b9719d911017c592</para>
        /// </summary>
        [NameInMap("incidentId")]
        [Validation(Required=false)]
        public string IncidentId { get; set; }

        [NameInMap("includeNoChannel")]
        [Validation(Required=false)]
        public bool? IncludeNoChannel { get; set; }

        [NameInMap("isDesc")]
        [Validation(Required=false)]
        public bool? IsDesc { get; set; }

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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("partitionKey")]
        [Validation(Required=false)]
        [Obsolete]
        public string PartitionKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13800138000</para>
        /// </summary>
        [NameInMap("receiver")]
        [Validation(Required=false)]
        public string Receiver { get; set; }

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
        /// <para>1729421600</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        /// <summary>
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
