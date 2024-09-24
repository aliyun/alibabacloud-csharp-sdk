// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogListResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried alert logs.</para>
        /// </summary>
        [NameInMap("AlertLogList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogListResponseBodyAlertLogList> AlertLogList { get; set; }
        public class DescribeAlertLogListResponseBodyAlertLogList : TeaModel {
            /// <summary>
            /// <para>The timestamp that was generated when the alert was triggered.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610043776621</para>
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public string AlertTime { get; set; }

            /// <summary>
            /// <para>The details of the blacklist policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BlackListDetail</para>
            /// </summary>
            [NameInMap("BlackListDetail")]
            [Validation(Required=false)]
            public string BlackListDetail { get; set; }

            /// <summary>
            /// <para>The name of the blacklist policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:123,&quot;metricProject&quot;:&quot;acs_ecs_dashboard&quot;,&quot;userId&quot;:1736511134389110,&quot;uuid&quot;:&quot;8410dbbd-7d30-41c5-94cb-<em><b>&quot;,&quot;name&quot;:&quot;alert-</b></em>&quot;,&quot;productCategory&quot;:&quot;ecs&quot;,&quot;instances&quot;:[{&quot;instanceId&quot;:&quot;host-***&quot;}],&quot;metrics&quot;:null,&quot;scopeType&quot;:&quot;USER&quot;,&quot;scopeValue&quot;:&quot;&quot;,&quot;startTime&quot;:&quot;0001-01-01T00:00:00Z&quot;,&quot;endTime&quot;:&quot;9999-12-31T23:59:59.999999999+08:00&quot;,&quot;effectiveTime&quot;:null,&quot;isEnable&quot;:true,&quot;status&quot;:1,&quot;gmtCreate&quot;:&quot;2021-11-02T16:35:59+08:00&quot;,&quot;gmtModified&quot;:&quot;2021-11-02T16:35:59+08:00&quot;,&quot;loadTime&quot;:&quot;2021-11-02T16:36:15.213072177+08:00&quot;}</para>
            /// </summary>
            [NameInMap("BlackListName")]
            [Validation(Required=false)]
            public string BlackListName { get; set; }

            /// <summary>
            /// <para>The ID of the blacklist policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8410dbbd-7d30-41c5-94cb-*****</para>
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
            /// <para>The dimensions of the resource that triggered alerts.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListDimensions> Dimensions { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListDimensions : TeaModel {
                /// <summary>
                /// <para>The key of the dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-m5e1qg6uo38rztr4****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("DingdingWebhookList")]
            [Validation(Required=false)]
            public List<string> DingdingWebhookList { get; set; }

            /// <summary>
            /// <para>The alert rule based on which the alert is triggered.</para>
            /// </summary>
            [NameInMap("Escalation")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListEscalation Escalation { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListEscalation : TeaModel {
                /// <summary>
                /// <para>The description of the alert rule.</para>
                /// <remarks>
                /// <para> The content of the alert rule. This parameter indicates the conditions that trigger an alert.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>$Average&lt;90</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The alert level and the methods that are used to send alert notifications. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>P4: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
                /// <item><description>OK: No alert is generated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>P4</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            /// <summary>
            /// <para>The event name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IOHang</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The extended fields.</para>
            /// </summary>
            [NameInMap("ExtendedInfo")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListExtendedInfo> ExtendedInfo { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListExtendedInfo : TeaModel {
                /// <summary>
                /// <para>The name of the extended field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userId</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the extended field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120886317861****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7301****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_Instances</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-m5e1qg6uo38rztr4****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>portalHost</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The alert level and the methods that are used to send alert notifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>P4: Alert notifications are sent by using emails and DingTalk chatbots.</description></item>
            /// <item><description>OK: No alert is generated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>P4</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert level was changed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>P4-&gt;OK</c>: The alert level was changed from P4 to OK.</description></item>
            /// <item><description><c>P4-&gt;P4</c>: The alert level was still P4.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>P4-&gt;OK</para>
            /// </summary>
            [NameInMap("LevelChange")]
            [Validation(Required=false)]
            public string LevelChange { get; set; }

            /// <summary>
            /// <para>The log ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7818361[1523]@1671593992[1]</para>
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public string LogId { get; set; }

            /// <summary>
            /// <para>The alert information in a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;alertName&quot;:&quot;e47aa0ac-4076-44db-a47d-d1083968****_Availability&quot;}</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpu_total</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The namespace of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The identifier of the cloud service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If the cloud service is provided by Alibaba Cloud, the abbreviation of the service name is returned. Example: ECS.</description></item>
            /// <item><description>If the cloud service is not provided by Alibaba Cloud, a value in the <c>acs_Service keyword</c> format is returned. Example: acs_networkmonitor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            /// <summary>
            /// <para>The ID of the alert rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d582b9e9-b1c1-4f17-9279-0fe7333a****_ResponseTime</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the alert rule.</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The details about the sending results of alert notifications.</para>
            /// </summary>
            [NameInMap("SendDetail")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListSendDetail SendDetail { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendDetail : TeaModel {
                /// <summary>
                /// <para>The list of sending results that are categorized by notification method.</para>
                /// </summary>
                [NameInMap("ChannelResultList")]
                [Validation(Required=false)]
                public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList> ChannelResultList { get; set; }
                public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList : TeaModel {
                    /// <summary>
                    /// <para>The method that is used to send alert notifications. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>MAIL: email</description></item>
                    /// <item><description>SMS: text message</description></item>
                    /// <item><description>WEBHOOK: alert callback</description></item>
                    /// <item><description>SLS: Simple Log Service</description></item>
                    /// <item><description>ONCALL: phone call</description></item>
                    /// <item><description>FC: Function Compute</description></item>
                    /// <item><description>MNS: Message Service queue</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAIL</para>
                    /// </summary>
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// <para>The sending results of alert notifications.</para>
                    /// </summary>
                    [NameInMap("ResultList")]
                    [Validation(Required=false)]
                    public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList> ResultList { get; set; }
                    public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList : TeaModel {
                        /// <summary>
                        /// <para>The HTTP status code.</para>
                        /// <list type="bullet">
                        /// <item><description>If the value of the <c>Channel</c> parameter is <c>WEBHOOK</c>, the status code is 200 or 500.</description></item>
                        /// <item><description>If the value of the <c>Channel</c> parameter is <c>MAIL</c>, <c>SMS</c>, <c>SLS</c>, <c>ONCALL</c>, <c>FC</c>, or <c>MNS</c>, this parameter is empty or not returned.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The details of the returned results.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ }</para>
                        /// </summary>
                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                        /// <summary>
                        /// <para>The request ID returned when CloudMonitor calls another cloud service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0BDAF8A8-04DC-5F0C-90E4-724D42C4****</para>
                        /// </summary>
                        [NameInMap("RequestId")]
                        [Validation(Required=false)]
                        public string RequestId { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the request was successful. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>true</description></item>
                        /// <item><description>false</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
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
                /// <para>Indicates whether the alert notifications are sent.</para>
                /// <list type="bullet">
                /// <item><description>If the alert notifications are sent, the value &quot;success&quot; is returned.</description></item>
                /// <item><description>If the configuration is invalid, no alert notification is sent and an error code is returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public string ResultCode { get; set; }

            }

            /// <summary>
            /// <para>The sending results of alert notifications.</para>
            /// </summary>
            [NameInMap("SendResultList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListSendResultList> SendResultList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendResultList : TeaModel {
                /// <summary>
                /// <para>The category of the alert notification method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MAIL: email</description></item>
                /// <item><description>ALIIM: TradeManager</description></item>
                /// <item><description>SMS: text message</description></item>
                /// <item><description>CALL: phone call</description></item>
                /// <item><description>DING: DingTalk chatbot</description></item>
                /// <item><description>Merged: alert merging</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Mail</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The notification object corresponding to the alert notification method.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

            /// <summary>
            /// <para>The status of the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The alert is triggered or cleared.</description></item>
            /// <item><description>1: The alert is ineffective.</description></item>
            /// <item><description>2: The alert is muted.</description></item>
            /// <item><description>3: The host is restarting.</description></item>
            /// <item><description>4: No alert notification is sent.</description></item>
            /// </list>
            /// <para>If the value of the SendStatus parameter is 0, the value P4 of the Level parameter indicates a triggered alert and the value OK indicates a cleared alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public string SendStatus { get; set; }

            /// <summary>
            /// <para>The callback URLs.</para>
            /// </summary>
            [NameInMap("WebhookList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListWebhookList> WebhookList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListWebhookList : TeaModel {
                /// <summary>
                /// <para>The status code of the alert callback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The message returned for the alert callback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.aliyun.com/webhook.html">https://www.aliyun.com/webhook.html</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1C4A3709-BF52-42EE-87B5-7435F0929585</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
