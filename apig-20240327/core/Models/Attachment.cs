// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class Attachment : TeaModel {
        /// <summary>
        /// <para>attachResourceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-xxx</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>The list of mounted resource IDs.</para>
        /// </summary>
        [NameInMap("attachResourceIds")]
        [Validation(Required=false)]
        public List<string> AttachResourceIds { get; set; }

        /// <summary>
        /// <para>The list of parent IDs of the mounted resource.</para>
        /// </summary>
        [NameInMap("attachResourceParentIds")]
        [Validation(Required=false)]
        public List<string> AttachResourceParentIds { get; set; }

        /// <summary>
        /// <para>The type of mount point supported by the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: HttpApi.</description></item>
        /// <item><description>Operation: Operation of HttpApi.</description></item>
        /// <item><description>GatewayRoute: gateway route.</description></item>
        /// <item><description>GatewayService: gateway service.</description></item>
        /// <item><description>GatewayServicePort: gateway service port.</description></item>
        /// <item><description>Domain: gateway domain name.</description></item>
        /// <item><description>Gateway: gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HttpApi</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The environment to which the mounted resource belongs. If the environment ID is *, the mounted resource of the policy is not associated with any environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The gateway to which the mounted resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpr4f9dlhtgq5ksfgmb0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The policy mount ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pr-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("policyAttachmentId")]
        [Validation(Required=false)]
        public string PolicyAttachmentId { get; set; }

    }

}
