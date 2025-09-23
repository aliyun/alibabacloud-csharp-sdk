// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyFirewallRulesRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;id&quot;:&quot;test&quot;,&quot;enabled&quot;:&quot;true&quot;,&quot;mode&quot;:&quot;Collecting&quot;,&quot;users&quot;:{&quot;applies_to&quot;:[]},&quot;endpoint&quot;:&quot;[{&quot;EndpointName&quot;:&quot;pe-<b><b><b><b><b><b>&quot;,&quot;EndpointType&quot;:&quot;Cluster&quot;,&quot;DBEndpointDescription&quot;:&quot;Cluster Address&quot;},{&quot;EndpointName&quot;:&quot;pe-</b></b></b></b></b></b>&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-<b><b><b><b><b><b>&quot;},{&quot;EndpointName&quot;:&quot;pe-</b></b></b></b></b></b>&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-************K&quot;}]&quot;,&quot;type&quot;:&quot;WhiteList&quot;}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
