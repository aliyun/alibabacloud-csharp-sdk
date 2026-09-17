// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ApmMeasureConfig : TeaModel {
        /// <summary>
        /// <para>The list of grouping dimensions for the APM metric. This parameter specifies the dimension keys by which to perform grouping and aggregation on metric data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;host.name&quot;, &quot;service.name&quot;]</para>
        /// </summary>
        [NameInMap("groupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

        /// <summary>
        /// <para>The code identifier of the APM metric. This parameter specifies the metric type to collect and query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("measureCode")]
        [Validation(Required=false)]
        public string MeasureCode { get; set; }

        /// <summary>
        /// <para>The query time window, in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public int? WindowSecs { get; set; }

    }

}
