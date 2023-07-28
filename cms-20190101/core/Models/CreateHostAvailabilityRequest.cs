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
            /// The name of the availability monitoring task. The name must be 4 to 100 characters in length, and can contain letters, digits, and underscores (\_).
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public int? EndTime { get; set; }

            /// <summary>
            /// The content of the HTTP POST request.
            /// </summary>
            [NameInMap("NotifyType")]
            [Validation(Required=false)]
            public int? NotifyType { get; set; }

            /// <summary>
            /// The interval at which detection requests are sent. Unit: seconds. Valid values: 15, 30, 60, 120, 300, 900, 1800, and 3600.
            /// 
            /// >  This parameter is available only for the CloudMonitor agent V3.5.1 or later.
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public int? SilenceTime { get; set; }

            /// <summary>
            /// The method used to calculate metric values that trigger alerts. Valid values of N: 1 to 21. Valid values:
            /// 
            /// *   HttpStatus: Value
            /// *   HttpLatency: Average
            /// *   TelnetStatus: Value
            /// *   TelnetLatency: Average
            /// *   PingLostRate: Average
            /// 
            /// >  The value Value indicates the original value and is used for metrics such as status codes. The value Average indicates the average value and is used for metrics, such as the latency and packet loss rate.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public int? StartTime { get; set; }

            /// <summary>
            /// The range of instances that are monitored by the availability monitoring task. Valid values:
            /// 
            /// *   GROUP: All ECS instances in the application group are monitored.
            /// *   GROUP_SPEC_INSTANCE: Specified ECS instances in the application group are monitored. The TaskScope parameter must be used in combination with the InstanceList.N parameter. The InstanceList.N parameter specifies the ECS instances to be monitored.
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
            /// The ID of the availability monitoring task.
            /// </summary>
            [NameInMap("HttpHeader")]
            [Validation(Required=false)]
            public string HttpHeader { get; set; }

            /// <summary>
            /// The level of the alert. Valid values:
            /// 
            /// *   INFO: information
            /// *   WARN: warning
            /// *   CRITICAL: critical
            /// </summary>
            [NameInMap("HttpMethod")]
            [Validation(Required=false)]
            public string HttpMethod { get; set; }

            /// <summary>
            /// The alert notification methods. Valid values:
            /// 
            /// 0: Alert notifications are sent by using emails and DingTalk chatbots.
            /// </summary>
            [NameInMap("HttpNegative")]
            [Validation(Required=false)]
            public bool? HttpNegative { get; set; }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("HttpPostContent")]
            [Validation(Required=false)]
            public string HttpPostContent { get; set; }

            /// <summary>
            /// The domain name or IP address that you want to monitor.
            /// 
            /// >  If the TaskType parameter is set to PING or TELNET, this parameter is required.
            /// </summary>
            [NameInMap("HttpResponseCharset")]
            [Validation(Required=false)]
            public string HttpResponseCharset { get; set; }

            /// <summary>
            /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered. Valid values of N: 1 to 21.
            /// </summary>
            [NameInMap("HttpResponseMatchContent")]
            [Validation(Required=false)]
            public string HttpResponseMatchContent { get; set; }

            /// <summary>
            /// The URI that you want to monitor. If the TaskType parameter is set to HTTP, this parameter is required.
            /// </summary>
            [NameInMap("HttpURI")]
            [Validation(Required=false)]
            public string HttpURI { get; set; }

            /// <summary>
            /// The header of the HTTP request. Format: `Parameter name:Parameter value`. Separate multiple parameters with carriage return characters. Example:
            /// 
            /// ```
            /// 
            /// params1:value1
            /// params2:value2
            /// ```
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public int? Interval { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("TelnetOrPingHost")]
            [Validation(Required=false)]
            public string TelnetOrPingHost { get; set; }

        }

        [NameInMap("AlertConfigEscalationList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigEscalationList> AlertConfigEscalationList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigEscalationList : TeaModel {
            /// <summary>
            /// The ECS instances that are monitored. Valid values of N: 1 to 21.
            /// 
            /// >  If the `TaskScope` parameter is set to `GROUP_SPEC_INSTANCE`, this parameter is required.
            /// </summary>
            [NameInMap("Aggregate")]
            [Validation(Required=false)]
            public string Aggregate { get; set; }

            /// <summary>
            /// The character set that is used in the HTTP response.
            /// 
            /// >  Valid value: UTF-8.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The method to trigger an alert. The alert can be triggered based on whether the specified alert rule is included in the response body. Valid values:
            /// 
            /// *   true: If the HTTP response body includes the alert rule, an alert is triggered.
            /// *   false: If the HTTP response does not include the alert rule, an alert is triggered.
            /// 
            /// >  If the TaskType parameter is set to HTTP, this parameter takes effect.
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// The parameters of the alert callback. The parameters are in the JSON format.
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

            /// <summary>
            /// The callback URL.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("AlertConfigTargetList")]
        [Validation(Required=false)]
        public List<CreateHostAvailabilityRequestAlertConfigTargetList> AlertConfigTargetList { get; set; }
        public class CreateHostAvailabilityRequestAlertConfigTargetList : TeaModel {
            /// <summary>
            /// The mute period during which new alerts are not sent even if the trigger conditions are met. Unit: seconds. Default value: 86400. The default value indicates one day.
            /// </summary>
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            /// <summary>
            /// The end of the time period during which the alert rule is effective. Valid values: 0 to 23.
            /// 
            /// For example, if the `AlertConfig.StartTime` parameter is set to 0 and the `AlertConfig.EndTime` parameter is set to 22, the alert rule is effective from 00:00:00 to 22:00:00.
            /// 
            /// >  Alert notifications are sent based on the specified threshold only if the alert rule is effective.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("JsonParams")]
            [Validation(Required=false)]
            public string JsonParams { get; set; }

            /// <summary>
            /// The monitoring type of the availability monitoring task. Valid values:
            /// 
            /// *   PING
            /// *   TELNET
            /// *   HTTP
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// The metric for which the alert feature is enabled. Valid values of N: 1 to 21. Valid values:
        /// 
        /// *   HttpStatus: HTTP status code
        /// *   HttpLatency: HTTP response time
        /// *   TelnetStatus: Telnet status code
        /// *   TelnetLatency: Telnet response time
        /// *   PingLostRate: Ping packet loss rate
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<string> InstanceList { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The comparison operator that is used in the alert rule. Valid values of N: 1 to 21. Valid values:
        /// 
        /// *   `>`
        /// *   `>=`
        /// *   `<`
        /// *   `<=`
        /// *   `=`
        /// </summary>
        [NameInMap("TaskScope")]
        [Validation(Required=false)]
        public string TaskScope { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **CreateHostAvailability**.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
