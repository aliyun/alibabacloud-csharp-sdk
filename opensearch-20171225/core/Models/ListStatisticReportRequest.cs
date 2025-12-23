// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticReportRequest : TeaModel {
        /// <summary>
        /// <para>The fields to query. Set this parameter in the format of columns=&quot;pv,uv,ipv&quot;. For more information, see <a href="https://help.aliyun.com/document_detail/187665.html">Metrics of statistical reports</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv,uv</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        /// <summary>
        /// <para>The end timestamp of the query. By default, the end time is the current time. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582646399</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query conditions. Set this parameter in the format of k1:v1,k2:v2. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>experimentSerialNumber: the globally unique sequence number of the test</description></item>
        /// <item><description>sceneTag: the tag of the test scenario</description></item>
        /// <item><description>bizType: the type of the business</description></item>
        /// <item><description>modelId: the ID of the algorithm model</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>bizType:test,sceneTag:myTag</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The start timestamp of the query. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582214400</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
