// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class AttachEgressProxyRuleGroupsToConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>Note If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run and does not attach the egress proxy rule groups. The system checks whether required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, the system returns an HTTP 2xx status code and performs the operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the egress proxy configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epc-uf609a6a8fdf9f4d****</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationId")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationId { get; set; }

        /// <summary>
        /// <para>The list of egress proxy rule group references to be attached to the egress proxy configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EgressProxyRuleGroups")]
        [Validation(Required=false)]
        public List<AttachEgressProxyRuleGroupsToConfigurationRequestEgressProxyRuleGroups> EgressProxyRuleGroups { get; set; }
        public class AttachEgressProxyRuleGroupsToConfigurationRequestEgressProxyRuleGroups : TeaModel {
            /// <summary>
            /// <para>The ID of the egress proxy rule group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eprg-uf60966a9633667c****</para>
            /// </summary>
            [NameInMap("EgressProxyRuleGroupId")]
            [Validation(Required=false)]
            public string EgressProxyRuleGroupId { get; set; }

            /// <summary>
            /// <para>The priority of the egress proxy rule group in the egress proxy configuration. Valid values: 1 to 1000. A smaller value indicates a higher priority.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

    }

}
