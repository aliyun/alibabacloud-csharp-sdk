// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The attachment point ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("attachResourceId")]
        [Validation(Required=false)]
        public string AttachResourceId { get; set; }

        /// <summary>
        /// <para>The types of attachment points supported by the policy. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>HttpApi</description></item>
        /// <item><description>Operation</description></item>
        /// <item><description>GatewayRoute</description></item>
        /// <item><description>GatewayService</description></item>
        /// <item><description>GatewayServicePort</description></item>
        /// <item><description>Domain</description></item>
        /// <item><description>Gateway</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HttpApi</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq2fm65lhtgm9nrrl7ag</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return attachment information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("withAttachments")]
        [Validation(Required=false)]
        public bool? WithAttachments { get; set; }

        /// <summary>
        /// <para>Specifies whether it is a system policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("withSystemPolicy")]
        [Validation(Required=false)]
        public bool? WithSystemPolicy { get; set; }

    }

}
