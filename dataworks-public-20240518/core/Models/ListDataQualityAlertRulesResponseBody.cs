// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityAlertRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>Alert rule configurations.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityAlertRulesResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityAlertRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The list of alert rule configurations.</para>
            /// </summary>
            [NameInMap("DataQualityAlertRules")]
            [Validation(Required=false)]
            public List<ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRules> DataQualityAlertRules { get; set; }
            public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRules : TeaModel {
                /// <summary>
                /// <para>The alert conditions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <para>The ID of the data quality monitor alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26433</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Alert notification configurations.</para>
                /// </summary>
                [NameInMap("Notification")]
                [Validation(Required=false)]
                public ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotification Notification { get; set; }
                public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotification : TeaModel {
                    /// <summary>
                    /// <para>In Channels, you can set both Email and Sms at the same time. In other cases, only one channel can be set.</para>
                    /// </summary>
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                    /// <summary>
                    /// <para>The alert recipients.</para>
                    /// </summary>
                    [NameInMap("Receivers")]
                    [Validation(Required=false)]
                    public List<ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotificationReceivers> Receivers { get; set; }
                    public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotificationReceivers : TeaModel {
                        /// <summary>
                        /// <para>Additional configurations required for the alert recipients. When ReceiverType is DingdingUrl, you can set <c>{&quot;atAll&quot;:true}</c> to mention all members.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;atAll&quot;:true}</para>
                        /// </summary>
                        [NameInMap("Extension")]
                        [Validation(Required=false)]
                        public string Extension { get; set; }

                        /// <summary>
                        /// <para>The type of alert recipients.</para>
                        /// <list type="bullet">
                        /// <item><description>ShiftSchedule</description></item>
                        /// <item><description>WebhookUrl</description></item>
                        /// <item><description>FeishuUrl</description></item>
                        /// <item><description>TaskOwner</description></item>
                        /// <item><description>WeixinUrl</description></item>
                        /// <item><description>DingdingUrl</description></item>
                        /// <item><description>DataQualityScanOwner</description></item>
                        /// <item><description>AliUid</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AliUid</para>
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        /// <summary>
                        /// <para>The value of alert recipients.</para>
                        /// </summary>
                        [NameInMap("ReceiverValues")]
                        [Validation(Required=false)]
                        public List<string> ReceiverValues { get; set; }

                    }

                }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>59094</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>Monitored targets of the data quality alert rule.</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesTarget Target { get; set; }
                public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesTarget : TeaModel {
                    /// <summary>
                    /// <para>The list of monitored target IDs</para>
                    /// </summary>
                    [NameInMap("Ids")]
                    [Validation(Required=false)]
                    public List<long?> Ids { get; set; }

                    /// <summary>
                    /// <para>The type of the monitored target. Only DataQualityScan is supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DataQualityScan</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>335</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
