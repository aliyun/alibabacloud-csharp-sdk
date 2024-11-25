// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneVpcTreeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B07FBC3-3A53-4939-A3C6-2BDFE407BAB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZoneVpcTreeResponseBodyZones Zones { get; set; }
        public class DescribeZoneVpcTreeResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZoneVpcTreeResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZoneVpcTreeResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// <para>The time when the zone was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-18T08:20Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the zone was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568794812000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The creator of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141339776561****</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The operator type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>USER</para>
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                /// <summary>
                /// <para>The logical location of the built-in authoritative module in which the zone is added. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL_ZONE: regular module</description></item>
                /// <item><description>FAST_ZONE: acceleration module</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL_ZONE</para>
                /// </summary>
                [NameInMap("DnsGroup")]
                [Validation(Required=false)]
                public string DnsGroup { get; set; }

                /// <summary>
                /// <para>Indicates whether the zone is being removed to another logical location. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DnsGroupChanging")]
                [Validation(Required=false)]
                public bool? DnsGroupChanging { get; set; }

                /// <summary>
                /// <para>Indicates whether the zone is a reverse lookup zone. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsPtr")]
                [Validation(Required=false)]
                public bool? IsPtr { get; set; }

                /// <summary>
                /// <para>The number of Domain Name System (DNS) records added for the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public int? RecordCount { get; set; }

                /// <summary>
                /// <para>The description of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The time when the zone was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-18T08:20Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The time when the zone was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568794834000</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>The VPCs associated with the zone.</para>
                /// </summary>
                [NameInMap("Vpcs")]
                [Validation(Required=false)]
                public DescribeZoneVpcTreeResponseBodyZonesZoneVpcs Vpcs { get; set; }
                public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcs : TeaModel {
                    [NameInMap("Vpc")]
                    [Validation(Required=false)]
                    public List<DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc> Vpc { get; set; }
                    public class DescribeZoneVpcTreeResponseBodyZonesZoneVpcsVpc : TeaModel {
                        /// <summary>
                        /// <para>The region ID of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-heyuan</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The name of the region to which the VPC belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>China (Heyuan)</para>
                        /// </summary>
                        [NameInMap("RegionName")]
                        [Validation(Required=false)]
                        public string RegionName { get; set; }

                        /// <summary>
                        /// <para>The VPC ID. The unique ID of the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-f8zvrvr1payllgz38****</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                        /// <summary>
                        /// <para>The VPC name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo-vpc</para>
                        /// </summary>
                        [NameInMap("VpcName")]
                        [Validation(Required=false)]
                        public string VpcName { get; set; }

                        /// <summary>
                        /// <para>The VPC type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>STANDARD: standard VPC</description></item>
                        /// <item><description>EDS: Elastic Desktop Service (EDS) workspace VPC</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>STANDARD</para>
                        /// </summary>
                        [NameInMap("VpcType")]
                        [Validation(Required=false)]
                        public string VpcType { get; set; }

                    }

                }

                /// <summary>
                /// <para>The zone ID. This ID uniquely identifies the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6d83e3b31aa60ca4aaa7161f1b6baa95</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The zone name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

                /// <summary>
                /// <para>The type of the cloud service.</para>
                /// <para><b>Valid values:</b></para>
                /// <list type="bullet">
                /// <item><description><para>If ZoneType is set to AUTH_ZONE, no value is returned for this parameter.</para>
                /// </description></item>
                /// <item><description><para>If ZoneType is set to CLOUD_PRODUCT_ZONE, the type of the cloud service is returned.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>BLINK</para>
                /// </summary>
                [NameInMap("ZoneTag")]
                [Validation(Required=false)]
                public string ZoneTag { get; set; }

                /// <summary>
                /// <para>The zone type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>AUTH_ZONE: authoritative zone</description></item>
                /// <item><description>CLOUD_PRODUCT_ZONE: authoritative zone for cloud services</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AUTH_ZONE</para>
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
