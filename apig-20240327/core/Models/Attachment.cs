// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class Attachment : TeaModel {
        /// <summary>
        /// <para>The attachment point ID.</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>A list of attached resource IDs.</para>
        /// </summary>
        [NameInMap("attachResourceIds")]
        [Validation(Required=false)]
        public List<string> AttachResourceIds { get; set; }

        /// <summary>
        /// <para>A list of parent resource IDs.</para>
        /// </summary>
        [NameInMap("attachResourceParentIds")]
        [Validation(Required=false)]
        public List<string> AttachResourceParentIds { get; set; }

        /// <summary>
        /// <para>The supported attachment point types for the policy.</para>
        /// <list type="bullet">
        /// <item><description><para><c>HttpApi</c>: An HTTP API.</para>
        /// </description></item>
        /// <item><description><para><c>Operation</c>: An operation of an HTTP API.</para>
        /// </description></item>
        /// <item><description><para><c>GatewayRoute</c>: A gateway route.</para>
        /// </description></item>
        /// <item><description><para><c>GatewayService</c>: A gateway service.</para>
        /// </description></item>
        /// <item><description><para><c>GatewayServicePort</c>: A gateway service port.</para>
        /// </description></item>
        /// <item><description><para><c>Domain</c>: A gateway domain.</para>
        /// </description></item>
        /// <item><description><para><c>Gateway</c>: A gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HttpApi</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the environment for the attached resource. An asterisk (<c>*</c>) indicates that the policy attachment is not environment-specific.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The ID of the gateway for the attached resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cpr4f9dlhtgq5ksfgmb0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The policy attachment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pr-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("policyAttachmentId")]
        [Validation(Required=false)]
        public string PolicyAttachmentId { get; set; }

    }

}
