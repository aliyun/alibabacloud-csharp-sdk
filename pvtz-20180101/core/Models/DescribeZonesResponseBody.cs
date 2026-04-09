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

        [NameInMap("Zones")]
        [Validation(Required=false)]
        public DescribeZonesResponseBodyZones Zones { get; set; }
        public class DescribeZonesResponseBodyZones : TeaModel {
            [NameInMap("Zone")]
            [Validation(Required=false)]
            public List<DescribeZonesResponseBodyZonesZone> Zone { get; set; }
            public class DescribeZonesResponseBodyZonesZone : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                [NameInMap("DnsGroup")]
                [Validation(Required=false)]
                public string DnsGroup { get; set; }

                [NameInMap("DnsGroupChanging")]
                [Validation(Required=false)]
                public bool? DnsGroupChanging { get; set; }

                [NameInMap("IsPtr")]
                [Validation(Required=false)]
                public bool? IsPtr { get; set; }

                [NameInMap("ProxyPattern")]
                [Validation(Required=false)]
                public string ProxyPattern { get; set; }

                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public int? RecordCount { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("ResourceTags")]
                [Validation(Required=false)]
                public DescribeZonesResponseBodyZonesZoneResourceTags ResourceTags { get; set; }
                public class DescribeZonesResponseBodyZonesZoneResourceTags : TeaModel {
                    [NameInMap("ResourceTag")]
                    [Validation(Required=false)]
                    public List<DescribeZonesResponseBodyZonesZoneResourceTagsResourceTag> ResourceTag { get; set; }
                    public class DescribeZonesResponseBodyZonesZoneResourceTagsResourceTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("SlaveDnsStatus")]
                [Validation(Required=false)]
                public string SlaveDnsStatus { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneName")]
                [Validation(Required=false)]
                public string ZoneName { get; set; }

                [NameInMap("ZoneTag")]
                [Validation(Required=false)]
                public string ZoneTag { get; set; }

                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

    }

}
