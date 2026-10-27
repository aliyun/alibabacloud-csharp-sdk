// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class TransferResourcesOutofGroupRequest : TeaModel {
        /// <summary>
        /// <para>The software blacklists and whitelists rule ID to associate with the resources after they are moved out of the resource group. This parameter is used only for pure move-out operations and cannot be set together with TargetResourceGroupId. If this parameter is left empty, no rule is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bwr-47wdwfe5x3ql7qwf4</para>
        /// </summary>
        [NameInMap("AppRuleId")]
        [Validation(Required=false)]
        public string AppRuleId { get; set; }

        /// <summary>
        /// <para>The channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("BusinessChannel")]
        [Validation(Required=false)]
        public string BusinessChannel { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Fixed value: AliyunConsole.</para>
        /// <list type="bullet">
        /// <item><description>For Wuying Enterprise Edition, set this parameter to AliyunConsole. Other platforms are not publicly available.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunConsole</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The policy ID to associate with the resources after they are moved out of the resource group. This parameter is used only for pure move-out operations and cannot be specified together with TargetResourceGroupId. If this parameter is left empty, the system default behavior is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system-all-enabled-policy</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-66konqltcpx43****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of resources.</para>
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<TransferResourcesOutofGroupRequestResources> Resources { get; set; }
        public class TransferResourcesOutofGroupRequestResources : TeaModel {
            /// <summary>
            /// <para>The region ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-1shc5sk0vo****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DESKTOP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the target resource group to which you want to move the resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-hcjo6dugpo1****</para>
        /// </summary>
        [NameInMap("TargetResourceGroupId")]
        [Validation(Required=false)]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// <para>The scheduled task ID to associate with the resources after they are moved out of the resource group. This parameter is used only for pure move-out operations and cannot be specified together with TargetResourceGroupId. If this parameter is left empty, no scheduled task is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-0bf5d87dtipve4aqt</para>
        /// </summary>
        [NameInMap("TimerId")]
        [Validation(Required=false)]
        public string TimerId { get; set; }

    }

}
