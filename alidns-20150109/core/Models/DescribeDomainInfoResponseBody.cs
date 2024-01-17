// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainInfoResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the domain name was registered in Alibaba Cloud.
        /// </summary>
        [NameInMap("AliDomain")]
        [Validation(Required=false)]
        public bool? AliDomain { get; set; }

        /// <summary>
        /// The available time to live (TTL) values that can be configured for the domain name. Available TTL values are not returned by default. If you want to query such information, set NeedDetailAttributes to true.
        /// </summary>
        [NameInMap("AvailableTtls")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyAvailableTtls AvailableTtls { get; set; }
        public class DescribeDomainInfoResponseBodyAvailableTtls : TeaModel {
            [NameInMap("AvailableTtl")]
            [Validation(Required=false)]
            public List<string> AvailableTtl { get; set; }

        }

        /// <summary>
        /// The time when the domain name was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The DNS servers that are used to resolve the domain name.
        /// </summary>
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyDnsServers DnsServers { get; set; }
        public class DescribeDomainInfoResponseBodyDnsServers : TeaModel {
            [NameInMap("DnsServer")]
            [Validation(Required=false)]
            public List<string> DnsServer { get; set; }

        }

        /// <summary>
        /// The ID of the domain name.
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("DomainLoggingSwitchStatus")]
        [Validation(Required=false)]
        public string DomainLoggingSwitchStatus { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The ID of the domain name group.
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the domain name group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Indicates whether blackhole filtering was triggered.
        /// </summary>
        [NameInMap("InBlackHole")]
        [Validation(Required=false)]
        public bool? InBlackHole { get; set; }

        /// <summary>
        /// Indicates whether traffic scrubbing was in progress.
        /// </summary>
        [NameInMap("InClean")]
        [Validation(Required=false)]
        public bool? InClean { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud DNS instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the DNS request line.
        /// </summary>
        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

        /// <summary>
        /// The minimum TTL value.
        /// </summary>
        [NameInMap("MinTtl")]
        [Validation(Required=false)]
        public long? MinTtl { get; set; }

        /// <summary>
        /// The Punycode for the domain name. This parameter is returned only for Chinese domain names.
        /// </summary>
        [NameInMap("PunyCode")]
        [Validation(Required=false)]
        public string PunyCode { get; set; }

        /// <summary>
        /// The tree-structure DNS request lines.
        /// </summary>
        [NameInMap("RecordLineTreeJson")]
        [Validation(Required=false)]
        public string RecordLineTreeJson { get; set; }

        /// <summary>
        /// The DNS request lines.
        /// </summary>
        [NameInMap("RecordLines")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyRecordLines RecordLines { get; set; }
        public class DescribeDomainInfoResponseBodyRecordLines : TeaModel {
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public List<DescribeDomainInfoResponseBodyRecordLinesRecordLine> RecordLine { get; set; }
            public class DescribeDomainInfoResponseBodyRecordLinesRecordLine : TeaModel {
                /// <summary>
                /// The code of the parent line. This parameter is left empty if the line has no parent line.
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// The code of the line.
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// The name of the parent line.
                /// </summary>
                [NameInMap("LineDisplayName")]
                [Validation(Required=false)]
                public string LineDisplayName { get; set; }

                /// <summary>
                /// The name of the line.
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the DNS request lines are regional lines.
        /// </summary>
        [NameInMap("RegionLines")]
        [Validation(Required=false)]
        public bool? RegionLines { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Indicates whether secondary DNS is supported.
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public bool? SlaveDns { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public bool? SubDomain { get; set; }

        /// <summary>
        /// The version ID of Alibaba Cloud DNS.
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        /// <summary>
        /// The edition of Alibaba Cloud DNS.
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
