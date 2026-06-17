// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSQLRateLimitingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Maximum value: 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAARbaCuN6hiD08qrLdwJ9Fh3QbdIPYBaCDXsvvjLHCQfi</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The name of the SQL throttling rule that you want to query. You can specify multiple rule names for a batch query. Separate the rule names with commas (,).</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeSQLRateLimitingRules</a> operation to query the details of all SQL throttling rules for the cluster, including the rule names.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleNameList")]
        [Validation(Required=false)]
        public string RuleNameList { get; set; }

    }

}
