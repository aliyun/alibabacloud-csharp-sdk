// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeZoneInfoResponseBody : TeaModel {
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

                /// <summary>
                /// Vpc ID。
                /// </summary>
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

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("CreatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public bool? SlaveDns { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// Zone ID。
        /// </summary>
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
