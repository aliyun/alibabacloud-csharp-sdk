// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The VPCs associated with the zone.</para>
        /// </summary>
        [NameInMap("BindVpcs")]
        [Validation(Required=false)]
        public DescribeZoneInfoResponseBodyBindVpcs BindVpcs { get; set; }
        public class DescribeZoneInfoResponseBodyBindVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeZoneInfoResponseBodyBindVpcsVpc> Vpc { get; set; }
            public class DescribeZoneInfoResponseBodyBindVpcsVpc : TeaModel {
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
                /// <para>The name of the region where the VPC resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China (Heyuan)</para>
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// <para>The VPC ID. This ID uniquely identifies the VPC.</para>
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
                /// <para>vpc_test</para>
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

                /// <summary>
                /// <para>The user ID to which the VPC belongs. If null is returned, the VPC belongs to the current user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>141339776561****</para>
                /// </summary>
                [NameInMap("VpcUserId")]
                [Validation(Required=false)]
                public long? VpcUserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the zone was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-23T03:15Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the zone was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516775741000</para>
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
        /// <para>The type of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("CreatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

        /// <summary>
        /// <para>The logical location type of the built-in authoritative module in which the zone is added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL_ZONE</b>: regular module</description></item>
        /// <item><description><b>FAST_ZONE</b>: acceleration module</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAST_ZONE</para>
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
        /// <para>false</para>
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
        /// <para>Indicates whether the recursive resolution proxy for subdomain names is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ZONE: The recursive resolution proxy for subdomain names is disabled. In this case, NXDOMAIN is returned if the queried domain name does not exist in the zone.</description></item>
        /// <item><description>RECORD: The recursive resolution proxy for subdomain names is enabled. In this case, if the queried domain name does not exist in the zone, DNS requests are recursively forwarded to the forward module and then to the recursion module until DNS results are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZONE</para>
        /// </summary>
        [NameInMap("ProxyPattern")]
        [Validation(Required=false)]
        public string ProxyPattern { get; set; }

        /// <summary>
        /// <para>The total number of DNS records added in the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecordCount")]
        [Validation(Required=false)]
        public int? RecordCount { get; set; }

        /// <summary>
        /// <para>The description of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F73F41A3-B6DD-42CA-A793-FFF93277835D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the zone belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmykd63gt****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the secondary Domain Name System (DNS) feature is enabled for the zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The secondary DNS feature is enabled.</description></item>
        /// <item><description><b>false</b>: The secondary DNS feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public bool? SlaveDns { get; set; }

        /// <summary>
        /// <para>The time when the zone was last updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-24T06:35Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the zone was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1516775741000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The zone ID. This ID uniquely identifies the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df2d03865266bd9842306db586d3****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zone-test.cn</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

        /// <summary>
        /// <para>The tag added to the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pvtz</para>
        /// </summary>
        [NameInMap("ZoneTag")]
        [Validation(Required=false)]
        public string ZoneTag { get; set; }

        /// <summary>
        /// <para>The zone type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AUTH_ZONE</b>: authoritative zone</description></item>
        /// <item><description><b>CLOUD_PRODUCT_ZONE</b>: authoritative zone for cloud services</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CLOUD_PRODUCT_ZONE</para>
        /// </summary>
        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
