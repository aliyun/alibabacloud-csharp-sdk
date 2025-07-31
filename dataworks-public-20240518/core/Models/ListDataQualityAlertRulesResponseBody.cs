// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityAlertRulesResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityAlertRulesResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityAlertRulesResponseBodyPageInfo : TeaModel {
            [NameInMap("DataQualityAlertRules")]
            [Validation(Required=false)]
            public List<ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRules> DataQualityAlertRules { get; set; }
            public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>26433</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Notification")]
                [Validation(Required=false)]
                public ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotification Notification { get; set; }
                public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotification : TeaModel {
                    [NameInMap("Channels")]
                    [Validation(Required=false)]
                    public List<string> Channels { get; set; }

                    [NameInMap("Receivers")]
                    [Validation(Required=false)]
                    public List<ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotificationReceivers> Receivers { get; set; }
                    public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesNotificationReceivers : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{&quot;atAll&quot;:true}</para>
                        /// </summary>
                        [NameInMap("Extension")]
                        [Validation(Required=false)]
                        public string Extension { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>AliUid</para>
                        /// </summary>
                        [NameInMap("ReceiverType")]
                        [Validation(Required=false)]
                        public string ReceiverType { get; set; }

                        [NameInMap("ReceiverValues")]
                        [Validation(Required=false)]
                        public List<string> ReceiverValues { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>59094</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesTarget Target { get; set; }
                public class ListDataQualityAlertRulesResponseBodyPageInfoDataQualityAlertRulesTarget : TeaModel {
                    [NameInMap("Ids")]
                    [Validation(Required=false)]
                    public List<long?> Ids { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DataQualityScan</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>335</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
