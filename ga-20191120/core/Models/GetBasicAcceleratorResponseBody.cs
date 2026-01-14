// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the basic GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The bandwidth metering method.</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthPackage</b>: billed based on bandwidth plans.</description></item>
        /// <item><description><b>CDT</b>: billed by Cloud Data Transfer (CDT) and based on data transfer.</description></item>
        /// <item><description><b>CDT95</b>: billed by CDT and based on the 95th percentile bandwidth. This bandwidth metering method is available only to users that are included in the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CDT</para>
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// <para>The details about the basic bandwidth plan that is associated with the basic GA instance.</para>
        /// </summary>
        [NameInMap("BasicBandwidthPackage")]
        [Validation(Required=false)]
        public GetBasicAcceleratorResponseBodyBasicBandwidthPackage BasicBandwidthPackage { get; set; }
        public class GetBasicAcceleratorResponseBodyBasicBandwidthPackage : TeaModel {
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
            /// <para>The type of the bandwidth that is provided by the basic bandwidth plan.</para>
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
        /// <para>The ID of the endpoint group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-bp1dmlohjjz4kqaun****</para>
        /// </summary>
        [NameInMap("BasicEndpointGroupId")]
        [Validation(Required=false)]
        public string BasicEndpointGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the acceleration region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ips-bp11ilwqjdkjeg9r7****</para>
        /// </summary>
        [NameInMap("BasicIpSetId")]
        [Validation(Required=false)]
        public string BasicIpSetId { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud Enterprise Network (CEN) instance to which the basic GA instance is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-hjkduu767hc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the basic GA instance is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1637734547</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether cross-border acceleration is enabled for the basic GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
        public GetBasicAcceleratorResponseBodyCrossDomainBandwidthPackage CrossDomainBandwidthPackage { get; set; }
        public class GetBasicAcceleratorResponseBodyCrossDomainBandwidthPackage : TeaModel {
            /// <summary>
            /// <para>The bandwidth value of the cross-border acceleration bandwidth plan. Unit: Mbit/s.</para>
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

        /// <summary>
        /// <para>The description of the basic GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BasicAccelerator</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the basic GA instance expires.</para>
        /// <para>The time follows the UNIX time format. It is the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640326547</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// <para>The billing method of the basic GA instance. Only <b>PREPAY</b> is returned, which indicates the subscription billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The name of the basic GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BasicAccelerator</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region where the basic GA instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F591955F-5CB5-4CCE-A75D-17CF2085CE22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the basic GA instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzrnd67gq****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the basic GA instance.</para>
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
        /// <para>The tags of the basic GA instance.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetBasicAcceleratorResponseBodyTags> Tags { get; set; }
        public class GetBasicAcceleratorResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
