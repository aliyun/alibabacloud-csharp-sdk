// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobMetricRequest : TeaModel {
        /// <summary>
        /// <para>Grouping basis.</para>
        /// <remarks>
        /// <para>Available values: project, quota, type, status. Meanings:</para>
        /// <list type="bullet">
        /// <item><description>project: Group and aggregate by project;</description></item>
        /// <item><description>quota: Group and aggregate by quota;</description></item>
        /// <item><description>type: Group and aggregate by job type;</description></item>
        /// <item><description>status: Group and aggregate by job status.</description></item>
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
        /// <para>The name of observation metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>num</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The monitoring statistical period.Unit:Second(s).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The name of MaxCompute projects (for filtering).</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public List<string> Project { get; set; }

        /// <summary>
        /// <para>The nickname of computing Quota nickname used by the job (for filtering).</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public List<string> Quota { get; set; }

        /// <summary>
        /// <para>The type of observation metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>total</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The end time for the observation interval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start time for the observation interval.</para>
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
