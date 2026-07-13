// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class SubscribeShrinkRequest : TeaModel {
        [NameInMap("DlqPolicy")]
        [Validation(Required=false)]
        public string DlqPolicyShrink { get; set; }

        /// <summary>
        /// <para>邮箱推送相关属性，当 PushType=dm 时必填。JSON 格式，包含以下字段：</para>
        /// <list type="bullet">
        /// <item><description><b>AccountName</b>：发信地址，即 DirectMail 中配置的发信地址（如 <c>notify@example.com</c>）。</description></item>
        /// <item><description><b>Subject</b>：邮件主题。</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DmAttributes")]
        [Validation(Required=false)]
        public string DmAttributesShrink { get; set; }

        /// <summary>
        /// <para>短信推送相关属性，当 PushType=alisms 时必填。JSON 格式，包含以下字段：</para>
        /// <list type="bullet">
        /// <item><description><b>TemplateCode</b>：短信模板 Code，在短信服务控制台中获取。</description></item>
        /// <item><description><b>SignName</b>：短信签名名称。</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DysmsAttributes")]
        [Validation(Required=false)]
        public string DysmsAttributesShrink { get; set; }

        /// <summary>
        /// <para>接收消息的终端地址，格式根据 PushType 不同而不同：</para>
        /// <list type="bullet">
        /// <item><description><b>PushType=http</b>：HTTP/HTTPS 回调 URL，如 <c>http://example.com/callback</c> 或 <c>https://example.com/callback</c>。</description></item>
        /// <item><description><b>PushType=queue</b>：目标队列 ARN，格式为 <c>acs:mns:{RegionId}:{主账号UID}:queues/{QueueName}</c>。</description></item>
        /// <item><description><b>PushType=dm</b>：邮箱推送终端，格式固定为 <c>smq-ep:dm:{主账号UID}:__dynamic</c>，其中 <c>{主账号UID}</c> 替换为您的阿里云主账号 UID。</description></item>
        /// <item><description><b>PushType=dysms</b>：短信推送终端，格式为 <c>smq-ep:dysms:{主账号UID}:{手机号码}</c>。</description></item>
        /// <item><description><b>PushType=kafka</b>：Kafka 推送终端，格式为 <c>smq-ep:kafka:{主账号UID}:{InstanceId}</c>。</description></item>
        /// <item><description><b>PushType=fc</b>：函数计算终端，格式为 <c>acs:fc:{RegionId}:{主账号UID}:services/{ServiceName}/functions/{FunctionName}</c>。</description></item>
        /// <item><description><b>PushType=eventbus</b>：事件总线终端，格式为 <c>acs:eventbridge:{RegionId}:{主账号UID}:eventbus/{EventBusName}</c>。</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:mns:cn-hangzhou:1234567890:queues/MyQueue</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>Kafka 推送相关属性。JSON 格式，包含以下字段：</para>
        /// <list type="bullet">
        /// <item><description><b>BusinessMode</b>：业务模式。</description></item>
        /// </list>
        /// </summary>
        [NameInMap("KafkaAttributes")]
        [Validation(Required=false)]
        public string KafkaAttributesShrink { get; set; }

        /// <summary>
        /// <para>消息过滤标签（不超过 16 个字符），仅当消息带有相同标签时才会被推送到该订阅。不设置则表示不过滤，所有消息均推送。</para>
        /// 
        /// <b>Example:</b>
        /// <para>important</para>
        /// </summary>
        [NameInMap("MessageTag")]
        [Validation(Required=false)]
        public string MessageTag { get; set; }

        /// <summary>
        /// <para>推送的消息内容格式。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>XML</b>：消息体以 XML 格式推送（默认）。</description></item>
        /// <item><description><b>JSON</b>：消息体以 JSON 格式推送。</description></item>
        /// <item><description><b>SIMPLIFIED</b>：仅推送消息体原始内容，不包含 SMQ 的元信息包装。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLIFIED</para>
        /// </summary>
        [NameInMap("NotifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        /// <summary>
        /// <para>推送消息出现错误时的重试策略。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>BACKOFF_RETRY</b>：退避重试策略，重试间隔逐渐递增（推荐）。</description></item>
        /// <item><description><b>EXPONENTIAL_DECAY_RETRY</b>：指数衰减重试策略。</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BACKOFF_RETRY</para>
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// <para>订阅的推送类型。取值：</para>
        /// <list type="bullet">
        /// <item><description><b>http</b>：HTTP/HTTPS 推送，将消息推送到指定的 HTTP 或 HTTPS 回调地址。</description></item>
        /// <item><description><b>queue</b>：队列推送，将消息推送到指定的 SMQ 队列。</description></item>
        /// <item><description><b>dm</b>：邮箱推送，通过邮件服务（DirectMail）发送通知。需同时设置 DmAttributes 和 StsRoleArn 参数。</description></item>
        /// <item><description><b>dysms</b>：短信推送，通过阿里云短信服务发送通知。需同时设置 DysmsAttributes 参数。</description></item>
        /// <item><description><b>kafka</b>：Kafka 推送。需同时设置 KafkaAttributes 参数。</description></item>
        /// <item><description><b>fc</b>：函数计算推送，将消息推送到阿里云函数计算（FC）。</description></item>
        /// <item><description><b>eventbus</b>：事件总线推送，将消息推送到 EventBridge 事件总线。</description></item>
        /// </list>
        /// <remarks>
        /// <para>以下值已废弃，仅用于兼容旧订阅：mpush（移动推送）、alisms（旧版短信）、email（旧版邮箱，请使用 dm）。</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>queue</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// <para>SMQ 服务扮演的 RAM 角色 ARN。格式为 <c>acs:ram::{主账号UID}:role/{RoleName}</c>，其中 <c>{主账号UID}</c> 必须替换为调用 OpenAPI 的阿里云主账号 UID。</para>
        /// <para>使用场景：</para>
        /// <list type="bullet">
        /// <item><description>当 PushType=dm（邮箱推送）时<b>必填</b>，RoleName 通常为 <c>AliyunMNSNotificationRole</c>。</description></item>
        /// <item><description>当 PushType=queue 且目标队列与当前主题不在同一账号下时必填。</description></item>
        /// </list>
        /// <remarks>
        /// <para><b>注意</b>：ARN 中的 UID 必须与调用 OpenAPI 的主账号一致，否则将报跨账号错误（InvalidParameter: Cross account is not allowed）。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1234567890:role/AliyunMNSNotificationRole</para>
        /// </summary>
        [NameInMap("StsRoleArn")]
        [Validation(Required=false)]
        public string StsRoleArn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        [NameInMap("TenantRateLimitPolicy")]
        [Validation(Required=false)]
        public string TenantRateLimitPolicyShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
