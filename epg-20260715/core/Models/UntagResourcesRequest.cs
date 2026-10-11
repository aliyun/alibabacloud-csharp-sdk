// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from the resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Removes all tags from the resources.</description></item>
        /// <item><description><b>false</b> (default): Does not remove all tags from the resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the client token on the client side. Make sure that the client token is unique across different requests. The client token can only contain ASCII characters.</para>
        /// <remarks>
        /// <para>Note: If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run. The system checks the request without removing the resource tags. Check items include whether required parameters are specified, the request format, and service limits. If the check fails, the corresponding error is returned. If the check succeeds, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Performs a normal request. If the check succeeds, an HTTP 2xx status code is returned and the operation is directly executed.</para>
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
        /// <para>The list of resource IDs. You can specify up to 50 resource IDs in a single call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EgressProxyGateway</b>: egress proxy gateway instance</description></item>
        /// <item><description><b>EgressProxyIpPool</b>: egress proxy IP address pool</description></item>
        /// <item><description><b>EgressProxyConfiguration</b>: egress proxy configuration</description></item>
        /// <item><description><b>EgressProxyRuleGroup</b>: egress proxy rule group</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EgressProxyGateway</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The list of tag keys to remove. You can remove up to 20 tags in a single call.</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
