// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-25</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The traffic control target event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The creation time. Format: ISO 8601, where Z indicates the UTC time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-03T02:28:00.000Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The item conditions in array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        /// <summary>
        /// <para>The item conditions in expression format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status=1</para>
        /// </summary>
        [NameInMap("ItemConditionExpress")]
        [Validation(Required=false)]
        public string ItemConditionExpress { get; set; }

        /// <summary>
        /// <para>The item condition type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("ItemConditionType")]
        [Validation(Required=false)]
        public string ItemConditionType { get; set; }

        /// <summary>
        /// <para>The traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Indicates whether the regulation applies to new products.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NewProductRegulation")]
        [Validation(Required=false)]
        public bool? NewProductRegulation { get; set; }

        /// <summary>
        /// <para>The recall policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recall-1</para>
        /// </summary>
        [NameInMap("RecallName")]
        [Validation(Required=false)]
        public string RecallName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The target setting values.</para>
        /// </summary>
        [NameInMap("SplitParts")]
        [Validation(Required=false)]
        public GetTrafficControlTargetResponseBodySplitParts SplitParts { get; set; }
        public class GetTrafficControlTargetResponseBodySplitParts : TeaModel {
            /// <summary>
            /// <para>The target value split points.</para>
            /// </summary>
            [NameInMap("SetPoints")]
            [Validation(Required=false)]
            public List<long?> SetPoints { get; set; }

            /// <summary>
            /// <para>The target setting values.</para>
            /// </summary>
            [NameInMap("SetValues")]
            [Validation(Required=false)]
            public List<long?> SetValues { get; set; }

            /// <summary>
            /// <para>The time split points.</para>
            /// </summary>
            [NameInMap("TimePoints")]
            [Validation(Required=false)]
            public List<long?> TimePoints { get; set; }

        }

        /// <summary>
        /// <para>The start time. Format: YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-25</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The statistical period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("StatisPeriod")]
        [Validation(Required=false)]
        public string StatisPeriod { get; set; }

        /// <summary>
        /// <para>The status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Opened: Enabled.</description></item>
        /// <item><description>Closed: Disabled</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tolerance range of the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ToleranceValue")]
        [Validation(Required=false)]
        public long? ToleranceValue { get; set; }

        /// <summary>
        /// <para>The ID of the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TrafficControlTargetId")]
        [Validation(Required=false)]
        public string TrafficControlTargetId { get; set; }

        /// <summary>
        /// <para>The ID of the traffic control task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

        /// <summary>
        /// <para>The traffic control target value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
