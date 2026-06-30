// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListAcceleratorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the Global Accelerator instances.</para>
        /// </summary>
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<ListAcceleratorsResponseBodyAccelerators> Accelerators { get; set; }
        public class ListAcceleratorsResponseBodyAccelerators : TeaModel {
            /// <summary>
            /// <para>The ID of the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <para>The bandwidth of the Global Accelerator instance. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The billing method for the bandwidth.</para>
            /// <list type="bullet">
            /// <item><description><para><b>BandwidthPackage</b>: pay-by-bandwidth-plan.</para>
            /// </description></item>
            /// <item><description><para><b>CDT</b>: pay-by-data-transfer.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CDT</para>
            /// </summary>
            [NameInMap("BandwidthBillingType")]
            [Validation(Required=false)]
            public string BandwidthBillingType { get; set; }

            /// <summary>
            /// <para>The details of the basic bandwidth plan that is associated with the Global Accelerator instance.</para>
            /// </summary>
            [NameInMap("BasicBandwidthPackage")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage BasicBandwidthPackage { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsBasicBandwidthPackage : TeaModel {
                /// <summary>
                /// <para>The bandwidth of the basic bandwidth plan. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The type of the bandwidth. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Basic</b>: standard acceleration bandwidth.</para>
                /// </description></item>
                /// <item><description><para><b>Enhanced</b>: enhanced acceleration bandwidth.</para>
                /// </description></item>
                /// <item><description><para><b>Advanced</b>: premium acceleration bandwidth.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Basic</para>
                /// </summary>
                [NameInMap("BandwidthType")]
                [Validation(Required=false)]
                public string BandwidthType { get; set; }

                /// <summary>
                /// <para>The ID of the basic bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gbwp-bp1d8xk8bg139j0fw****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The Cloud Enterprise Network (CEN) instance that is bound to the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cen-hjfufhjfuwff****</para>
            /// </summary>
            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the Global Accelerator instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650643200</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The type of cross-border acceleration for the instance that uses the pay-by-data-transfer billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>bpgPro</b>: premium bandwidth for cross-border acceleration.</para>
            /// </description></item>
            /// <item><description><para><b>private</b>: &lt;props=&quot;china&quot;&gt;China Unicom leased line for cross-border acceleration.&lt;props=&quot;intl&quot;&gt;Leased line for cross-domain acceleration.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>bpgPro</para>
            /// </summary>
            [NameInMap("CrossBorderMode")]
            [Validation(Required=false)]
            public string CrossBorderMode { get; set; }

            /// <summary>
            /// <para>Indicates whether cross-border data transfer is enabled for the Global Accelerator instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Cross-border data transfer is enabled, which can accelerate data transfer across borders.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Cross-border data transfer is disabled, which cannot accelerate data transfer across borders.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CrossBorderStatus")]
            [Validation(Required=false)]
            public bool? CrossBorderStatus { get; set; }

            /// <summary>
            /// <para>The details of the cross-domain acceleration bandwidth plan that is associated with the Global Accelerator instance.</para>
            /// <para>This array is returned only by the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
            /// </summary>
            [NameInMap("CrossDomainBandwidthPackage")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsCrossDomainBandwidthPackage : TeaModel {
                /// <summary>
                /// <para>The bandwidth of the cross-domain acceleration bandwidth plan. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The ID of the cross-domain acceleration bandwidth plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gbwp-bp1d8xk8bg139j0fw****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

            /// <summary>
            /// <para>The list of Anti-DDoS Pro/Premium configurations.</para>
            /// </summary>
            [NameInMap("DdosConfigList")]
            [Validation(Required=false)]
            public List<ListAcceleratorsResponseBodyAcceleratorsDdosConfigList> DdosConfigList { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsDdosConfigList : TeaModel {
                /// <summary>
                /// <para>The ID of the Anti-DDoS Pro/Premium instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ddoscoo-cn-a8w4ekcb**</para>
                /// </summary>
                [NameInMap("DdosId")]
                [Validation(Required=false)]
                public string DdosId { get; set; }

                /// <summary>
                /// <para>The region ID of the Anti-DDoS Pro/Premium instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("DdosRegionId")]
                [Validation(Required=false)]
                public string DdosRegionId { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The ID of the Anti-DDoS Pro/Premium instance that is associated with the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-zz11vq7j****</para>
            /// </summary>
            [NameInMap("DdosId")]
            [Validation(Required=false)]
            [Obsolete]
            public string DdosId { get; set; }

            /// <summary>
            /// <para>The description of the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accelerator</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The canonical name (CNAME) assigned to the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp15u1i2hmtbk8c3i****.aliyunga0019.com</para>
            /// </summary>
            [NameInMap("DnsName")]
            [Validation(Required=false)]
            public string DnsName { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the Global Accelerator instance expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1653235200</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public long? ExpiredTime { get; set; }

            /// <summary>
            /// <para>The billing method of the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            /// <summary>
            /// <para>The configuration of the acceleration area.</para>
            /// </summary>
            [NameInMap("IpSetConfig")]
            [Validation(Required=false)]
            public ListAcceleratorsResponseBodyAcceleratorsIpSetConfig IpSetConfig { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsIpSetConfig : TeaModel {
                /// <summary>
                /// <para>The access mode of the acceleration area. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>UserDefine</b>: custom nearby access mode. You can select acceleration areas and regions based on your business needs. Global Accelerator provides a separate elastic IP address (EIP) for each acceleration region.</para>
                /// </description></item>
                /// <item><description><para><b>Anycast</b>: automatic nearby access mode. You do not need to configure an acceleration area. Global Accelerator provides an Anycast EIP for multiple regions across the globe. Users can connect to the nearest access point of the Alibaba Cloud network using the Anycast EIP.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UserDefine</para>
                /// </summary>
                [NameInMap("AccessMode")]
                [Validation(Required=false)]
                public string AccessMode { get; set; }

            }

            /// <summary>
            /// <para>The name of the Global Accelerator instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accelerator</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The region ID of the Global Accelerator instance. The value is set to <b>cn-hangzhou</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            [Obsolete]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekztkx4zwc****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The CNAME that is assigned to the Global Accelerator instance after it is associated with an Anti-DDoS Pro/Premium instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ga-bp1f609c76zg6zuna****-1.aliyunga0047.com</para>
            /// </summary>
            [NameInMap("SecondDnsName")]
            [Validation(Required=false)]
            public string SecondDnsName { get; set; }

            /// <summary>
            /// <para>The ID of the service that manages the instance.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ALB</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is a managed instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The instance is a managed instance.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The instance is not a managed instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The actions that you can perform on the managed instance.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is returned only when <b>ServiceManaged</b> is set to <b>True</b>.</para>
            /// </description></item>
            /// <item><description><para>When the instance is in a managed state, you have limited permissions to perform operations on the instance.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListAcceleratorsResponseBodyAcceleratorsServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsServiceManagedInfos : TeaModel {
                /// <summary>
                /// <para>The name of the action on the managed instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Create</b>: create an instance.</para>
                /// </description></item>
                /// <item><description><para><b>Update</b>: update the current instance.</para>
                /// </description></item>
                /// <item><description><para><b>Delete</b>: delete the current instance.</para>
                /// </description></item>
                /// <item><description><para><b>Associate</b>: associate the instance with other resources.</para>
                /// </description></item>
                /// <item><description><para><b>UserUnmanaged</b>: disassociate the instance from the service.</para>
                /// </description></item>
                /// <item><description><para><b>CreateChild</b>: create a child resource in the instance.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Update</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of the child resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Listener</b>: listener.</para>
                /// </description></item>
                /// <item><description><para><b>IpSet</b>: acceleration region.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointGroup</b>: endpoint group.</para>
                /// </description></item>
                /// <item><description><para><b>ForwardingRule</b>: forwarding rule.</para>
                /// </description></item>
                /// <item><description><para><b>Endpoint</b>: endpoint.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointGroupDestination</b>: protocol mapping of an endpoint group associated with a custom routing listener.</para>
                /// </description></item>
                /// <item><description><para><b>EndpointPolicy</b>: traffic policy of an endpoint associated with a custom routing listener.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only when <b>Action</b> is set to <b>CreateChild</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Listener</para>
                /// </summary>
                [NameInMap("ChildType")]
                [Validation(Required=false)]
                public string ChildType { get; set; }

                /// <summary>
                /// <para>Indicates whether the specified action is managed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: The specified action is managed, and you cannot perform the specified action on the managed instance.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: The specified action is not managed, and you can perform the specified action on the managed instance.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsManaged")]
                [Validation(Required=false)]
                public bool? IsManaged { get; set; }

            }

            /// <summary>
            /// <para>The instance type of the Global Accelerator instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Small I</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Small II</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Small III</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Medium I</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: Medium II</para>
            /// </description></item>
            /// <item><description><para><b>10</b>: Medium III</para>
            /// </description></item>
            /// <item><description><para><b>20</b>: Large I</para>
            /// </description></item>
            /// <item><description><para><b>30</b>: Large II</para>
            /// </description></item>
            /// <item><description><para><b>40</b>: Large III</para>
            /// </description></item>
            /// <item><description><para><b>50</b>: Large IV</para>
            /// </description></item>
            /// <item><description><para><b>60</b>: Large V</para>
            /// </description></item>
            /// <item><description><para><b>70</b>: Large VI</para>
            /// </description></item>
            /// <item><description><para><b>80</b>: Large VII</para>
            /// </description></item>
            /// <item><description><para><b>90</b>: Large VIII</para>
            /// </description></item>
            /// <item><description><para><b>100</b>: Extra Large I</para>
            /// </description></item>
            /// <item><description><para><b>200</b>: Extra Large II</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Currently, the Large III and higher instance types are available only to users on the whitelist. To use these instance types, contact your account manager.</para>
            /// </remarks>
            /// <para>Different instance types have different definitions. For more information, see <a href="https://help.aliyun.com/document_detail/153127.html">Instance types</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            /// <summary>
            /// <para>The state of the Global Accelerator instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>init</b>: The instance is being initialized.</para>
            /// </description></item>
            /// <item><description><para><b>active</b>: The instance is active.</para>
            /// </description></item>
            /// <item><description><para><b>configuring</b>: The instance is being configured.</para>
            /// </description></item>
            /// <item><description><para><b>binding</b>: The instance is being bound.</para>
            /// </description></item>
            /// <item><description><para><b>unbinding</b>: The instance is being unbound.</para>
            /// </description></item>
            /// <item><description><para><b>deleting</b>: The instance is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>finacialLocked</b>: The instance is locked due to an overdue payment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The tags of the resource.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListAcceleratorsResponseBodyAcceleratorsTags> Tags { get; set; }
            public class ListAcceleratorsResponseBodyAcceleratorsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tast-value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>This parameter is invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The upgrade status of the Global Accelerator instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>notUpgradable</b>: The instance does not need to be upgraded.</para>
            /// </description></item>
            /// <item><description><para><b>upgradable</b>: The instance can be upgraded to the latest version.</para>
            /// </description></item>
            /// <item><description><para><b>upgradeFailed</b>: The instance failed to be upgraded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>notUpgradable</para>
            /// </summary>
            [NameInMap("UpgradableStatus")]
            [Validation(Required=false)]
            public string UpgradableStatus { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
