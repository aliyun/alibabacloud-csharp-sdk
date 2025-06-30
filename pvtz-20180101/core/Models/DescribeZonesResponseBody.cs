// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZonesResponseBody : TeaModel {
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// <para>The zones.</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                /// <summary>
                /// <para>The time when the zone was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the zone was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1514466483000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The creator of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>546356****</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The account type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CUSTOMER</b>: Alibaba Cloud account</description></item>
                /// <item><description><b>SUB</b>: RAM user</description></item>
                /// <item><description><b>STS</b>: assumed role that obtains the Security Token Service (STS) token of a RAM role</description></item>
                /// <item><description><b>OTHER</b>: other types</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUB</para>
                /// </summary>
                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                /// <summary>
                /// <para>The logical location type of the built-in authoritative module in which the zone is added. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NORMAL_ZONE</b>: regular module</description></item>
                /// <item><description><b>FAST_ZONE</b>: acceleration module</description></item>
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
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
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
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsPtr")]
                [Validation(Required=false)]
                public bool? IsPtr { get; set; }

                /// <summary>
                /// <para>Indicates whether the recursive resolution proxy for subdomain names is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ZONE</b>: The recursive resolution proxy for subdomain names is disabled. In this case, NXDOMAIN is returned if the queried domain name does not exist in the zone.</description></item>
                /// <item><description><b>RECORD</b>: The recursive resolution proxy for subdomain names is enabled. In this case, if the queried domain name does not exist in the zone, DNS requests are recursively forwarded to the forward module and then to the recursion module until DNS results are returned.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ZONE</para>
                /// </summary>
                [NameInMap("ProxyPattern")]
                [Validation(Required=false)]
                public string ProxyPattern { get; set; }

                /// <summary>
                /// <para>The number of Domain Name System (DNS) records added in the zone.</para>
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
                /// <para>The ID of the resource group to which the zone belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekz2qj7awz****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags added to the zone.</para>
                /// </summary>
                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneResourceTags ResourceTags { get; set; }
                public class DescribeZonesResponseBodyZonesZoneResourceTags : TeaModel {
                    [NameInMap("ResourceTag")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneResourceTagsResourceTag> ResourceTag { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneResourceTagsResourceTag : TeaModel {
                        /// <summary>
                        /// <para>The key of tag N added to the zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>env</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N added to the zone.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>daily</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("SlaveDnsStatus")]
                [Validation(Required=false)]
                public string SlaveDnsStatus { get; set; }

                /// <summary>
                /// <para>The time when the zone was last modified. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-03T08:57Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The time when the DNS record was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since 00:00:00 UTC on January 1, 1970.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1514969843000</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>The zone ID. This ID uniquely identifies the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6d83e3b31aa60ca4aaa7161f1b6b**95</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The name of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.com</para>
                /// </summary>
                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

                /// <summary>
                /// <para>The type of the cloud service. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>If ZoneType is set to AUTH_ZONE, no value is returned for this parameter.</description></item>
                /// <item><description>If ZoneType is set to CLOUD_PRODUCT_ZONE, the type of the cloud service is returned.</description></item>
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

    }

}
