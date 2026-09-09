// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryTunnelMetricRequest : TeaModel {
        /// <summary>
        /// <para>A list of HTTP status codes for requests.</para>
        /// </summary>
        [NameInMap("codeList")]
        [Validation(Required=false)]
        public List<int?> CodeList { get; set; }

        /// <summary>
        /// <para>A list of grouping criteria.</para>
        /// </summary>
        [NameInMap("groupList")]
        [Validation(Required=false)]
        public List<string> GroupList { get; set; }

        /// <summary>
        /// <para>A list of operation types.</para>
        /// </summary>
        [NameInMap("operationList")]
        [Validation(Required=false)]
        public List<string> OperationList { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project_a</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The nickname of the level-2 Tunnel quota.</para>
        /// <para>The nickname of a shared quota is <c>default</c>.</para>
        /// <para>The format of a dedicated quota nickname is <c>quotaNickname#subQuotaNickname</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("quotaNickname")]
        [Validation(Required=false)]
        public string QuotaNickname { get; set; }

        /// <summary>
        /// <para>A list of table names.</para>
        /// <para>The tables belong to a project. Therefore, if <c>tableList</c> is not empty, <c>project</c> cannot be empty.</para>
        /// </summary>
        [NameInMap("tableList")]
        [Validation(Required=false)]
        public List<string> TableList { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries to return.</para>
        /// <para>This parameter takes effect when the grouping criterion includes <c>table</c> or <c>ip</c>.</para>
        /// <para>The default value is 10. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("topN")]
        [Validation(Required=false)]
        public int? TopN { get; set; }

        /// <summary>
        /// <para>The end of the time range for the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start of the time range for the query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735534322</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The data aggregation policy. The default value is <c>max</c>.</para>
        /// <para>Data is collected at a frequency of 1 minute. If you query data over a long time range, the automatic step size for data display may exceed 1 minute. In this case, metrics are aggregated. This parameter specifies the aggregation logic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>max</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
