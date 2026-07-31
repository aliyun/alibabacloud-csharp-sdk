// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostAttributeRequest : TeaModel {
        [NameInMap("NetworkAttributes")]
        [Validation(Required=false)]
        public ModifyDedicatedHostAttributeRequestNetworkAttributes NetworkAttributes { get; set; }
        public class ModifyDedicatedHostAttributeRequestNetworkAttributes : TeaModel {
            /// <summary>
            /// <para>The timeout period of UDP sessions for load balancing connections. Unit: seconds. Valid values: 15 to 310.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("SlbUdpTimeout")]
            [Validation(Required=false)]
            public int? SlbUdpTimeout { get; set; }

            /// <summary>
            /// <para>The timeout period of UDP sessions for user access to cloud services running on the dedicated host. Unit: seconds. Valid values: 15 to 310.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("UdpTimeout")]
            [Validation(Required=false)]
            public int? UdpTimeout { get; set; }

        }

        /// <summary>
        /// <para>The migration plan for the instances on the dedicated host when the dedicated host fails or needs to be repaired online. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Migrate: The instances are migrated to another physical server and restarted.</para>
        /// </description></item>
        /// <item><description><para>Stop: The instances are stopped on the current dedicated host. After the dedicated host is confirmed to be irreparable, the instances are migrated to another physical server and restarted.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value when cloud disks are attached to the dedicated host: Migrate.</para>
        /// <para>Default value when local disks are attached to the dedicated host: Stop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Migrate</para>
        /// </summary>
        [NameInMap("ActionOnMaintenance")]
        [Validation(Required=false)]
        public string ActionOnMaintenance { get; set; }

        /// <summary>
        /// <para>Specifies whether the dedicated host is added to the automatic deployment resource pool. If you do not specify DedicatedHostId when you create an instance on a dedicated host, Alibaba Cloud automatically selects a dedicated host from the resource pool to host the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>on: The dedicated host is added to the automatic deployment resource pool.</para>
        /// </description></item>
        /// <item><description><para>off: The dedicated host is not added to the automatic deployment resource pool.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about the automatic deployment feature, see <a href="https://help.aliyun.com/document_detail/118938.html">Features</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("AutoPlacement")]
        [Validation(Required=false)]
        public string AutoPlacement { get; set; }

        /// <summary>
        /// <para>The CPU overcommit ratio. Only the custom instance families g6s, c6s, and r6s support CPU overcommit ratios. Valid values: 1 to 5.</para>
        /// <para>The CPU overcommit ratio affects the number of available vCPUs on a dedicated host. Available vCPUs on a dedicated host = Number of physical CPU cores × 2 × CPU overcommit ratio. For example, the number of physical CPU cores on a g6s dedicated host is 52. If you set the CPU overcommit ratio to 4, the total number of vCPUs becomes 416. For scenarios that do not require absolute CPU stability or have low CPU loads, such as development and testing environments, you can increase the overcommit ratio to increase the number of available vCPUs. This way, you can deploy more ECS instances of the same specifications and reduce the unit deployment cost.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuOverCommitRatio")]
        [Validation(Required=false)]
        public float? CpuOverCommitRatio { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated host cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-bp165p6xk2tlw61e****</para>
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the dedicated host.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dh-bp165p6xk2tlw61e****</para>
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// <para>The name of the dedicated host. The name must be 2 to 128 characters in length and can contain letters, digits, colons (:), underscores (_), and hyphens (-). It must start with a letter and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDedicatedHostName</para>
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// <para>The description of the dedicated host. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the dedicated host. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
