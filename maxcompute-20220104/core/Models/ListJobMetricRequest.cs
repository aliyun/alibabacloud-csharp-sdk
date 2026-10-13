// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobMetricRequest : TeaModel {
        /// <summary>
        /// <para>The grouping basis.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>project: grouping and aggregation by project</description></item>
        /// <item><description>quota: grouping and aggregation by quota</description></item>
        /// <item><description>type: grouping and aggregation by job type</description></item>
        /// <item><description>status: grouping and aggregation by job status</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>project</para>
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The metric information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>num</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The monitoring statistical period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The list of MaxCompute project names used for filtering.</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public List<string> Project { get; set; }

        /// <summary>
        /// <para>The list of compute quota nicknames used for filtering.</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public List<string> Quota { get; set; }

        /// <summary>
        /// <para>The metric type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>total</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The end time of the query time range. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start time of the query time range. The value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735534322</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
