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
            /// <para>The end of the time range during which the alert rule is effective. Valid values: 0 to 23.</para>
            /// <para>For example, if the <c>AlertConfig.StartTime</c> parameter is set to 0 and the <c>AlertConfig.EndTime</c> parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.</para>
            /// <remarks>
            /// <para>Alert notifications are sent based on the specified threshold only if the alert rule is effective.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// <para>The alert notification methods. Valid values:</para>
            /// <para>0: Alert notifications are sent by using emails and DingTalk chatbots.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public int? NotifyType { get; set; }

            /// <summary>
            /// <para>The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400. The default value indicates one day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// <para>The beginning of the time range during which the alert rule is effective. Valid values: 0 to 23.</para>
            /// <para>For example, if the <c>AlertConfig.StartTime</c> parameter is set to 0 and the <c>AlertConfig.EndTime</c> parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.</para>
            /// <remarks>
            /// <para>Alert notifications are sent based on the specified threshold only if the alert rule is effective.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
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
            /// <para>The header of the HTTP request. Format: <c>Parameter name:Parameter value</c>. Separate multiple parameters with carriage return characters. Example:</para>
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
            /// <para>The HTTP request method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GET</description></item>
            /// <item><description>POST</description></item>
            /// <item><description>HEAD</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be specified when TaskType is set to HTTP.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("HttpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            /// <summary>
            /// <para>The method to trigger an alert. The alert can be triggered based on whether the specified alert rule is included in the response body. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: If the HTTP response body includes the alert rule, an alert is triggered.</description></item>
            /// <item><description>false: If the HTTP response does not include the alert rule, an alert is triggered.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter must be specified when TaskType is set to HTTP.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HttpNegative")]
            [Validation(Required=false)]
            public bool? HttpNegative { get; set; }

            /// <summary>
            /// <para>The content of the HTTP POST request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>params1=paramsValue1</para>
            /// </summary>
            [NameInMap("HttpPostContent")]
            [Validation(Required=false)]
            public string HttpPostContent { get; set; }

            /// <summary>
            /// <para>The character set that is used in the HTTP response.</para>
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
            /// <para>The response to the HTTP request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("HttpResponseMatchContent")]
            [Validation(Required=false)]
            public string HttpResponseMatchContent { get; set; }

            /// <summary>
            /// <para>The URI that you want to monitor. This parameter is required if the TaskType parameter is set to HTTP or Telnet.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("HttpURI")]
            [Validation(Required=false)]
            public string HttpURI { get; set; }

            /// <summary>
            /// <para>The interval at which detection requests are sent. Unit: seconds. Valid values: 15, 30, 60, 120, 300, 900, 1800, and 3600.</para>
            /// <remarks>
            /// <para>This parameter is available only for the CloudMonitor agent V3.5.1 or later.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// <para>The domain name or IP address that you want to monitor.</para>
            /// <remarks>
            /// <para> This parameter is required if the TaskType parameter is set to PING.</para>
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
        /// <para>None</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertConfigEscalationList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigEscalationList> AlertConfigEscalationList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigEscalationList : TeaModel {
            /// <summary>
            /// <para>The method used to calculate the metric values that trigger alerts. Valid values of N: 1 to 21. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HttpStatus: Value</description></item>
            /// <item><description>HttpLatency: Average</description></item>
            /// <item><description>TelnetStatus: Value</description></item>
            /// <item><description>TelnetLatency: Average</description></item>
            /// <item><description>PingLostRate: Average</description></item>
            /// </list>
            /// <remarks>
            /// <para>The value Value indicates the original value and is used for metrics such as status codes. The value Average indicates the average value and is used for metrics such as the latency and packet loss rate.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Value</para>
            /// </summary>
            [NameInMap("Aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            /// <summary>
            /// <para>The metric for which the alert feature is enabled. Valid values of N: 1 to 21. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HttpStatus: HTTP status code</description></item>
            /// <item><description>HttpLatency: HTTP response time</description></item>
            /// <item><description>TelnetStatus: Telnet status code</description></item>
            /// <item><description>TelnetLatency: Telnet response time</description></item>
            /// <item><description>PingLostRate: Ping packet loss rate</description></item>
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
            /// <para>The comparison operator that is used in the alert rule. Valid values of N: 1 to 21. Valid values:</para>
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
            /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered. Valid values of N: 1 to 21.</para>
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
        /// <para>The resources for which alerts are triggered.</para>
        /// </summary>
        [NameInMap("AlertConfigTargetList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigTargetList> AlertConfigTargetList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigTargetList : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the resource. Format: <c>acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message</c>. Example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. Fields:</para>
            /// <list type="bullet">
            /// <item><description><para>{Service name abbreviation}: the abbreviation of the service name. Set the value to Simple Message Queue (formerly MNS) (SMQ).</para>
            /// </description></item>
            /// <item><description><para>{userId}: the ID of the Alibaba Cloud account.</para>
            /// </description></item>
            /// <item><description><para>{regionId}: the region ID of the SMQ queue or topic.</para>
            /// </description></item>
            /// <item><description><para>{Resource type}: the type of the resource for which alerts are triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>queues</b></description></item>
            /// <item><description><b>topics</b></description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>{Resource name}: the resource name.</para>
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
            /// <para>The ID of the resource for which alerts are triggered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The parameters of the alert callback. The parameters are in the JSON format.</para>
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
            /// <item><description>INFO</description></item>
            /// <item><description>WARN</description></item>
            /// <item><description>CRITICAL</description></item>
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
        /// <para>The ECS instances that are monitored. Valid values of N: 1 to 21.</para>
        /// <remarks>
        /// <para>This parameter must be specified when <c>TaskScope</c> is set to <c>GROUP_SPEC_INSTANCE</c>.</para>
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
        /// <para>The name of the availability monitoring task. The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The range of instances that are monitored by the availability monitoring task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GROUP: All Elastic Compute Service (ECS) instances in the application group are monitored.</description></item>
        /// <item><description>GROUP_SPEC_INSTANCE: Specified ECS instances in the application group are monitored. The TaskScope parameter must be used in combination with the InstanceList.N parameter. The InstanceList.N parameter specifies the ECS instances to be monitored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GROUP</para>
        /// </summary>
        [NameInMap("TaskScope")]
        [Validation(Required=false)]
        public string TaskScope { get; set; }

        /// <summary>
        /// <para>The monitoring type of the availability monitoring task. Valid values:</para>
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
