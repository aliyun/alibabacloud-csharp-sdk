// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class QueryTunnelMetricDetailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order. If you set this parameter to <c>true</c>, the results are sorted in ascending order. If you set this to <c>false</c> or leave it unspecified, the results are sorted in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ascOrder")]
        [Validation(Required=false)]
        public bool? AscOrder { get; set; }

        /// <summary>
        /// <para>A list of error codes to filter the results.</para>
        /// </summary>
        [NameInMap("codeList")]
        [Validation(Required=false)]
        public List<long?> CodeList { get; set; }

        /// <summary>
        /// <para>The list of grouping dimensions.</para>
        /// </summary>
        [NameInMap("groupList")]
        [Validation(Required=false)]
        public List<string> GroupList { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Default: 10. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>A list of operation types.</para>
        /// </summary>
        [NameInMap("operationList")]
        [Validation(Required=false)]
        public List<string> OperationList { get; set; }

        /// <summary>
        /// <para>The sort column.</para>
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
        /// <para>The nickname of the level-2 tunnel quota.</para>
        /// <para>The nickname for a shared quota is <c>default</c>.</para>
        /// <para>For an exclusive quota, the nickname is in the <c>quotaNickname#subQuotaNickname</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota_A</para>
        /// </summary>
        [NameInMap("quotaNickname")]
        [Validation(Required=false)]
        public string QuotaNickname { get; set; }

        /// <summary>
        /// <para>A list of table names.</para>
        /// <para>The <c>project</c> parameter is required if you specify a list of tables. All tables must belong to the specified project.</para>
        /// </summary>
        [NameInMap("tableList")]
        [Validation(Required=false)]
        public List<string> TableList { get; set; }

        /// <summary>
        /// <para>The end of the query time range. This is a Unix timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1735536322</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start of the query time range. This is a Unix timestamp in seconds.</para>
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
