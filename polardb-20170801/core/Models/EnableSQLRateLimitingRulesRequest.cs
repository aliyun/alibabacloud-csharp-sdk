// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EnableSQLRateLimitingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID. Notes on invoking: The SQL throttling feature is supported only for clusters that have the database proxy enabled. Currently, the Oracle-compatible engine is verified to support this feature. For MySQL clusters, confirm whether the database proxy and the SQL throttling feature are enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the specified SQL throttling rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the rules.</description></item>
        /// <item><description><b>false</b>: disables the rules.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>RuleNameList</b> is specified.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

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
        /// <para>The names of the SQL throttling rules to enable or disable. You can specify multiple rule names for batch operations. Separate multiple names with commas (,).</para>
        /// <remarks>
        /// <para>You can view all SQL throttling rule information, including rule names, on the <b>SQL Firewall</b> tab of the <b>Security Management</b> page in the cluster console.</para>
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
