// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListStatisticLogsRequest : TeaModel {
        /// <summary>
        /// <para>The fields to query. Format: columns=wordsTopPv.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/187665.html">Metrics in statistical reports</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wordsTopPv</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public string Columns { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the distinct clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("distinct")]
        [Validation(Required=false)]
        public bool? Distinct { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
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
        /// <para>The content of the query clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;default:\&quot;OpenSearch\&quot;&quot;</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The content of the sort clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;-id&quot;</para>
        /// </summary>
        [NameInMap("sortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The default value is the timestamp of 00:00:00 on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1582214400</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The default value is the timestamp of 24:00:00 on the current day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1682222400</para>
        /// </summary>
        [NameInMap("stopTime")]
        [Validation(Required=false)]
        public int? StopTime { get; set; }

    }

}
