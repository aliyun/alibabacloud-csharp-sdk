// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHostAvailabilityRequest : TeaModel {
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public CreateHostAvailabilityRequestAlertConfig AlertConfig { get; set; }
        public class CreateHostAvailabilityRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>报警生效的结束时间。取值范围：0~23。</para>
            /// <para>例如：<c>AlertConfig.StartTime</c>为0，<c>AlertConfig.EndTime</c>为22，表示报警生效时间为00:00:00至22:00:00。</para>
            /// <remarks>
            /// <para>如果报警不在生效时间内，则超过阈值也不会发送报警通知。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>报警通知类型。取值：</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 2：电话+短信+邮件+钉钉机器人。</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 1：短信+邮件+钉钉机器人。</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 0：邮件+钉钉机器人。</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;0：邮件+钉钉机器人。</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;0：邮件+钉钉机器人。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public int? NotifyType { get; set; }

            /// <summary>
            /// <para>通道沉默时间。单位：秒，默认值：86400（1天）。</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// <para>报警生效的开始时间。取值范围：0~23。</para>
            /// <para>例如：<c>AlertConfig.StartTime</c>为0，<c>AlertConfig.EndTime</c>为22，表示报警生效时间为00:00:00至22:00:00。</para>
            /// <remarks>
            /// <para>如果报警不在生效时间内，则超过阈值也不会发送报警通知。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>URL回调地址。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com/webhook.json">https://www.aliyun.com/webhook.json</a></para>
            /// </summary>
            [NameInMap("WebHook")]
            [Validation(Required=false)]
            public string WebHook { get; set; }

        }

        [NameInMap("TaskOption")]
        [Validation(Required=false)]
        public CreateHostAvailabilityRequestTaskOption TaskOption { get; set; }
        public class CreateHostAvailabilityRequestTaskOption : TeaModel {
            /// <summary>
            /// <para>HTTP请求的Header。格式为<c>参数名:参数</c>，多个参数之间用回车符分隔，例如：</para>
            /// <pre><c>params1:value1
            /// params2:value2
            /// </c></pre>
            /// 
            /// <b>Example:</b>
            /// <para>token:testTokenValue</para>
            /// </summary>
            [NameInMap("HttpHeader")]
            [Validation(Required=false)]
            public string HttpHeader { get; set; }

            /// <summary>
            /// <para>探测类型的方法。取值：</para>
            /// <list type="bullet">
            /// <item><description>GET</description></item>
            /// <item><description>POST</description></item>
            /// <item><description>HEAD</description></item>
            /// </list>
            /// <remarks>
            /// <para>如果任务的探测类型为HTTP，则需要设置该参数。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("HttpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            /// <summary>
            /// <para>匹配HTTP响应内容的报警规则。取值：</para>
            /// <list type="bullet">
            /// <item><description>true：如果HTTP响应内容包含设置的报警规则，则报警。</description></item>
            /// <item><description>false：如果HTTP响应内容不包含设置的报警规则，则报警。</description></item>
            /// </list>
            /// <remarks>
            /// <para>如果任务的探测类型为HTTP，则该参数生效。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HttpNegative")]
            [Validation(Required=false)]
            public bool? HttpNegative { get; set; }

            /// <summary>
            /// <para>HTTP探测类型探测请求的Post内容。</para>
            /// 
            /// <b>Example:</b>
            /// <para>params1=paramsValue1</para>
            /// </summary>
            [NameInMap("HttpPostContent")]
            [Validation(Required=false)]
            public string HttpPostContent { get; set; }

            /// <summary>
            /// <para>HTTP探测类型的响应字符集。</para>
            /// <remarks>
            /// <para>仅支持UTF-8。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>UTF-8</para>
            /// </summary>
            [NameInMap("HttpResponseCharset")]
            [Validation(Required=false)]
            public string HttpResponseCharset { get; set; }

            /// <summary>
            /// <para>匹配响应的内容。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("HttpResponseMatchContent")]
            [Validation(Required=false)]
            public string HttpResponseMatchContent { get; set; }

            /// <summary>
            /// <para>HTTP、Telnet探测类型的探测URI地址。</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a>
            /// telnet://127.0.0.1:80</para>
            /// </summary>
            [NameInMap("HttpURI")]
            [Validation(Required=false)]
            public string HttpURI { get; set; }

            /// <summary>
            /// <para>探测频率。单位：秒。取值：15、30、60、120、300、900、1800和3600。</para>
            /// <remarks>
            /// <para>仅3.5.1及以上版本的云监控插件支持该参数。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>探测的域名或地址。</para>
            /// <remarks>
            /// <para>如果探测任务类型为PING，则需要设置该参数。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("TelnetOrPingHost")]
            [Validation(Required=false)]
            public string TelnetOrPingHost { get; set; }

        }

        /// <summary>
        /// <para>None.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertConfigEscalationList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigEscalationList> AlertConfigEscalationList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigEscalationList : TeaModel {
            /// <summary>
            /// <para>The statistical method for the alert. Valid values of N: 1 to 21. The valid values vary based on the metric:</para>
            /// <list type="bullet">
            /// <item><description>HttpStatus: Value.</description></item>
            /// <item><description>HttpLatency: Average.</description></item>
            /// <item><description>TelnetStatus: Value.</description></item>
            /// <item><description>TelnetLatency: Average.</description></item>
            /// <item><description>PingLostRate: Average.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The statistical method for status code metrics is the raw value (Value). The statistical method for latency or packet loss rate metrics is the average value (Average).</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Value</para>
            /// </summary>
            [NameInMap("Aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            /// <summary>
            /// <para>The metric for the alert. Valid values of N: 1 to 21. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HttpStatus: HTTP status code.</description></item>
            /// <item><description>HttpLatency: HTTP latency.</description></item>
            /// <item><description>TelnetStatus: Telnet status code.</description></item>
            /// <item><description>TelnetLatency: Telnet latency.</description></item>
            /// <item><description>PingLostRate: Ping packet loss rate.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HttpStatus</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The comparison operator for the alert rule. Valid values of N: 1 to 21. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>&gt;</c></description></item>
            /// <item><description><c>&gt;=</c></description></item>
            /// <item><description><c>&lt;</c></description></item>
            /// <item><description><c>&lt;=</c></description></item>
            /// <item><description><c>=</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <remarks>
            /// </remarks>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The number of alert retries. Valid values of N: 1 to 21.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

            /// <summary>
            /// <para>The alert threshold. Valid values of N: 1 to 21.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The alert trigger targets.</para>
        /// </summary>
        [NameInMap("AlertConfigTargetList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigTargetList> AlertConfigTargetList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigTargetList : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the resource. Format: <c>acs:{AbbreviatedServiceName}:{regionId}:{userId}:/{ResourceType}/{ResourceName}/message</c>. Example: <c>acs:mns:ap-southeast-1:120886317861****:/queues/test123/message</c>. The following list describes the parameters:</para>
            /// <list type="bullet">
            /// <item><description><para>{AbbreviatedServiceName}: Only Simple Message Queue (formerly MNS) is supported.</para>
            /// </description></item>
            /// <item><description><para>{userId}: The Alibaba Cloud account ID.</para>
            /// </description></item>
            /// <item><description><para>{regionId}: The region where the Simple Message Queue (formerly MNS) queue or topic resides.</para>
            /// </description></item>
            /// <item><description><para>{ResourceType}: The type of the resource that accepts alerts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>queues</b>: queue.</description></item>
            /// <item><description><b>topics</b>: topic.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>{ResourceName}: The name of the resource.</para>
            /// <list type="bullet">
            /// <item><description>If the resource type is <b>queues</b>, the resource name is the queue name.</description></item>
            /// <item><description>If the resource type is <b>topics</b>, the resource name is the topic name.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:mns:cn-hangzhou:120886317861****:/queues/test/message</para>
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// <para>The ID of the alert trigger target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The JSON-formatted parameters for the alert callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;customField1&quot;:&quot;value1&quot;,&quot;customField2&quot;:&quot;$.name&quot;}</para>
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// <para>The alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INFO: information.</description></item>
            /// <item><description>WARN: warning.</description></item>
            /// <item><description>CRITICAL: critical.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;INFO&quot;, &quot;WARN&quot;, &quot;CRITICAL&quot;]</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The list of ECS instances that initiate detection. Valid values of N: 1 to 21.</para>
        /// <remarks>
        /// <para>Set this parameter when <c>TaskScope</c> is set to <c>GROUP_SPEC_INSTANCE</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-absdfkwl321****</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<string> InstanceList { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the availability monitoring task. The name must be 4 to 100 characters in length and can contain letters, digits, underscores (_), and Chinese characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The detection scope of the availability monitoring task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GROUP: uses all ECS instances in the current application group as detection probes.</description></item>
        /// <item><description>GROUP_SPEC_INSTANCE: uses specified ECS instances in the current application group as detection probes. If you set this parameter to GROUP_SPEC_INSTANCE, you must also set InstanceList to specify the ECS instances that initiate detection.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP</para>
        /// </summary>
        [NameInMap("TaskScope")]
        [Validation(Required=false)]
        public string TaskScope { get; set; }

        /// <summary>
        /// <para>The detection type of the availability monitoring task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PING</description></item>
        /// <item><description>TELNET</description></item>
        /// <item><description>HTTP.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
