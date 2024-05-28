// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmAddressPoolReferenceResponseBody : TeaModel {
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        [NameInMap("AddressPoolName")]
        [Validation(Required=false)]
        public string AddressPoolName { get; set; }

        [NameInMap("InstanceConfigs")]
        [Validation(Required=false)]
        public DescribeCloudGtmAddressPoolReferenceResponseBodyInstanceConfigs InstanceConfigs { get; set; }
        public class DescribeCloudGtmAddressPoolReferenceResponseBodyInstanceConfigs : TeaModel {
            [NameInMap("InstanceConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmAddressPoolReferenceResponseBodyInstanceConfigsInstanceConfig> InstanceConfig { get; set; }
            public class DescribeCloudGtmAddressPoolReferenceResponseBodyInstanceConfigsInstanceConfig : TeaModel {
                [NameInMap("AddressPoolLbStrategy")]
                [Validation(Required=false)]
                public string AddressPoolLbStrategy { get; set; }

                [NameInMap("AvailableStatus")]
                [Validation(Required=false)]
                public string AvailableStatus { get; set; }

                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ScheduleDomainName")]
                [Validation(Required=false)]
                public string ScheduleDomainName { get; set; }

                [NameInMap("ScheduleHostname")]
                [Validation(Required=false)]
                public string ScheduleHostname { get; set; }

                [NameInMap("ScheduleRrType")]
                [Validation(Required=false)]
                public string ScheduleRrType { get; set; }

                [NameInMap("ScheduleZoneName")]
                [Validation(Required=false)]
                public string ScheduleZoneName { get; set; }

                [NameInMap("SequenceLbStrategyMode")]
                [Validation(Required=false)]
                public string SequenceLbStrategyMode { get; set; }

                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
