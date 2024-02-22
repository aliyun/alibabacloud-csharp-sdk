// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogListResponseBody : TeaModel {
        /// <summary>
        /// The queried alert logs.
        /// </summary>
        [NameInMap("AlertLogList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogListResponseBodyAlertLogList> AlertLogList { get; set; }
        public class DescribeAlertLogListResponseBodyAlertLogList : TeaModel {
            /// <summary>
            /// The timestamp that was generated when the alert was triggered.
            /// 
            /// Unit: milliseconds.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public string AlertTime { get; set; }

            /// <summary>
            /// The details of the blacklist policy.
            /// </summary>
            [NameInMap("BlackListDetail")]
            [Validation(Required=false)]
            public string BlackListDetail { get; set; }

            /// <summary>
            /// The name of the blacklist policy.
            /// </summary>
            [NameInMap("BlackListName")]
            [Validation(Required=false)]
            public string BlackListName { get; set; }

            /// <summary>
            /// The ID of the blacklist policy.
            /// </summary>
            [NameInMap("BlackListUUID")]
            [Validation(Required=false)]
            public string BlackListUUID { get; set; }

            [NameInMap("ContactALIIWWList")]
            [Validation(Required=false)]
            public List<string> ContactALIIWWList { get; set; }

            [NameInMap("ContactDingList")]
            [Validation(Required=false)]
            public List<string> ContactDingList { get; set; }

            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            [NameInMap("ContactMailList")]
            [Validation(Required=false)]
            public List<string> ContactMailList { get; set; }

            [NameInMap("ContactOnCallList")]
            [Validation(Required=false)]
            public List<string> ContactOnCallList { get; set; }

            [NameInMap("ContactSMSList")]
            [Validation(Required=false)]
            public List<string> ContactSMSList { get; set; }

            /// <summary>
            /// The dimensions of the resource that triggered alerts.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListDimensions> Dimensions { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListDimensions : TeaModel {
                /// <summary>
                /// The key of the dimension.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the dimension.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("DingdingWebhookList")]
            [Validation(Required=false)]
            public List<string> DingdingWebhookList { get; set; }

            /// <summary>
            /// The alert rule based on which the alert is triggered.
            /// </summary>
            [NameInMap("Escalation")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListEscalation Escalation { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListEscalation : TeaModel {
                /// <summary>
                /// The description of the alert rule.
                /// 
                /// >  The content of the alert rule. This parameter indicates the conditions that trigger an alert.
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// The alert level and the methods that are used to send alert notifications. Valid values:
                /// 
                /// *   P4: Alert notifications are sent by using emails and DingTalk chatbots.
                /// *   OK: No alert is generated.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            /// <summary>
            /// The event name.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The extended fields.
            /// </summary>
            [NameInMap("ExtendedInfo")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListExtendedInfo> ExtendedInfo { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListExtendedInfo : TeaModel {
                /// <summary>
                /// The name of the extended field.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the extended field.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the application group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The resource ID.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The resource name.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The alert level and the methods that are used to send alert notifications. Valid values:
            /// 
            /// *   P4: Alert notifications are sent by using emails and DingTalk chatbots.
            /// *   OK: No alert is generated.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// Indicates whether the alert level was changed. Valid values:
            /// 
            /// *   `P4->OK`: The alert level was changed from P4 to OK.
            /// *   `P4->P4`: The alert level was still P4.
            /// </summary>
            [NameInMap("LevelChange")]
            [Validation(Required=false)]
            public string LevelChange { get; set; }

            /// <summary>
            /// The log ID.
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public string LogId { get; set; }

            /// <summary>
            /// The alert information in a JSON string.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The metric name.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The namespace of the cloud service.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The identifier of the cloud service. Valid values:
            /// 
            /// *   If the cloud service is provided by Alibaba Cloud, the abbreviation of the service name is returned. Example: ECS.
            /// *   If the cloud service is not provided by Alibaba Cloud, a value in the `acs_Service keyword` format is returned. Example: acs_networkmonitor.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The ID of the alert rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The name of the alert rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The details about the sending results of alert notifications.
            /// </summary>
            [NameInMap("SendDetail")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListSendDetail SendDetail { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendDetail : TeaModel {
                /// <summary>
                /// The list of sending results that are categorized by notification method.
                /// </summary>
                [NameInMap("ChannelResultList")]
                [Validation(Required=false)]
                public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList> ChannelResultList { get; set; }
                public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList : TeaModel {
                    /// <summary>
                    /// The method that is used to send alert notifications. Valid values:
                    /// 
                    /// *   MAIL: email
                    /// *   SMS: text message
                    /// *   WEBHOOK: alert callback
                    /// *   SLS: Simple Log Service
                    /// *   ONCALL: phone call
                    /// *   FC: Function Compute
                    /// *   MNS: Message Service queue
                    /// </summary>
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// The sending results of alert notifications.
                    /// </summary>
                    [NameInMap("ResultList")]
                    [Validation(Required=false)]
                    public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList> ResultList { get; set; }
                    public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList : TeaModel {
                        /// <summary>
                        /// The HTTP status code.
                        /// 
                        /// *   If the value of the `Channel` parameter is `WEBHOOK`, the status code is 200 or 500.
                        /// *   If the value of the `Channel` parameter is `MAIL`, `SMS`, `SLS`, `ONCALL`, `FC`, or `MNS`, this parameter is empty or not returned.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The details of the returned results.
                        /// </summary>
                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                        /// <summary>
                        /// The request ID returned when CloudMonitor calls another cloud service.
                        /// </summary>
                        [NameInMap("RequestId")]
                        [Validation(Required=false)]
                        public string RequestId { get; set; }

                        /// <summary>
                        /// Indicates whether the request was successful. Valid values:
                        /// 
                        /// *   true
                        /// *   false
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        [NameInMap("notifyTargetList")]
                        [Validation(Required=false)]
                        public List<string> NotifyTargetList { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the alert notifications are sent.
                /// 
                /// *   If the alert notifications are sent, the value "success" is returned.
                /// *   If the configuration is invalid, no alert notification is sent and an error code is returned.
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

            }

            /// <summary>
            /// The sending results of alert notifications.
            /// </summary>
            [NameInMap("SendResultList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListSendResultList> SendResultList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendResultList : TeaModel {
                /// <summary>
                /// The category of the alert notification method. Valid values:
                /// 
                /// *   MAIL: email
                /// *   ALIIM: TradeManager
                /// *   SMS: text message
                /// *   CALL: phone call
                /// *   DING: DingTalk chatbot
                /// *   Merged: alert merging
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The notification object corresponding to the alert notification method.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

            /// <summary>
            /// The status of the alert. Valid values:
            /// 
            /// *   0: The alert is triggered or cleared.
            /// *   1: The alert is ineffective.
            /// *   2: The alert is muted.
            /// *   3: The host is restarting.
            /// *   4: No alert notification is sent.
            /// 
            /// If the value of the SendStatus parameter is 0, the value P4 of the Level parameter indicates a triggered alert and the value OK indicates a cleared alert.
            /// </summary>
            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public string SendStatus { get; set; }

            /// <summary>
            /// The callback URLs.
            /// </summary>
            [NameInMap("WebhookList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListWebhookList> WebhookList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListWebhookList : TeaModel {
                /// <summary>
                /// The status code of the alert callback.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The message returned for the alert callback.
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The callback URL.
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
