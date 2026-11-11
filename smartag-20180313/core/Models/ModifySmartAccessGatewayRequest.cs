// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifySmartAccessGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The private CIDR block used by clients at the on-premises site for communication. Make sure that private CIDR blocks do not conflict with each other. </para>
        /// <para>If the LAN port of the Smart Access Gateway device is configured in dynamic mode, the IP addresses used by on-premises clients with DHCP enabled are allocated from the first private CIDR block that you specify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The description of the Smart Access Gateway instance. </para>
        /// <para>The description must be 2 to 256 characters in length, and must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAG description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable connection log auditing for the SAG app. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables connection log auditing for the SAG app.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables connection log auditing for the SAG app.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSoftwareConnectionAudit")]
        [Validation(Required=false)]
        public bool? EnableSoftwareConnectionAudit { get; set; }

        /// <summary>
        /// <para>The name of the Smart Access Gateway instance. </para>
        /// <para>The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAG</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The location where the Smart Access Gateway instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;adcode&quot;:&quot;&quot;, &quot;label&quot;:&quot;Hangzhou, Zhejiang xx zone xx Road xx number&quot;, &quot;value&quot;:&quot;B0FFGxxxx&quot;, &quot;center&quot;:&quot;120.190xxxx, 30.182xxxx&quot;, &quot;_new&quot;:&quot;true&quot; } ]</para>
        /// </summary>
        [NameInMap("Position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The route synchronization mode for the on-premises network. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>static</b>: static routing.</para>
        /// </description></item>
        /// <item><description><para><b>dynamic</b>: dynamic routing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>static</para>
        /// </summary>
        [NameInMap("RoutingStrategy")]
        [Validation(Required=false)]
        public string RoutingStrategy { get; set; }

        /// <summary>
        /// <para>The threshold configured by the user for the offline lock feature. The value must be greater than or equal to 0.</para>
        /// <para>Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SecurityLockThreshold")]
        [Validation(Required=false)]
        public int? SecurityLockThreshold { get; set; }

        /// <summary>
        /// <para>The instance ID of the Smart Access Gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-0ovhf732a9j0******</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

    }

}
