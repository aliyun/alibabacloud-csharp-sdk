// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateTrafficControlTargetRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-04-25</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event for the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>click</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The item condition in array format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        /// <summary>
        /// <para>The item condition in expression format.</para>
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
        /// <para>The name of the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable new product regulation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NewProductRegulation")]
        [Validation(Required=false)]
        public bool? NewProductRegulation { get; set; }

        /// <summary>
        /// <para>The recall strategy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recall-1</para>
        /// </summary>
        [NameInMap("RecallName")]
        [Validation(Required=false)]
        public string RecallName { get; set; }

        /// <summary>
        /// <para>The start time of the traffic control target.</para>
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
        /// <para>The status of the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Opened</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tolerance value for the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ToleranceValue")]
        [Validation(Required=false)]
        public long? ToleranceValue { get; set; }

        /// <summary>
        /// <para>The traffic control task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

        /// <summary>
        /// <para>The value of the traffic control target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
