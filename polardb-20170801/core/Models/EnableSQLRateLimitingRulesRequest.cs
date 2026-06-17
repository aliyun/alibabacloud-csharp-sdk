// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EnableSQLRateLimitingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
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
        /// <item><description><para><b>true</b>: Enable.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only when you specify the <b>RuleNameList</b> parameter.</para>
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
        /// <para>The names of the SQL throttling rules to enable. To specify multiple rules, separate the names with a comma (,).</para>
        /// <remarks>
        /// <para>You can view all SQL throttling rules and their names on the SQL Firewall tab of the Security Management page for the cluster.</para>
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
