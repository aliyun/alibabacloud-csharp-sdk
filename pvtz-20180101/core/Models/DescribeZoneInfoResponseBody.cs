// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneInfoResponseBody : TeaModel {
        [NameInMap("BindEdgeDnsClusters")]
        [Validation(Required=false)]
        public DescribeZoneInfoResponseBodyBindEdgeDnsClusters BindEdgeDnsClusters { get; set; }
        public class DescribeZoneInfoResponseBodyBindEdgeDnsClusters : TeaModel {
            [NameInMap("EdgeDnsCluster")]
            [Validation(Required=false)]
            public List<DescribeZoneInfoResponseBodyBindEdgeDnsClustersEdgeDnsCluster> EdgeDnsCluster { get; set; }
            public class DescribeZoneInfoResponseBodyBindEdgeDnsClustersEdgeDnsCluster : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("ClusterUserId")]
                [Validation(Required=false)]
                public long? ClusterUserId { get; set; }

            }

        }

        [NameInMap("BindVpcs")]
        [Validation(Required=false)]
        public DescribeZoneInfoResponseBodyBindVpcs BindVpcs { get; set; }
        public class DescribeZoneInfoResponseBodyBindVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeZoneInfoResponseBodyBindVpcsVpc> Vpc { get; set; }
            public class DescribeZoneInfoResponseBodyBindVpcsVpc : TeaModel {
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

                [NameInMap("VpcType")]
                [Validation(Required=false)]
                public string VpcType { get; set; }

                [NameInMap("VpcUserId")]
                [Validation(Required=false)]
                public long? VpcUserId { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the zone was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-15T09:40Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the zone was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721036404000</para>
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
        /// <para>The DNS group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NORMAL_ZONE</b>: Regular group</para>
        /// </description></item>
        /// <item><description><para><b>FAST_ZONE</b>: Fast group</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAST_ZONE</para>
        /// </summary>
        [NameInMap("DnsGroup")]
        [Validation(Required=false)]
        public string DnsGroup { get; set; }

        /// <summary>
        /// <para>The status of switching the DNS group for the zone. You can switch a zone between the regular and fast groups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The DNS group is being switched.</para>
        /// </description></item>
        /// <item><description><para>false: The DNS group is not being switched.</para>
        /// </description></item>
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
        /// <item><description><para>true: The zone is a reverse lookup zone.</para>
        /// </description></item>
        /// <item><description><para>false: The zone is not a reverse lookup zone.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsPtr")]
        [Validation(Required=false)]
        public bool? IsPtr { get; set; }

        /// <summary>
        /// <para>Indicates whether the recursive proxy for subdomains is enabled.</para>
        /// <list type="bullet">
        /// <item><description><para>ZONE: Disabled. If a non-existent subdomain is resolved, an NXDOMAIN response is returned to indicate that the subdomain does not exist.</para>
        /// </description></item>
        /// <item><description><para>RECORD: Enabled. If a non-existent subdomain is resolved, the system queries the forwarding and recursion modules in sequence and uses the final result to respond to the DNS query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ZONE</para>
        /// </summary>
        [NameInMap("ProxyPattern")]
        [Validation(Required=false)]
        public string ProxyPattern { get; set; }

        /// <summary>
        /// <para>The total number of DNS records in the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RecordCount")]
        [Validation(Required=false)]
        public int? RecordCount { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
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
        /// <para>Indicates whether secondary DNS is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public bool? SlaveDns { get; set; }

        /// <summary>
        /// <para>The time when the zone was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-22T09:39Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the zone was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721641148000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The unique ID of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df2d03865266bd9842306db586d3****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The name of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zone-test.cn</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

        /// <summary>
        /// <para>The tag of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pvtz</para>
        /// </summary>
        [NameInMap("ZoneTag")]
        [Validation(Required=false)]
        public string ZoneTag { get; set; }

        /// <summary>
        /// <para>The type of the zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AUTH_ZONE</b>: Authoritative zone.</para>
        /// </description></item>
        /// <item><description><para><b>CLOUD_PRODUCT_ZONE</b>: Authoritative zone for a cloud product.</para>
        /// </description></item>
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
