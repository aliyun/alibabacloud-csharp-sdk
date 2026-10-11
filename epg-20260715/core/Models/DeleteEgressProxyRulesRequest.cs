// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class DeleteEgressProxyRulesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>Note: If you do not specify this parameter, the system automatically uses the request ID of the API request as the client token. The request ID of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs only a dry run and does not delete the rules. The system checks whether required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the actual request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</para>
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
        /// <para>The IDs of the egress proxy rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EgressProxyRuleIds")]
        [Validation(Required=false)]
        public List<string> EgressProxyRuleIds { get; set; }

    }

}
