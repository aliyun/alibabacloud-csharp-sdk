// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class Attachment : TeaModel {
        /// <summary>
        /// <para>The resource IDs.</para>
        /// </summary>
        [NameInMap("attachResourceIds")]
        [Validation(Required=false)]
        public List<string> AttachResourceIds { get; set; }

        /// <summary>
        /// <para>The supported mount point type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: an HTTP API</description></item>
        /// <item><description>Operation: an operation in an HTTP API</description></item>
        /// <item><description>GatewayRoute: a gateway route</description></item>
        /// <item><description>GatewayService: a gateway service</description></item>
        /// <item><description>GatewayServicePort: a gateway service port</description></item>
        /// <item><description>Domain: a gateway domain name</description></item>
        /// <item><description>Gateway: a gateway instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HttpApi</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The environment to which the mounted resource belongs. If an asterisk (\*) is returned as the environment ID, the mounted resource is not related to the environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The instance to which the mounted resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpr4f9dlhtgq5ksfgmb0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The mount ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pr-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("policyAttachmentId")]
        [Validation(Required=false)]
        public string PolicyAttachmentId { get; set; }

    }

}
