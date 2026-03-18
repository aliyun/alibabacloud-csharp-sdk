// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryTunnelMetricDetailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ascOrder")]
        [Validation(Required=false)]
        public bool? AscOrder { get; set; }

        /// <summary>
        /// <para>The list of grouping bases.</para>
        /// </summary>
        [NameInMap("groupList")]
        [Validation(Required=false)]
        public List<string> GroupList { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. The default value is 10. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The list of operation types.</para>
        /// </summary>
        [NameInMap("operationList")]
        [Validation(Required=false)]
        public List<string> OperationList { get; set; }

        /// <summary>
        /// <para>The column to sort by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxValue</para>
        /// </summary>
        [NameInMap("orderColumn")]
        [Validation(Required=false)]
        public string OrderColumn { get; set; }

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
        /// <para>The nickname of the level-2 quota for the tunnel.</para>
        /// <para>The nickname of the shared quota is default.</para>
        /// <para>The nickname of the exclusive quota is in the quotaNickname#subQuotaNickname format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_A</para>
        /// </summary>
        [NameInMap("quotaNickname")]
        [Validation(Required=false)]
        public string QuotaNickname { get; set; }

        /// <summary>
        /// <para>The list of table names.</para>
        /// <para>The tables belong to a project. Therefore, if tableList is not empty, project cannot be empty.</para>
        /// </summary>
        [NameInMap("tableList")]
        [Validation(Required=false)]
        public List<string> TableList { get; set; }

        /// <summary>
        /// <para>The end of the time range to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start of the time range to query.</para>
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
