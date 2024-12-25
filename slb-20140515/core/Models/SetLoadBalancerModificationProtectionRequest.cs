// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerModificationProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719dfa08e*****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The reason why the configuration read-only mode is enabled. The value must be 1 to 80 characters in length. It must start with a letter and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para> This parameter is valid only if the <b>ModificationProtectionStatus</b> parameter is set to <b>ConsoleProtection</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Configuration change</para>
        /// </summary>
        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the configuration read-only mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NonProtection</b>: disables the configuration read-only mode. After you disable the configuration read-only mode, the value of <b>ModificationProtectionReason</b> is cleared.</description></item>
        /// <item><description><b>ConsoleProtection</b>: enables the configuration read-only mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set this parameter to <b>ConsoleProtection</b>, you cannot use the CLB console to modify instance configurations. However, you can call API operations to modify instance configurations.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ConsoleProtection</para>
        /// </summary>
        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the CLB instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
