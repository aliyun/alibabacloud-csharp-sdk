// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCloudAssistantSettingsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of upgrading the Cloud Assistant agent.</para>
        /// </summary>
        [NameInMap("AgentUpgradeConfig")]
        [Validation(Required=false)]
        public string AgentUpgradeConfigShrink { get; set; }

        /// <summary>
        /// <para>The configurations of delivering records to OSS.</para>
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
        /// <para>The ID of the region.</para>
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
        /// <para>The configurations of resource usage for Cloud Assistant. This setting takes effect only when the version of the Cloud Assistant agent is not earlier than the following versions:</para>
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
        /// <para>The configurations of the Session Manager feature.</para>
        /// </summary>
        [NameInMap("SessionManagerConfig")]
        [Validation(Required=false)]
        public string SessionManagerConfigShrink { get; set; }

        /// <summary>
        /// <para>The type of the service configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>SessionManagerDelivery</c>: the configurations of delivering session records.</para>
        /// </description></item>
        /// <item><description><para><c>InvocationDelivery</c>: the configurations of delivering command execution records.</para>
        /// </description></item>
        /// <item><description><para><c>AgentUpgradeConfig</c>: the configurations of upgrading the Cloud Assistant agent.</para>
        /// </description></item>
        /// <item><description><para><c>SessionManagerConfig</c>: the configurations of Cloud Assistant Session Manager.</para>
        /// </description></item>
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
        /// <para>The configurations of delivering records to SLS.</para>
        /// </summary>
        [NameInMap("SlsDeliveryConfig")]
        [Validation(Required=false)]
        public string SlsDeliveryConfigShrink { get; set; }

    }

}
