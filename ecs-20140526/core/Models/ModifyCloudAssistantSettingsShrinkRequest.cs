// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Cloud Assistant Agent upgrade configuration.</para>
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public string AgentUpgradeConfigShrink { get; set; }

        /// <summary>
        /// <para>The OSS delivery configuration.</para>
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
        /// <para>The Cloud Assistant resource usage configuration. This parameter takes effect only when the Cloud Assistant Agent version meets the following minimum requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Windows: 2.1.4.1065</para>
        /// </description></item>
        /// <item><description><para>Linux: 2.2.4.1065</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ResourceUsageConfig")]
        [Validation(Required=false)]
        public string ResourceUsageConfigShrink { get; set; }

        /// <summary>
        /// <para>The Cloud Assistant session feature configuration.</para>
        /// </summary>
        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public string SessionManagerConfigShrink { get; set; }

        /// <summary>
        /// <para>The service configuration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SessionManagerDelivery: session operation log delivery.</description></item>
        /// <item><description>InvocationDelivery: task execution log delivery.</description></item>
        /// <item><description>AgentUpgradeConfig: Cloud Assistant Agent upgrade configuration.</description></item>
        /// <item><description>SessionManagerConfig: Cloud Assistant SessionManager configuration.</description></item>
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
        /// <para>The Simple Log Service (SLS) delivery configuration.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfig")]
        [Validation(Required=false)]
        public string SlsDeliveryConfigShrink { get; set; }

    }

}
