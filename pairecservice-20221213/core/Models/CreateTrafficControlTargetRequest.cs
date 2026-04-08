// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateTrafficControlTargetRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-04-25</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>click</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;field&quot;:&quot;status&quot;,&quot;option&quot;:&quot;=&quot;,&quot;value&quot;:&quot;1&quot;}]</para>
        /// </summary>
        [NameInMap("ItemConditionArray")]
        [Validation(Required=false)]
        public string ItemConditionArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>status=1</para>
        /// </summary>
        [NameInMap("ItemConditionExpress")]
        [Validation(Required=false)]
        public string ItemConditionExpress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Array</para>
        /// </summary>
        [NameInMap("ItemConditionType")]
        [Validation(Required=false)]
        public string ItemConditionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>target-1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NewProductRegulation")]
        [Validation(Required=false)]
        public bool? NewProductRegulation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>recall-1</para>
        /// </summary>
        [NameInMap("RecallName")]
        [Validation(Required=false)]
        public string RecallName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-03-25</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("StatisPeriod")]
        [Validation(Required=false)]
        public string StatisPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Opened</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ToleranceValue")]
        [Validation(Required=false)]
        public long? ToleranceValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TrafficControlTaskId")]
        [Validation(Required=false)]
        public string TrafficControlTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public float? Value { get; set; }

    }

}
