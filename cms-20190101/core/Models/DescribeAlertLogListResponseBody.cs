// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeAlertLogListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of alert history entries.</para>
        /// </summary>
        [NameInMap("AlertLogList")]
        [Validation(Required=false)]
        public List<DescribeAlertLogListResponseBodyAlertLogList> AlertLogList { get; set; }
        public class DescribeAlertLogListResponseBodyAlertLogList : TeaModel {
            /// <summary>
            /// <para>The timestamp when the alert was triggered.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610043776621</para>
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public string AlertTime { get; set; }

            /// <summary>
            /// <para>The details of the matched alert blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:12****,&quot;metricProject&quot;:&quot;acs_ecs_dashboard&quot;,&quot;userId&quot;:173651113438****,&quot;uuid&quot;:&quot;8410dbbd-7d30-41c5-94cb-<b><b>&quot;,&quot;name&quot;:&quot;alert-</b></b>&quot;,&quot;productCategory&quot;:&quot;ecs&quot;,&quot;instances&quot;:[{&quot;instanceId&quot;:&quot;i-m5e1qg6uo38rztr4****&quot;}],&quot;metrics&quot;:null,&quot;scopeType&quot;:&quot;USER&quot;,&quot;scopeValue&quot;:&quot;&quot;,&quot;startTime&quot;:&quot;0001-01-01T00:00:00Z&quot;,&quot;endTime&quot;:&quot;9999-12-31T23:59:59.999999999+08:00&quot;,&quot;effectiveTime&quot;:null,&quot;isEnable&quot;:true,&quot;status&quot;:1,&quot;gmtCreate&quot;:&quot;2021-11-02T16:35:59+08:00&quot;,&quot;gmtModified&quot;:&quot;2021-11-02T16:35:59+08:00&quot;,&quot;loadTime&quot;:&quot;2021-11-02T16:36:15.213072177+08:00&quot;}</para>
            /// </summary>
            [NameInMap("BlackListDetail")]
            [Validation(Required=false)]
            public string BlackListDetail { get; set; }

            /// <summary>
            /// <para>The name of the matched alert blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Black_Test</para>
            /// </summary>
            [NameInMap("BlackListName")]
            [Validation(Required=false)]
            public string BlackListName { get; set; }

            /// <summary>
            /// <para>The UUID of the matched alert blacklist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8410dbbd-7d30-41c5-94cb-****</para>
            /// </summary>
            [NameInMap("BlackListUUID")]
            [Validation(Required=false)]
            public string BlackListUUID { get; set; }

            /// <summary>
            /// <para>The list of Wangwang IDs of the alert contact.</para>
            /// </summary>
            [NameInMap("ContactALIIWWList")]
            [Validation(Required=false)]
            public List<string> ContactALIIWWList { get; set; }

            /// <summary>
            /// <para>The list of DingTalk accounts of the alert contact.</para>
            /// </summary>
            [NameInMap("ContactDingList")]
            [Validation(Required=false)]
            public List<string> ContactDingList { get; set; }

            /// <summary>
            /// <para>The list of alert contact groups.</para>
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            /// <summary>
            /// <para>The list of email addresses of the alert contact.</para>
            /// </summary>
            [NameInMap("ContactMailList")]
            [Validation(Required=false)]
            public List<string> ContactMailList { get; set; }

            /// <summary>
            /// <para>The list of phone numbers of the alert contact.</para>
            /// </summary>
            [NameInMap("ContactOnCallList")]
            [Validation(Required=false)]
            public List<string> ContactOnCallList { get; set; }

            /// <summary>
            /// <para>The list of phone numbers that receive text messages of the alert contact.</para>
            /// </summary>
            [NameInMap("ContactSMSList")]
            [Validation(Required=false)]
            public List<string> ContactSMSList { get; set; }

            /// <summary>
            /// <para>The dimensions of the resource for which the alert is triggered.</para>
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListDimensions> Dimensions { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListDimensions : TeaModel {
                /// <summary>
                /// <para>The key of the alerting resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceId</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the alerting resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-m5e1qg6uo38rztr4****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The list of webhook URLs of DingTalk chatbots for the alert contact.</para>
            /// </summary>
            [NameInMap("DingdingWebhookList")]
            [Validation(Required=false)]
            public List<string> DingdingWebhookList { get; set; }

            /// <summary>
            /// <para>The rule that triggers the alert.</para>
            /// </summary>
            [NameInMap("Escalation")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListEscalation Escalation { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListEscalation : TeaModel {
                /// <summary>
                /// <para>The description of the rule that triggers the alert.</para>
                /// <remarks>
                /// <para>The body of the alert rule. An alert rule is triggered when the monitoring data meets the alert conditions.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>$Average&lt;90</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The alert level and notification methods. Valid values:</para>
                /// <para>&lt;props=&quot;china&quot;&gt;- P2: phone calls, text messages, emails, and DingTalk chatbots.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;- P3: text messages, emails, and DingTalk chatbots.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;- P4: emails and DingTalk chatbots.</para>
                /// <para>&lt;props=&quot;china&quot;&gt;- OK: no alerts.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;- P4: emails and DingTalk chatbots.</para>
                /// <para>&lt;props=&quot;intl&quot;&gt;- OK: no alerts.</para>
                /// <para>&lt;props=&quot;partner&quot;&gt;- P4: emails and DingTalk chatbots.</para>
                /// <para>&lt;props=&quot;partner&quot;&gt;- OK: no alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>P4</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The number of times that the alert is retried.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Times")]
                [Validation(Required=false)]
                public int? Times { get; set; }

            }

            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IOHang</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The extended information of the alert.</para>
            /// </summary>
            [NameInMap("ExtendedInfo")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListExtendedInfo> ExtendedInfo { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListExtendedInfo : TeaModel {
                /// <summary>
                /// <para>The name of the extension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userId</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the extension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100931896542****</para>
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
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-m5e1qg6uo38rztr4****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>portalHost</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The alert level and notification methods. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- P2: phone calls, text messages, emails, and DingTalk chatbots.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- P3: text messages, emails, and DingTalk chatbots.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- P4: emails and DingTalk chatbots.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;- OK: no alerts.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;- P4: emails and DingTalk chatbots.</para>
            /// <para>&lt;props=&quot;intl&quot;&gt;- OK: no alerts.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;- P4: emails and DingTalk chatbots.</para>
            /// <para>&lt;props=&quot;partner&quot;&gt;- OK: no alerts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P4</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The change of the alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>P4-&gt;OK</c>: The alert level changes from P4 to OK, which indicates that the alert is cleared.</description></item>
            /// <item><description><c>P4-&gt;P4</c>: indicates a P4-level alert.</description></item>
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
            /// <para>7510****::e8a472a0-46ae-4ac0-84b1-e46be368****</para>
            /// </summary>
            [NameInMap("LogId")]
            [Validation(Required=false)]
            public string LogId { get; set; }

            /// <summary>
            /// <para>The alert-related information, which is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;alertName&quot;:&quot;e47aa0ac-4076-44db-a47d-d1083968****_Availability&quot;}</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The name of the metric.</para>
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
            /// <para>The cloud service identifier. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>For an Alibaba Cloud service, the value is the abbreviation of the cloud service name. Example: ECS.</para>
            /// </description></item>
            /// <item><description><para>For a non-Alibaba Cloud service, the value is in the format of <c>acs_Product keyword</c>. Example: acs_networkmonitor.</para>
            /// </description></item>
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
            /// 
            /// <b>Example:</b>
            /// <para>CPU utilization</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The details of the alert pushing result.</para>
            /// </summary>
            [NameInMap("SendDetail")]
            [Validation(Required=false)]
            public DescribeAlertLogListResponseBodyAlertLogListSendDetail SendDetail { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendDetail : TeaModel {
                /// <summary>
                /// <para>The list of alert pushing results by alert channel.</para>
                /// </summary>
                [NameInMap("ChannelResultList")]
                [Validation(Required=false)]
                public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList> ChannelResultList { get; set; }
                public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultList : TeaModel {
                    /// <summary>
                    /// <para>The alert pushing channel. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para>MAIL: email.</para>
                    /// </description></item>
                    /// <item><description><para>SMS: text message.</para>
                    /// </description></item>
                    /// <item><description><para>WEBHOOK: alert callback.</para>
                    /// </description></item>
                    /// <item><description><para>SLS: Log Service.</para>
                    /// </description></item>
                    /// <item><description><para>ONCALL: phone call.</para>
                    /// </description></item>
                    /// <item><description><para>FC: Function Compute.</para>
                    /// </description></item>
                    /// <item><description><para>MNS: Message Service (MNS).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAIL</para>
                    /// </summary>
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// <para>The list of alert information results that CloudMonitor sends to the alert channel.</para>
                    /// </summary>
                    [NameInMap("ResultList")]
                    [Validation(Required=false)]
                    public List<DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList> ResultList { get; set; }
                    public class DescribeAlertLogListResponseBodyAlertLogListSendDetailChannelResultListResultList : TeaModel {
                        /// <summary>
                        /// <para>The status code.</para>
                        /// <list type="bullet">
                        /// <item><description><para>If <c>Channel</c> is set to <c>WEBHOOK</c>, the status code is 200 or 500.</para>
                        /// </description></item>
                        /// <item><description><para>If <c>Channel</c> is set to <c>MAIL</c>, <c>SMS</c>, <c>SLS</c>, <c>ONCALL</c>, <c>FC</c>, or <c>MNS</c>, this parameter is unavailable or empty.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        /// <summary>
                        /// <para>The details of the returned result.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{ }</para>
                        /// </summary>
                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                        /// <summary>
                        /// <para>The request ID returned by calling another cloud service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0BDAF8A8-04DC-5F0C-90E4-724D42C4****</para>
                        /// </summary>
                        [NameInMap("RequestId")]
                        [Validation(Required=false)]
                        public string RequestId { get; set; }

                        /// <summary>
                        /// <para>The result of calling the target.</para>
                        /// <list type="bullet">
                        /// <item><description><para>true: The call was successful.</para>
                        /// </description></item>
                        /// <item><description><para>false: The call failed.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public bool? Success { get; set; }

                        /// <summary>
                        /// <para>The list of channel notifications.</para>
                        /// </summary>
                        [NameInMap("notifyTargetList")]
                        [Validation(Required=false)]
                        public List<string> NotifyTargetList { get; set; }

                    }

                }

                /// <summary>
                /// <para>The pushing status of the alert information.</para>
                /// <list type="bullet">
                /// <item><description><para>success: The alert was pushed.</para>
                /// </description></item>
                /// <item><description><para>error code: If a configuration error occurs and the pushing list is empty, an error code is displayed.</para>
                /// </description></item>
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
            /// <para>The list of alert sending results.</para>
            /// </summary>
            [NameInMap("SendResultList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListSendResultList> SendResultList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListSendResultList : TeaModel {
                /// <summary>
                /// <para>The channel that sends the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MAIL: email.</description></item>
                /// <item><description>ALIIM: Wangwang.</description></item>
                /// <item><description>SMS: text message.</description></item>
                /// <item><description>CALL: phone call.</description></item>
                /// <item><description>DING: DingTalk chatbot.</description></item>
                /// <item><description>Merged: alert combination.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MAIL</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The notification target that corresponds to the alert channel.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<string> Value { get; set; }

            }

            /// <summary>
            /// <para>The alert status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: An alert is triggered or cleared.</description></item>
            /// <item><description>1: The current time is not within the effective period of the alert.</description></item>
            /// <item><description>2: The current time is within the channel silence period.</description></item>
            /// <item><description>3: The host is being restarted.</description></item>
            /// <item><description>4: No alerts are sent.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;When the alert status is 0, an alert is triggered if Level is set to P2, P3, or P4; the alert is cleared if Level is set to OK.
            /// &lt;props=&quot;intl&quot;&gt;When the alert status is 0, an alert is triggered if Level is set to P4; the alert is cleared if Level is set to OK.
            /// &lt;props=&quot;partner&quot;&gt;When the alert status is 0, an alert is triggered if Level is set to P4; the alert is cleared if Level is set to OK.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SendStatus")]
            [Validation(Required=false)]
            public string SendStatus { get; set; }

            /// <summary>
            /// <para>The list of URLs that are called back when the alert is triggered.</para>
            /// </summary>
            [NameInMap("WebhookList")]
            [Validation(Required=false)]
            public List<DescribeAlertLogListResponseBodyAlertLogListWebhookList> WebhookList { get; set; }
            public class DescribeAlertLogListResponseBodyAlertLogListWebhookList : TeaModel {
                /// <summary>
                /// <para>The status code returned for the alert callback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The information returned for the alert callback.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The URL that is called back when the alert is triggered.</para>
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
        /// <para>The status code 200 indicates that the call was successful.</para>
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
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The call was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The call failed.</para>
        /// </description></item>
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
