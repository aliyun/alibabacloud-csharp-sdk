// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DeleteSQLRateLimitingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID. Invocation instructions: append DPI engine type restrictions to the DBClusterId parameter description, specifying that the SQL throttling feature is supported only for PostgreSQL and Oracle DPI engine clusters, and MySQL clusters do not support this feature. Invocation instructions: append cluster status prerequisites to the DBClusterId parameter description, specifying that the cluster must be in the Running state when you invoke this API, and that you can invoke the DescribeDBClusters API and perform a Field-specific search on the DBClusterStatus field to query the current state.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-**************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

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
        /// <para>The names of the SQL throttling rules to delete. You can specify multiple rule names to delete rules in batches. Separate multiple names with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeSQLRateLimitingRules</a> operation to view the details of all SQL throttling rules in the specified cluster, including the rule names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleNameList")]
        [Validation(Required=false)]
        public string RuleNameList { get; set; }

    }

}
