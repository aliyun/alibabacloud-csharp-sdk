// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumBillsByDateRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the cost statistics period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718590596556</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>A list of instance names. In this context, an instance is a MaxCompute project.</para>
        /// </summary>
        [NameInMap("projectNames")]
        [Validation(Required=false)]
        public List<string> ProjectNames { get; set; }

        /// <summary>
        /// <para>The start time of the cost statistics period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715393576201</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The statistics type. Valid values: <c>PROJECT</c> (by instance) and <c>FEE_ITEM</c> (by billable item).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROJECT</para>
        /// </summary>
        [NameInMap("statsType")]
        [Validation(Required=false)]
        public string StatsType { get; set; }

        /// <summary>
        /// <para>The number of top results to return, sorted by cost.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("topN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

    }

}
