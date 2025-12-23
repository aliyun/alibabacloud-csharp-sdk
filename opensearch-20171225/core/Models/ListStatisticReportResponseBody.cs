// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F65C8BB2-C14F-5983-888B-41C4E082D3BC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistical reports. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For more information about the metrics in data quality reports, see the Upload behavioral data section of <a href="https://help.aliyun.com/document_detail/131547.html">Data collection 2.0</a>.</description></item>
        /// <item><description>For more information about the metrics in application and A/B test reports, see the Core metrics section of <a href="https://help.aliyun.com/document_detail/187665.html">Metrics of statistical reports</a>.</description></item>
        /// <item><description>For more information about the metrics in query analysis reports, see the Query analysis metrics section of <a href="https://help.aliyun.com/document_detail/187665.html">Metrics of statistical reports</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Result { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
