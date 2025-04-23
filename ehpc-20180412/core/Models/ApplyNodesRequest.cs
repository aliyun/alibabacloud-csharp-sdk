// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ApplyNodesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allocate a public IP address to the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: A public IP address is allocated to the compute nodes.</description></item>
        /// <item><description>false: A public IP address is not allocated to the compute nodes.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllocatePublicAddress")]
        [Validation(Required=false)]
        public bool? AllocatePublicAddress { get; set; }

        /// <summary>
        /// <para>The ID of the E-HPC cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87126.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The maximum hourly price of the compute nodes. The value is a floating-point number that supports up to three decimal places. The parameter takes effect only when ComputeSpotStrategy is set to SpotWithPriceLimit.</para>
        /// <para>If ComputeSpotPriceLimit and InstanceTypeModel.N.MaxPrice are specified at the same time, compute nodes are created based on the smaller value of the two parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.68</para>
        /// </summary>
        [NameInMap("ComputeSpotPriceLimit")]
        [Validation(Required=false)]
        public float? ComputeSpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The preemption policy of the compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The compute nodes are pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The compute nodes are preemptible instances that have a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("ComputeSpotStrategy")]
        [Validation(Required=false)]
        public string ComputeSpotStrategy { get; set; }

        /// <summary>
        /// <para>The number of vCPUs. The parameter is required when the ResourceAmountType parameter is set to Cores.</para>
        /// <para>You can set vCPU and Memory to query node specifications. For example, you can query the available compute nodes that have 2 vCPUs and 16 GB of memory by setting vCPU to 2 and Memory to 16. You can also query compute nodes by node specification and zone. Query results are sorted by price. The nodes that have the lowest price are created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        /// <summary>
        /// <para>The prefix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        /// <summary>
        /// <para>The suffix of the hostname. You can specify the parameter to manage the compute nodes in an efficient manner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        /// <summary>
        /// <para>The image ID of the compute nodes to be added. The parameter takes effect only when the TargetImageId parameter is not specified.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87213.html">ListImages</a> and <a href="https://help.aliyun.com/document_detail/87215.html">ListCustomImages</a> operations to query the image ID.</para>
        /// <remarks>
        /// <para> If you add multiple compute nodes, the TargetImageId parameter takes effect only on the nodes for which the TargetImageId parameter is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>centos_7_06_64_20G_alibase_20190711.vhd</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The level of the instance family. The parameter takes effect only when Cores and Memory are specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EntryLevel</description></item>
        /// <item><description>EnterpriseLevel</description></item>
        /// <item><description>CreditEntryLevel For more information, see <a href="https://help.aliyun.com/document_detail/59977.html">Overview of burstable instances</a>.</description></item>
        /// </list>
        /// <para>Default value: EnterpriseLevel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EntryLevel</para>
        /// </summary>
        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        /// <summary>
        /// <para>The information about the preemptible instance.</para>
        /// </summary>
        [NameInMap("InstanceTypeModel")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestInstanceTypeModel> InstanceTypeModel { get; set; }
        public class ApplyNodesRequestInstanceTypeModel : TeaModel {
            /// <summary>
            /// <para>The instance type of the compute node. The default value is the instance type that was specified when you created the cluster or the last time you added compute nodes.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.n1.tiny</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The maximum hourly price that you can pay for the preemptible node. The value is a floating-point number that supports up to three decimal places.</para>
            /// <para>The parameter takes effect only when ComputeSpotStrategy is set to SpotWithPriceLimit.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.034</para>
            /// </summary>
            [NameInMap("MaxPrice")]
            [Validation(Required=false)]
            public float? MaxPrice { get; set; }

            /// <summary>
            /// <para>The image ID of the compute node. You must select a Windows image.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win2016_1607_x64_dtc_zh-cn_40G_alibase_20210516.vhd</para>
            /// </summary>
            [NameInMap("TargetImageId")]
            [Validation(Required=false)]
            public string TargetImageId { get; set; }

        }

        /// <summary>
        /// <para>The billing method of the elastic IP address (EIP). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayByBandwidth: pay-by-bandwidth</description></item>
        /// <item><description>PayByTraffic: pay-by-traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s, the valid values of the parameter are 1 to 10 and the default value is 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s, the valid values of this parameter are 1 to the amount of the outbound bandwidth that is purchased. The default value is the value of the InternetMaxBandWidthOut parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandWidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandWidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandWidthOut { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive batches. Valid values: 60 to 600. Unit: seconds.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The queue to which the compute nodes are added.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/92176.html">ListQueues</a> operation to query the queue name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workq</para>
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// <para>The memory capacity. The parameter is required when the ResourceAmountType parameter is set to Cores. Unit: GB.</para>
        /// <para>You can set vCPU and Memory to query node specifications. For example, you can query the available compute nodes that have 2 vCPUs and 16 GB of memory by setting vCPU to 2 and Memory to 16. You can also query compute nodes by node specification and zone. Query results are sorted by price. The nodes that have the lowest price are created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The application policy of the preemptible nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LowPriceResourcePlanning: Preemptible nodes are created based on the unit prices of vCPUs in ascending order. Preemptible nodes are created first when multiple preemptible instance types are specified.</description></item>
        /// <item><description>CapacityOptResourcePlanning: Preemptible nodes are created based on the prices and release rates in ascending order.</description></item>
        /// <item><description>CustomizedResourcePlanning: Nodes are added based on the predefined value of the ZoneIds.N parameter. Instances of a zone that has a higher priority are used first.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LowPriceResourcePlanning</para>
        /// </summary>
        [NameInMap("PriorityStrategy")]
        [Validation(Required=false)]
        public string PriorityStrategy { get; set; }

        /// <summary>
        /// <para>The type of the resource that you want to add. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Instances: the ECS instances that are used as compute nodes</description></item>
        /// <item><description>Cores: vCPU and memory</description></item>
        /// </list>
        /// <para>Default value: Instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instances</para>
        /// </summary>
        [NameInMap("ResourceAmountType")]
        [Validation(Required=false)]
        public string ResourceAmountType { get; set; }

        /// <summary>
        /// <para>The total number of batches to create nodes. Valid values: 1 to 10.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Round")]
        [Validation(Required=false)]
        public int? Round { get; set; }

        /// <summary>
        /// <para>Specifies whether to strictly meet the requirements of the TargetCapacity parameter. The parameter takes effect only when StrictSatisfiedTargetCapacity is set to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Check the inventory of the resources. Compute nodes are created based on the value of the TargetCapacity parameter only when the available resources are sufficient. Otherwise, no compute nodes are created.</description></item>
        /// <item><description>false: Check the inventory of the resources. Compute nodes are created only when the available resources are sufficient. However, some compute nodes may fail to be created because resources become insufficient after the inventory query.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StrictResourceProvision")]
        [Validation(Required=false)]
        public bool? StrictResourceProvision { get; set; }

        /// <summary>
        /// <para>Specifies whether to meet the requirements of the TargetCapacity parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: If the available resources are fewer than the resources that you want to add, no compute nodes are created and an error is returned. If the available resources are more than the resources that you want to add, the following cases may occur:</para>
        /// <list type="bullet">
        /// <item><description>If StrictResourceProvision is set to true, check the inventory of the resources. Compute nodes are created based on the value of the TargetCapacity parameter only when the available resources are sufficient. Otherwise, no compute nodes are created.</description></item>
        /// <item><description>If StrictResourceProvision is set to false, check the inventory of the resources. Compute nodes are created only when the available resources are sufficient. However, some compute nodes may fail to be created because resources become insufficient after the inventory query.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>false: If the available resources are insufficient, compute nodes are created based on the inventory of the resources.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("StrictSatisfiedTargetCapacity")]
        [Validation(Required=false)]
        public bool? StrictSatisfiedTargetCapacity { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD that you want to use as the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single ESSD can deliver up to 50,000 IOPS of random read/write.</description></item>
        /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
        /// </list>
        /// <para>Default value: PL0. For more information, see <a href="https://help.aliyun.com/document_detail/122389.html">ESSDs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("SystemDiskLevel")]
        [Validation(Required=false)]
        public string SystemDiskLevel { get; set; }

        /// <summary>
        /// <para>The size of the system disk. Unit: GB.</para>
        /// <para>Valid values: 40 to 500.</para>
        /// <para>Default value: 40.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("SystemDiskSize")]
        [Validation(Required=false)]
        public int? SystemDiskSize { get; set; }

        /// <summary>
        /// <para>The type of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// <item><description>cloud_ssd: SSD</description></item>
        /// <item><description>cloud_essd: enhanced SSD (ESSD)</description></item>
        /// <item><description>cloud: basic disk. Disks of this type are retired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("SystemDiskType")]
        [Validation(Required=false)]
        public string SystemDiskType { get; set; }

        /// <summary>
        /// <para>The details about the tags that are added to the nodes.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestTag> Tag { get; set; }
        public class ApplyNodesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// <para>Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be an empty string. The tag value can be up to 128 characters in length. It cannot start with acs: or contain http:// or https://.</para>
            /// <para>Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The amount of the resource that you want to add. The specific number depends on the value of the ResourceAmountType parameter:</para>
        /// <list type="bullet">
        /// <item><description>If ResourceAmountType is set to Instance, the value range of TargetCapacity is 1 to 200.</description></item>
        /// <item><description>If ResourceAmountType is set to Cores, the value range of TargetCapacity is 1 to 1,000.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TargetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

        /// <summary>
        /// <para>The user data of the instance. The user data must be Base64-encoded. The raw data can be up to 16 KB in size. Linux operating systems support shell scripts. Windows operating systems support bat and Powershell scripts. Before you perform Base64 encoding, make sure that the content to be encoded includes [bat] or [powershell] as the first row.</para>
        /// <remarks>
        /// <para> We recommend that you do not pass in confidential information, such as passwords or private keys, in plaintext as user data. This is because the system does not encrypt UserData values when API requests are transmitted. If you must pass in confidential information, we recommend that you encrypt and encode the information in Base64, and then decode and decrypt the information in the same way inside the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ZWNobyBoZWxsbyBlY3Mh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The details of the zones. You can specify up to 10 zones.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneInfos")]
        [Validation(Required=false)]
        public List<ApplyNodesRequestZoneInfos> ZoneInfos { get; set; }
        public class ApplyNodesRequestZoneInfos : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch. Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1e47optm9g58zcu****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone to which the node belongs. Valid values of N: 1 to 10.</para>
            /// <remarks>
            /// <para> Each zone ID must be unique.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
