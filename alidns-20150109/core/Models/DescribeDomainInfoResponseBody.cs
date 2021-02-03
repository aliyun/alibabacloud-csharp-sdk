// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainInfoResponseBody : TeaModel {
        [NameInMap("RecordLineTreeJson")]
        [Validation(Required=false)]
        public string RecordLineTreeJson { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("InBlackHole")]
        [Validation(Required=false)]
        public bool? InBlackHole { get; set; }

        [NameInMap("RegionLines")]
        [Validation(Required=false)]
        public bool? RegionLines { get; set; }

        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public bool? SlaveDns { get; set; }

        [NameInMap("AliDomain")]
        [Validation(Required=false)]
        public bool? AliDomain { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("PunyCode")]
        [Validation(Required=false)]
        public string PunyCode { get; set; }

        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyDnsServers DnsServers { get; set; }
        public class DescribeDomainInfoResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }
        };

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        [NameInMap("RecordLines")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyRecordLines RecordLines { get; set; }
        public class DescribeDomainInfoResponseBodyRecordLines : TeaModel {
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public List<DescribeDomainInfoResponseBodyRecordLinesRecordLine> RecordLine { get; set; }
            public class DescribeDomainInfoResponseBodyRecordLinesRecordLine : TeaModel {
                public string FatherCode { get; set; }
                public string LineDisplayName { get; set; }
                public string LineCode { get; set; }
                public string LineName { get; set; }
            }
        };

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("AvailableTtls")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyAvailableTtls AvailableTtls { get; set; }
        public class DescribeDomainInfoResponseBodyAvailableTtls : TeaModel {
            [NameInMap("AvailableTtl")]
            [Validation(Required=false)]
            public List<string> AvailableTtl { get; set; }
        };

        [NameInMap("MinTtl")]
        [Validation(Required=false)]
        public long? MinTtl { get; set; }

        [NameInMap("InClean")]
        [Validation(Required=false)]
        public bool? InClean { get; set; }

        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

    }

}
