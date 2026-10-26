// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListRecallManagementJobsRequest : TeaModel {
        /// <summary>
        /// <para><b>The filter conditions.</b> Currently, only filter conditions for the Table type are supported, such as <c>{&quot;RecallManagementTableId&quot;:&quot;1&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;RecallManagementTableId&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public Dictionary<string, object> Condition { get; set; }

        /// <summary>
        /// <para><b>The instance ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-test1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para><b>The sorting order.</b> <c>ASC</c>: ascending order. <c>DESC</c>: descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para><b>The page number.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para><b>The sorting criterion.</b> <c>GmtCreateTime</c>: creation time. <c>GmtModifiedTime</c>: update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para><b>The task type.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>Table</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
