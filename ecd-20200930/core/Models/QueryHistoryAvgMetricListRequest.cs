// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryAvgMetricListRequest : TeaModel {
        /// <summary>
        /// <para>The start date for statistics. Format: &quot;YYYY-MM-DD&quot;. Default value: T-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-01</para>
        /// </summary>
        [NameInMap("DataDate")]
        [Validation(Required=false)]
        public string DataDate { get; set; }

        /// <summary>
        /// <para>The list of desktop IDs. A maximum of 100 IDs are supported.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The type of monitoring metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOAD_SCORE</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. The value must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Valid values: 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of custom numeric ranges.</para>
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public QueryHistoryAvgMetricListRequestRange Range { get; set; }
        public class QueryHistoryAvgMetricListRequestRange : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include the maximum value. Default value: false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IncludeMax")]
            [Validation(Required=false)]
            public bool? IncludeMax { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the minimum value. Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IncludeMin")]
            [Validation(Required=false)]
            public bool? IncludeMin { get; set; }

            /// <summary>
            /// <para>The range label, which is used in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>label-02\&quot;</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The maximum value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Max")]
            [Validation(Required=false)]
            public float? Max { get; set; }

            /// <summary>
            /// <para>The minimum value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Min")]
            [Validation(Required=false)]
            public float? Min { get; set; }

        }

        /// <summary>
        /// <para>The region of the desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

    }

}
