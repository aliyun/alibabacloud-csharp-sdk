// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryMetricDistributionRequest : TeaModel {
        /// <summary>
        /// <para>The end date of the query period. The date must be in the <c>YYYY-MM-DD</c> format. The default value is T-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-01</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The name of the metric to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LOAD_SCORE</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>An array of custom value ranges.</para>
        /// </summary>
        [NameInMap("Ranges")]
        [Validation(Required=false)]
        public List<QueryHistoryMetricDistributionRequestRanges> Ranges { get; set; }
        public class QueryHistoryMetricDistributionRequestRanges : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include the maximum value in the range. The default value is <c>false</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IncludeMax")]
            [Validation(Required=false)]
            public bool? IncludeMax { get; set; }

            /// <summary>
            /// <para>Specifies whether to include the minimum value in the range. The default value is <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IncludeMin")]
            [Validation(Required=false)]
            public bool? IncludeMin { get; set; }

            /// <summary>
            /// <para>The label for the value range. This label is returned in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>label-02\&quot;</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The maximum value of the value range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Max")]
            [Validation(Required=false)]
            public float? Max { get; set; }

            /// <summary>
            /// <para>The minimum value of the value range.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Min")]
            [Validation(Required=false)]
            public float? Min { get; set; }

        }

        /// <summary>
        /// <para>The start date of the query period. The date must be in the <c>YYYY-MM-DD</c> format. The default value is T-1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-01</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
