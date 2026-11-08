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
            /// <para>The end time of the effective period for alerting.</para>
            /// <para>The value is an integer ranging from 0 to 23. Unit: hours. The value indicates the hour when the effective period ends. The actual end time is 00:00:00 of the specified hour. For example, if you set this parameter to 22, the effective period ends at 22:00:00. The time zone is UTC+8.</para>
            /// <remarks>
            /// <para>Note: If the current time is not within the effective time window, the system does not send alert notifications even if the threshold is exceeded.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>The alert notification method. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 2: phone call, text message, email, and DingTalk chatbot.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 1: text message, email, and DingTalk chatbot.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- 0: email and DingTalk chatbot.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;0: email and DingTalk chatbot.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;0: email and DingTalk chatbot.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public int? NotifyType { get; set; }

            /// <summary>
            /// <para>The mute period. Unit: seconds. Default value: 86400 (1 day).</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// <para>The start time of the effective period for alerting.</para>
            /// <para>The value is an integer ranging from 0 to 23. Unit: hours. The value indicates the hour when the effective period starts. The actual start time is 00:00:00 of the specified hour. For example, if you set this parameter to 0, the effective period starts at 00:00:00. The time zone is UTC+8.</para>
            /// <remarks>
            /// <para>Note: If the current time is not within the effective time window, the system does not send alert notifications even if the threshold is exceeded.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>The webhook address.</para>
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
            /// <para>The headers of the HTTP request. The format is <c>Parameter name:Parameter value</c>. Separate multiple headers with carriage returns. Example:</para>
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
            /// <para>The HTTP method for the probe. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GET</description></item>
            /// <item><description>POST</description></item>
            /// <item><description>HEAD</description></item>
            /// </list>
            /// <remarks>
            /// <para>If the probe type is HTTP, you must set this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("HttpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            /// <summary>
            /// <para>The alert rule for matching the HTTP response content. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: An alert is triggered if the HTTP response content contains the specified string.</description></item>
            /// <item><description>false: An alert is triggered if the HTTP response content does not contain the specified string.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when the probe type is HTTP.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HttpNegative")]
            [Validation(Required=false)]
            public bool? HttpNegative { get; set; }

            /// <summary>
            /// <para>The POST content of the HTTP probe request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>params1=paramsValue1</para>
            /// </summary>
            [NameInMap("HttpPostContent")]
            [Validation(Required=false)]
            public string HttpPostContent { get; set; }

            /// <summary>
            /// <para>The response character set for HTTP probes.</para>
            /// <remarks>
            /// <para>Only UTF-8 is supported.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>UTF-8</para>
            /// </summary>
            [NameInMap("HttpResponseCharset")]
            [Validation(Required=false)]
            public string HttpResponseCharset { get; set; }

            /// <summary>
            /// <para>The content to be matched in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("HttpResponseMatchContent")]
            [Validation(Required=false)]
            public string HttpResponseMatchContent { get; set; }

            /// <summary>
            /// <para>The URI for HTTP or Telnet probes.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a>
            /// telnet://127.0.0.1:80</para>
            /// </summary>
            [NameInMap("HttpURI")]
            [Validation(Required=false)]
            public string HttpURI { get; set; }

            /// <summary>
            /// <para>The probe interval. Unit: seconds. Valid values: 15, 30, 60, 120, 300, 900, 1800, and 3600.</para>
            /// <remarks>
            /// <para>This parameter is supported only by CloudMonitor agent V3.5.1 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The domain name or IP address to be probed.</para>
            /// <remarks>
            /// <para>If the probe type is PING, you must set this parameter.</para>
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
            /// <para>The statistical method for the alert. Valid values of N: 1 to 21. Valid values vary based on the metric:</para>
            /// <list type="bullet">
            /// <item><description>HttpStatus: Value.</description></item>
            /// <item><description>HttpLatency: Average.</description></item>
            /// <item><description>TelnetStatus: Value.</description></item>
            /// <item><description>TelnetLatency: Average.</description></item>
            /// <item><description>PingLostRate: Average.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The statistical method for status codes is the original value (Value), and the statistical method for response time or packet loss rate is the average value (Average).</para>
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
            /// <item><description>HttpLatency: HTTP response time.</description></item>
            /// <item><description>TelnetStatus: Telnet status code.</description></item>
            /// <item><description>TelnetLatency: Telnet response time.</description></item>
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
            /// <item><description><c>=</c></description></item>
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
        /// <para>The alert targets.</para>
        /// </summary>
        [NameInMap("AlertConfigTargetList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigTargetList> AlertConfigTargetList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigTargetList : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the resource. Format: <c>acs:{service abbreviation}:{regionId}:{userId}:/{resource type}/{resource name}/message</c>. Example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. Parameter description:</para>
            /// <list type="bullet">
            /// <item><description><para>{service abbreviation}: The abbreviation of the cloud service. Only Simple Message Queue (formerly MNS) is supported.</para>
            /// </description></item>
            /// <item><description><para>{userId}: The Alibaba Cloud account ID.</para>
            /// </description></item>
            /// <item><description><para>{regionId}: The region where the Simple Message Queue (formerly MNS) queue or topic resides.</para>
            /// </description></item>
            /// <item><description><para>{resource type}: The type of the resource that receives alerts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>queues</b>: queue.</description></item>
            /// <item><description><b>topics</b>: topic.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>{resource name}: The name of the resource.</para>
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
            /// <para>The ID of the alert target.</para>
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
        /// <para>The list of ECS instances that initiate the probes. Valid values of N: 1 to 21.</para>
        /// <remarks>
        /// <para>You must set this parameter when <c>TaskScope</c> is set to <c>GROUP_SPEC_INSTANCE</c>.</para>
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
        /// <para>The probe scope of the availability monitoring task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GROUP: All ECS instances in the current application group are used as probes for the task.</description></item>
        /// <item><description>GROUP_SPEC_INSTANCE: Specified ECS instances in the current application group are used as probes for the task. If you set this parameter to GROUP_SPEC_INSTANCE, you must also set the InstanceList parameter, which specifies the list of ECS instances that initiate the probes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP</para>
        /// </summary>
        [NameInMap("TaskScope")]
        [Validation(Required=false)]
        public string TaskScope { get; set; }

        /// <summary>
        /// <para>The probe type of the availability monitoring task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PING</description></item>
        /// <item><description>TELNET</description></item>
        /// <item><description>HTTP</description></item>
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
