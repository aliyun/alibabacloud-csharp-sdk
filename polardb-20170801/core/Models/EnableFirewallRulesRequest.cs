// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EnableFirewallRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the specified firewall rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the specified firewall rules.</description></item>
        /// <item><description><b>false</b>: disables the specified firewall rules.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when you specify the <b>RuleNameList</b> parameter.</para>
        /// </remarks>
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
        /// <para>The name of the firewall rule that you want to enable for the cluster. You can specify multiple firewall rules at a time. Separate multiple rules with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeFirewallRules</b> operation to query the details of all firewall rules that are applicable to a cluster, such as rule names.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test111</para>
        /// </summary>
        [NameInMap("RuleNameList")]
        [Validation(Required=false)]
        public string RuleNameList { get; set; }

    }

}
