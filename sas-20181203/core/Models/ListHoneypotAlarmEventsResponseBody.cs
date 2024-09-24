// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAlarmEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert events.</para>
        /// </summary>
        [NameInMap("HoneypotAlarmEvents")]
        [Validation(Required=false)]
        public List<ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEvents> HoneypotAlarmEvents { get; set; }
        public class ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEvents : TeaModel {
            /// <summary>
            /// <para>The event ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>940272</para>
            /// </summary>
            [NameInMap("AlarmEventId")]
            [Validation(Required=false)]
            public long? AlarmEventId { get; set; }

            /// <summary>
            /// <para>The name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Attack Honeypot</para>
            /// </summary>
            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            /// <summary>
            /// <para>The type of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Initial Access</para>
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// <para>The unique identifier of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167e6fc0d931917d2059efcd1d00f6ab</para>
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// <para>The total number of times that the alert event was generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the time when the alert event was first detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1658193602000</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the time when the alert event was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1660610772000</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The risk information.</para>
            /// </summary>
            [NameInMap("MergeFieldList")]
            [Validation(Required=false)]
            public List<ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEventsMergeFieldList> MergeFieldList { get; set; }
            public class ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEventsMergeFieldList : TeaModel {
                /// <summary>
                /// <para>The extended value that corresponds to the field key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dest_ip_ext</para>
                /// </summary>
                [NameInMap("FieldExtInfo")]
                [Validation(Required=false)]
                public string FieldExtInfo { get; set; }

                /// <summary>
                /// <para>The key of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dest_ip_count</para>
                /// </summary>
                [NameInMap("FieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                /// <summary>
                /// <para>The type of the field. You can ignore this internal parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>level1_item3</para>
                /// </summary>
                [NameInMap("FieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// <para>The value that corresponds to the field key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            /// <summary>
            /// <para>The handling status of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: pending</description></item>
            /// <item><description><b>2</b>: ignored</description></item>
            /// <item><description><b>4</b>: confirmed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OperateStatus")]
            [Validation(Required=false)]
            public int? OperateStatus { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2</b>: low</description></item>
            /// <item><description><b>3</b>: medium</description></item>
            /// <item><description><b>4</b>: high</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAlarmEventsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAlarmEventsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>513C9554-55A4-5504-B7C4-6E17EB4FC7A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
