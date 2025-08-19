// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations for upgrading Cloud Assistant Agent.</para>
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public string AgentUpgradeConfigShrink { get; set; }

        /// <summary>
        /// <para>The configurations for delivering records to Object Storage Service (OSS).</para>
        /// </summary>
        [NameInMap("OssDeliveryConfig")]
        [Validation(Required=false)]
        public string OssDeliveryConfigShrink { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
        /// <para>Cloud Assistant Session Manager configuration.</para>
        /// </summary>
        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public string SessionManagerConfigShrink { get; set; }

        /// <summary>
        /// <para>The Cloud Assistant feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SessionManagerDelivery: the Session Record Delivery configurations.</description></item>
        /// <item><description>InvocationDelivery: the Operation Content and Result Delivery configurations.</description></item>
        /// <item><description>AgentUpgradeConfig: the Cloud Assistant Agent Upgrade configurations.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SessionManagerDelivery</para>
        /// </summary>
        [NameInMap("SettingType")]
        [Validation(Required=false)]
        public string SettingType { get; set; }

        /// <summary>
        /// <para>The configurations for delivering records to Simple Log Service.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfig")]
        [Validation(Required=false)]
        public string SlsDeliveryConfigShrink { get; set; }

    }

}
