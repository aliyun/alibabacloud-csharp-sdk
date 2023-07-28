// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogListResponseBody : TeaModel {
        /// <summary>
        /// The status code of the alert callback.
        /// </summary>
        [NameInMap("AlertLogList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogListResponseBodyAlertLogList> AlertLogList { get; set; }
        public class DescribeAlertLogListResponseBodyAlertLogList : TeaModel {
            /// <summary>
            /// The details of the blacklist policy.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public string AlertTime { get; set; }

            /// <summary>
            /// The dimension based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL. Valid values:
            /// 
            /// *   `product`: aggregates data by cloud service.
            /// *   `level`: aggregates data by alert level.
            /// *   `groupId`: aggregates data by application group.
            /// *   `contactGroup`: aggregates data by alert contact group.
            /// *   `product,metricName`: aggregates data both by cloud service and by metric.
            /// </summary>
            [NameInMap("BlackListDetail")]
            [Validation(Required=false)]
            public string BlackListDetail { get; set; }

            /// <summary>
            /// The number of entries to return on each page. Default value: 10.
            /// </summary>
            [NameInMap("BlackListName")]
            [Validation(Required=false)]
            public string BlackListName { get; set; }

            /// <summary>
            /// The category of the alert notification method. Valid values:
            /// 
            /// *   Mail: email
            /// *   ALIIM: TradeManager
            /// *   SMS: text message
            /// *   CALL: phone call
            /// *   DING: DingTalk chatbot
            /// *   Merged: alert merging
            /// </summary>
            [NameInMap("BlackListUUID")]
            [Validation(Required=false)]
            public string BlackListUUID { get; set; }

            /// <summary>
            /// The name of the extended field.
            /// </summary>
            [NameInMap("ContactALIIWWList")]
            [Validation(Required=false)]
            public List<string> ContactALIIWWList { get; set; }

            /// <summary>
            /// The abbreviation of the Alibaba Cloud service name.
            /// </summary>
            [NameInMap("ContactDingList")]
            [Validation(Required=false)]
            public List<string> ContactDingList { get; set; }

            /// <summary>
            /// The alert notification method.
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            /// <summary>
            /// The callback URL.
            /// </summary>
            [NameInMap("ContactMailList")]
            [Validation(Required=false)]
            public List<string> ContactMailList { get; set; }

            /// <summary>
            /// The name of the resource.
            /// </summary>
            [NameInMap("ContactOnCallList")]
            [Validation(Required=false)]
            public List<string> ContactOnCallList { get; set; }

            /// <summary>
            /// The statistical period of alert logs. Unit: minutes.
            /// </summary>
            [NameInMap("ContactSMSList")]
            [Validation(Required=false)]
            public List<string> ContactSMSList { get; set; }

            /// <summary>
            /// The status of the alert. Valid values:
            /// 
            /// *   0: The alert is triggered or cleared.
            /// *   1: The alert is ineffective.
            /// *   2: The alert is muted and not triggered in a specified period.
            /// *   3: The host is restarting.
            /// *   4: No alert notification is sent.
            /// 
            /// If the value of the SendStatus parameter is 0, the value P4 of the Level parameter indicates a triggered alert and the value OK indicates a cleared alert.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListDimensions> Dimensions { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListDimensions : TeaModel {
                /// <summary>
                /// The list of sending results that are categorized by notification method.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The ID of the blacklist policy.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the application group.
            /// </summary>
            [NameInMap("DingdingWebhookList")]
            [Validation(Required=false)]
            public List<string> DingdingWebhookList { get; set; }

            [NameInMap("Escalation")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListEscalation Escalation { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListEscalation : TeaModel {
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            /// <summary>
            /// The number of the page to return. Default value: 1.
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// The sending results of alert notifications.
            /// </summary>
            [NameInMap("ExtendedInfo")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListExtendedInfo> ExtendedInfo { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListExtendedInfo : TeaModel {
                /// <summary>
                /// The name of the event.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The method that is used to send alert notifications. Valid values:
                /// 
                /// *   MAIL: email
                /// *   SMS: text message
                /// *   WEBHOOK: alert callback
                /// *   SLS: Log Service
                /// *   ONCALL: phone call
                /// *   FC: Function Compute
                /// *   MNS: Message Service queue
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The ID of the alert rule.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The alert contact group.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The list of callback URLs.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The HTTP status code.
            /// 
            /// *   If the value of the `Channel` parameter is `WEBHOOK`, the status code is 200 or 500.
            /// *   If the value of the `Channel` parameter is `MAIL`, `SMS`, `SLS`, `ONCALL`, `FC`, or `MNS`, this parameter is empty or not returned.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The key of the dimension.
            /// </summary>
            [NameInMap("LevelChange")]
            [Validation(Required=false)]
            public string LevelChange { get; set; }

            [NameInMap("LogId")]
            [Validation(Required=false)]
            public string LogId { get; set; }

            /// <summary>
            /// The name of the alert rule.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The name of the metric.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The dimensions of the resource that triggered alerts.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// Indicates whether the alert notifications are sent.
            /// 
            /// *   If the alert notifications are sent, the value "success" is returned.
            /// *   If the configuration is invalid, no alert notification is sent and an error code is returned.
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// The phone numbers of alert contacts that can receive alert phone calls.
            /// 
            /// >  This parameter can be returned only on the China site (aliyun.com).
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The ID of the resource.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The namespace of the cloud service.
            /// 
            /// >  For more information about the namespaces of different cloud services, see [Appendix 1: Metrics](~~163515~~).
            /// </summary>
            [NameInMap("SendDetail")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListSendDetail SendDetail { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendDetail : TeaModel {
                /// <summary>
                /// The namespace of the cloud service.
                /// </summary>
                [NameInMap("ChannelResultList")]
                [Validation(Required=false)]
                public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList> ChannelResultList { get; set; }
                public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList : TeaModel {
                    /// <summary>
                    /// The queried resources.
                    /// </summary>
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// The details about the sending results of alert notifications.
                    /// </summary>
                    [NameInMap("ResultList")]
                    [Validation(Required=false)]
                    public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList> ResultList { get; set; }
                    public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList : TeaModel {
                        /// <summary>
                        /// The severity level and notification methods of the alert. Valid values:
                        /// 
                        /// *   P4: Alert notifications are sent by using emails and DingTalk chatbots.
                        /// 
                        /// <!---->
                        /// 
                        /// *   OK: No alert is generated.
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// The name of the application group.
                        /// </summary>
                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                        /// <summary>
                        /// The ID of the alert rule.
                        /// 
                        /// For information about how to obtain the ID of an alert rule, see [DescribeMetricRuleList](~~114941~~).
                        /// </summary>
                        [NameInMap("RequestId")]
                        [Validation(Required=false)]
                        public string RequestId { get; set; }

                        /// <summary>
                        /// The page number of the returned page.
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        /// <summary>
                        /// The ID of the request.
                        /// </summary>
                        [NameInMap("notifyTargetList")]
                        [Validation(Required=false)]
                        public List<string> NotifyTargetList { get; set; }

                    }

                }

                /// <summary>
                /// The alert logs.
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

            }

            /// <summary>
            /// The details of the returned results.
            /// </summary>
            [NameInMap("SendResultList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListSendResultList> SendResultList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendResultList : TeaModel {
                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

            /// <summary>
            /// The value of the dimension.
            /// </summary>
            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public string SendStatus { get; set; }

            /// <summary>
            /// The value of the extended field.
            /// </summary>
            [NameInMap("WebhookList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListWebhookList> WebhookList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListWebhookList : TeaModel {
                /// <summary>
                /// The search keyword that is used to query alert logs.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The error message.
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The request ID returned when CloudMonitor calls another cloud service.
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// The extended fields.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The end timestamp of the alert logs to be queried. Unit: milliseconds.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The DingTalk chatbots of alert contacts.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// >  For more information about the metrics of different cloud services, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timestamp that was generated when the alert was triggered. Unit: milliseconds.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
