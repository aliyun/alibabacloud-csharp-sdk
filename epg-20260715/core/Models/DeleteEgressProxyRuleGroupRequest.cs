// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class DeleteEgressProxyRuleGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the value of this parameter on the client side. Make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para><b>Note</b>: If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request is unique.</para>
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
        /// <item><description><para><b>true</b>: sends a check request and does not delete the rule group. The system checks whether the required parameters are specified, the request format is valid, and the service limits are met. If the check fails, the corresponding error is returned. If the check succeeds, the error code DryRunOperation is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a regular request. If the check succeeds, the HTTP 2xx status code is returned and the operation is performed.</para>
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
        /// <para>The ID of the egress proxy rule group that you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eprg-uf60966a9633667c****</para>
        /// </summary>
        [NameInMap("EgressProxyRuleGroupId")]
        [Validation(Required=false)]
        public string EgressProxyRuleGroupId { get; set; }

    }

}
