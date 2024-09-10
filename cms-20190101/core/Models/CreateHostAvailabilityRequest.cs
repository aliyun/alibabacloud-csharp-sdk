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
            /// The end of the time range during which the alert rule is effective. Valid values: 0 to 23.
            /// 
            /// For example, if the `AlertConfig.StartTime` parameter is set to 0 and the `AlertConfig.EndTime` parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.
            /// 
            /// > Alert notifications are sent based on the specified threshold only if the alert rule is effective.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// The alert notification methods. Valid values:
            /// 
            /// 0: Alert notifications are sent by using emails and DingTalk chatbots.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public int? NotifyType { get; set; }

            /// <summary>
            /// The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400. The default value indicates one day.
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// The beginning of the time range during which the alert rule is effective. Valid values: 0 to 23.
            /// 
            /// For example, if the `AlertConfig.StartTime` parameter is set to 0 and the `AlertConfig.EndTime` parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.
            /// 
            /// > Alert notifications are sent based on the specified threshold only if the alert rule is effective.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// The callback URL.
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
            /// The header of the HTTP request. Format: `Parameter name:Parameter value`. Separate multiple parameters with carriage return characters. Example:
            /// 
            ///     params1:value1
            ///     params2:value2
            /// </summary>
            [NameInMap("HttpHeader")]
            [Validation(Required=false)]
            public string HttpHeader { get; set; }

            /// <summary>
            /// The HTTP request method. Valid values:
            /// 
            /// *   GET
            /// *   POST
            /// *   HEAD
            /// 
            /// > This parameter must be specified when TaskType is set to HTTP.
            /// </summary>
            [NameInMap("HttpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            /// <summary>
            /// The method to trigger an alert. The alert can be triggered based on whether the specified alert rule is included in the response body. Valid values:
            /// 
            /// *   true: If the HTTP response body includes the alert rule, an alert is triggered.
            /// *   false: If the HTTP response does not include the alert rule, an alert is triggered.
            /// 
            /// > This parameter must be specified when TaskType is set to HTTP.
            /// </summary>
            [NameInMap("HttpNegative")]
            [Validation(Required=false)]
            public bool? HttpNegative { get; set; }

            /// <summary>
            /// The content of the HTTP POST request.
            /// </summary>
            [NameInMap("HttpPostContent")]
            [Validation(Required=false)]
            public string HttpPostContent { get; set; }

            /// <summary>
            /// The character set that is used in the HTTP response.
            /// 
            /// > Only UTF-8 is supported.
            /// </summary>
            [NameInMap("HttpResponseCharset")]
            [Validation(Required=false)]
            public string HttpResponseCharset { get; set; }

            /// <summary>
            /// The response to the HTTP request.
            /// </summary>
            [NameInMap("HttpResponseMatchContent")]
            [Validation(Required=false)]
            public string HttpResponseMatchContent { get; set; }

            /// <summary>
            /// The URI that you want to monitor. This parameter must be specified when TaskType is set to HTTP.
            /// </summary>
            [NameInMap("HttpURI")]
            [Validation(Required=false)]
            public string HttpURI { get; set; }

            /// <summary>
            /// The interval at which detection requests are sent. Unit: seconds. Valid values: 15, 30, 60, 120, 300, 900, 1800, and 3600.
            /// 
            /// > This parameter is available only for the CloudMonitor agent V3.5.1 or later.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The domain name or IP address that you want to monitor.
            /// 
            /// > This parameter must be specified when TaskType is set to PING or TELNET.
            /// </summary>
            [NameInMap("TelnetOrPingHost")]
            [Validation(Required=false)]
            public string TelnetOrPingHost { get; set; }

        }

        /// <summary>
        /// None
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlertConfigEscalationList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigEscalationList> AlertConfigEscalationList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigEscalationList : TeaModel {
            /// <summary>
            /// The method used to calculate the metric values that trigger alerts. Valid values of N: 1 to 21. Valid values:
            /// 
            /// *   HttpStatus: Value
            /// *   HttpLatency: Average
            /// *   TelnetStatus: Value
            /// *   TelnetLatency: Average
            /// *   PingLostRate: Average
            /// 
            /// > The value Value indicates the original value and is used for metrics such as status codes. The value Average indicates the average value and is used for metrics such as the latency and packet loss rate.
            /// </summary>
            [NameInMap("Aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            /// <summary>
            /// The metric for which the alert feature is enabled. Valid values of N: 1 to 21. Valid values:
            /// 
            /// *   HttpStatus: HTTP status code
            /// *   HttpLatency: HTTP response time
            /// *   TelnetStatus: Telnet status code
            /// *   TelnetLatency: Telnet response time
            /// *   PingLostRate: Ping packet loss rate
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The comparison operator that is used in the alert rule. Valid values of N: 1 to 21. Valid values:
            /// 
            /// *   `>`
            /// *   `>=`
            /// *   `<`
            /// *   `<=`
            /// *   `=`
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered. Valid values of N: 1 to 21.
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

            /// <summary>
            /// The alert threshold. Valid values of N: 1 to 21.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The information about the resources for which alerts are triggered.
        /// </summary>
        [NameInMap("AlertConfigTargetList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigTargetList> AlertConfigTargetList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigTargetList : TeaModel {
            /// <summary>
            /// The Alibaba Cloud Resource Name (ARN) of the resource. Format: `acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message`. Example: `acs:mns:cn-hangzhou:120886317861****:/queues/test123/message`. Fields:
            /// 
            /// *   {Service name abbreviation}: the abbreviation of the service name. Valid value: mns.
            /// 
            /// *   {userId}: the ID of the Alibaba Cloud account.
            /// 
            /// *   {regionId}: the region ID of the message queue or topic.
            /// 
            /// *   {Resource type}: the type of the resource that triggers the alert. Valid values:
            /// 
            ///     *   **queues**
            ///     *   **topics**
            /// 
            /// *   {Resource name}: the resource name.
            /// 
            ///     *   If the resource type is **queues**, the resource name is the queue name.
            ///     *   If the resource type is **topics**, the resource name is the topic name.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The ID of the resource for which alerts are triggered.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The parameters of the alert callback. The parameters are in the JSON format.
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// The alert level. Valid values:
            /// 
            /// *   INFO
            /// *   WARN
            /// *   CRITICAL
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// The ID of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// The ECS instances that are monitored. Valid values of N: 1 to 21.
        /// 
        /// > This parameter must be specified when `TaskScope` is set to `GROUP_SPEC_INSTANCE`.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<string> InstanceList { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the availability monitoring task. The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (_).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The range of instances that are monitored by the availability monitoring task. Valid values:
        /// 
        /// *   GROUP: All Elastic Compute Service (ECS) instances in the application group are monitored.
        /// *   GROUP_SPEC_INSTANCE: Specified ECS instances in the application group are monitored. The TaskScope parameter must be used in combination with the InstanceList.N parameter. The InstanceList.N parameter specifies the ECS instances to be monitored.
        /// </summary>
        [NameInMap("TaskScope")]
        [Validation(Required=false)]
        public string TaskScope { get; set; }

        /// <summary>
        /// The monitoring type of the availability monitoring task. Valid values:
        /// 
        /// *   PING
        /// *   TELNET
        /// *   HTTP
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
