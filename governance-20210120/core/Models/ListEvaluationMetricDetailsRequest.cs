// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationMetricDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member account. This parameter is applicable only to the multi-account check pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103144549568****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        /// <summary>
        /// <para>The date to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        [NameInMap("EvaluationDomain")]
        [Validation(Required=false)]
        public string EvaluationDomain { get; set; }

        /// <summary>
        /// <para>The ID of the check item for which you want to retrieve non-compliant resources.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2841889.html">ListEvaluationMetadata</a> operation to obtain the check item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xfyve5****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a single request. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAGEaXR18y1rqykZHIqRuBejOqED4S3Xne33c7zbn****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scope of the governance maturity check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Account (default): queries the check item details for the current account.</description></item>
        /// <item><description>ResourceDirectory: queries the check item details for all member accounts in the resource directory. Before using this value, upgrade to multi-account governance maturity check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Account</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The check snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-bp1r**************</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

    }

}
