// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth metering method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthPackage:</b> billed based on bandwidth plans.</description></item>
        /// <item><description><b>CDT</b>: billed based on data transfer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CDT</para>
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// <para>The details about the basic bandwidth plan that is associated with the GA instance.</para>
        /// </summary>
        [NameInMap("BasicBandwidthPackage")]
        [Validation(Required=false)]
        public DescribeAcceleratorResponseBodyBasicBandwidthPackage BasicBandwidthPackage { get; set; }
        public class DescribeAcceleratorResponseBodyBasicBandwidthPackage : TeaModel {
            /// <summary>
            /// <para>The bandwidth value of the basic bandwidth plan. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The type of the bandwidth that is provided by the basic bandwidth plan. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Basic</b>: basic</description></item>
            /// <item><description><b>Enhanced</b>: enhanced</description></item>
            /// <item><description><b>Advanced</b>: premium</description></item>
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
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance with which the GA instance is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-hjkduu767hc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the GA instance is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1650643200</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The type of cross-border acceleration. This parameter is returned for GA instances whose bandwidth metering method is pay-by-data-transfer (CDT).</para>
        /// <para>Only <b>bpgPro</b> may be returned, which indicates BGP (Multi-ISP) Pro lines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bpgPro</para>
        /// </summary>
        [NameInMap("CrossBorderMode")]
        [Validation(Required=false)]
        public string CrossBorderMode { get; set; }

        /// <summary>
        /// <para>Indicates whether cross-border acceleration is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossBorderStatus")]
        [Validation(Required=false)]
        public bool? CrossBorderStatus { get; set; }

        /// <summary>
        /// <para>The details about the cross-border acceleration bandwidth plan that is associated with the GA instance.</para>
        /// <para>This array is returned only for GA instances that are created on the international site (alibabacloud.com).</para>
        /// </summary>
        [NameInMap("CrossDomainBandwidthPackage")]
        [Validation(Required=false)]
        public DescribeAcceleratorResponseBodyCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
        public class DescribeAcceleratorResponseBodyCrossDomainBandwidthPackage : TeaModel {
            /// <summary>
            /// <para>The bandwidth that is provided by the cross-border acceleration bandwidth plan. Unit: Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The ID of the cross-border acceleration bandwidth plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gbwp-bp1d8xk8bg139j0fw****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether cross-border acceleration is enabled.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CrossPrivateState")]
        [Validation(Required=false)]
        public string CrossPrivateState { get; set; }

        [NameInMap("DdosConfigList")]
        [Validation(Required=false)]
        public List<DescribeAcceleratorResponseBodyDdosConfigList> DdosConfigList { get; set; }
        public class DescribeAcceleratorResponseBodyDdosConfigList : TeaModel {
            [NameInMap("DdosId")]
            [Validation(Required=false)]
            public string DdosId { get; set; }

            [NameInMap("DdosRegionId")]
            [Validation(Required=false)]
            public string DdosRegionId { get; set; }

        }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the Anti-DDoS Pro/Premium instance that is associated with the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-zz11vq7j****</para>
        /// </summary>
        [NameInMap("DdosId")]
        [Validation(Required=false)]
        [Obsolete]
        public string DdosId { get; set; }

        /// <summary>
        /// <para>The description of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Accelerator</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The canonical name (CNAME) that is assigned to the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp15u1i2hmtbk8c3i****.aliyunga0019.com</para>
        /// </summary>
        [NameInMap("DnsName")]
        [Validation(Required=false)]
        public string DnsName { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the GA instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1653235200</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// <para>The billing method of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The configurations of the acceleration area.</para>
        /// </summary>
        [NameInMap("IpSetConfig")]
        [Validation(Required=false)]
        public DescribeAcceleratorResponseBodyIpSetConfig IpSetConfig { get; set; }
        public class DescribeAcceleratorResponseBodyIpSetConfig : TeaModel {
            /// <summary>
            /// <para>The access mode of the acceleration area. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserDefine</b>: custom nearby access mode. You can select acceleration areas and regions based on your business requirements. GA allocates a separate elastic IP address (EIP) to each acceleration region.</description></item>
            /// <item><description><b>Anycast</b>: automatic nearby access mode. You do not need to specify an acceleration area. GA allocates an Anycast EIP to multiple regions across the globe. Users can connect to the nearest access point of the Alibaba Cloud global transmission network by sending requests to the Anycast EIP.</description></item>
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
        /// <para>The name of the GA instance.</para>
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
        /// <para>The region ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FEA0CF3-D3B9-43E5-A304-D217037876A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw2vwdbujqbq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The CNAME that is used to integrate the GA instance with the Anti-DDoS service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1f609c76zg6zuna****-1.aliyunga0047.com</para>
        /// </summary>
        [NameInMap("SecondDnsName")]
        [Validation(Required=false)]
        public string SecondDnsName { get; set; }

        /// <summary>
        /// <para>The ID of the service that manages the GA instance.</para>
        /// <remarks>
        /// <para> This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ALB</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the GA instance is managed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// <para>The actions that users can perform on the managed instance.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if the value of <b>ServiceManaged</b> is <b>true</b>.</para>
        /// </description></item>
        /// <item><description><para>Users can perform only specific actions on a managed instance.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeAcceleratorResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeAcceleratorResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// <para>The name of the action performed on the managed instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Create</b></description></item>
            /// <item><description><b>Update</b></description></item>
            /// <item><description><b>Delete</b></description></item>
            /// <item><description><b>Associate</b></description></item>
            /// <item><description><b>UserUnmanaged</b></description></item>
            /// <item><description><b>CreateChild</b></description></item>
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
            /// <item><description><b>Listener</b>: a listener.</description></item>
            /// <item><description><b>IpSet</b>: an acceleration region.</description></item>
            /// <item><description><b>EndpointGroup</b>: an endpoint group.</description></item>
            /// <item><description><b>ForwardingRule</b>: a forwarding rule.</description></item>
            /// <item><description><b>Endpoint</b>: an endpoint.</description></item>
            /// <item><description><b>EndpointGroupDestination</b>: a protocol mapping of an endpoint group associated with a custom routing listener.</description></item>
            /// <item><description><b>EndpointPolicy</b>: a traffic policy of an endpoint associated with a custom routing listener.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is returned only if the value of <b>Action</b> is <b>CreateChild</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Listener</para>
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// <para>Indicates whether the specified actions are managed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The specified actions are managed, and you cannot perform the specified actions on the managed instance.</description></item>
            /// <item><description><b>false</b>: The specified actions are not managed, and you can perform the specified actions on the managed instance.</description></item>
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
        /// <para>The specification of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Small Ⅰ</description></item>
        /// <item><description><b>2</b>: Small Ⅱ</description></item>
        /// <item><description><b>3</b>: Small Ⅲ</description></item>
        /// <item><description><b>5</b>: Medium Ⅰ</description></item>
        /// <item><description><b>8</b>: Medium Ⅱ</description></item>
        /// <item><description><b>10</b>: Medium Ⅲ</description></item>
        /// <item><description><b>20</b>: Large Ⅰ</description></item>
        /// <item><description><b>30</b>: Large Ⅱ</description></item>
        /// <item><description><b>40</b>: Large Ⅲ</description></item>
        /// <item><description><b>50</b>: Large Ⅳ</description></item>
        /// <item><description><b>60</b>: Large Ⅴ</description></item>
        /// <item><description><b>70</b>: Large Ⅵ</description></item>
        /// <item><description><b>80</b>: Large VⅡ</description></item>
        /// <item><description><b>90</b>: Large VⅢ</description></item>
        /// <item><description><b>100</b>: Super Large Ⅰ</description></item>
        /// <item><description><b>200</b>: Super Large Ⅱ</description></item>
        /// </list>
        /// <remarks>
        /// <para> The Large Ⅲ specification and higher specifications are available only to users that are added to the whitelist. To use these specifications, contact your Alibaba Cloud account manager.</para>
        /// </remarks>
        /// <para>Different specifications provide different capabilities. For more information, see <a href="https://help.aliyun.com/document_detail/153127.html">Instance specifications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The status of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>init</b>: The GA instance is being initialized.</description></item>
        /// <item><description><b>active</b>: The GA instance is available.</description></item>
        /// <item><description><b>configuring</b>: The GA instance is being configured.</description></item>
        /// <item><description><b>binding</b>: The GA instance is being associated.</description></item>
        /// <item><description><b>unbinding</b>: The GA instance is being disassociated.</description></item>
        /// <item><description><b>deleting</b>: The GA instance is being deleted.</description></item>
        /// <item><description><b>finacialLocked</b>: The GA instance is locked due to overdue payments.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The tags of the GA instance.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeAcceleratorResponseBodyTags> Tags { get; set; }
        public class DescribeAcceleratorResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The key of tag N that is added to the GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N that is added to the GA instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the GA instance can be upgraded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>notUpgradable:</b> The GA instance does not need to be upgraded.</description></item>
        /// <item><description><b>upgradable:</b> The GA instance can be upgraded to the latest version.</description></item>
        /// <item><description><b>upgradeFailed:</b> The GA instance failed to be upgraded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>notUpgradable</para>
        /// </summary>
        [NameInMap("UpgradableStatus")]
        [Validation(Required=false)]
        public string UpgradableStatus { get; set; }

    }

}
