// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumComputeMetricsByUsageRequest : TeaModel {
        /// <summary>
        /// <para>The end timestamp for the query, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718590596556</para>
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>The project names.</para>
        /// </summary>
        [NameInMap("projectNames")]
        [Validation(Required=false)]
        public List<string> ProjectNames { get; set; }

        /// <summary>
        /// <para>The start timestamp for the query, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715393576201</para>
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>The usage type. Valid values: <c>CU</c> (CU usage) and <c>SCAN</c> (scanned data volume).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCAN</para>
        /// </summary>
        [NameInMap("usageType")]
        [Validation(Required=false)]
        public string UsageType { get; set; }

    }

}
