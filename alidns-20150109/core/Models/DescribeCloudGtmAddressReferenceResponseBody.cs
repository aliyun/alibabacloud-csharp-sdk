// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmAddressReferenceResponseBody : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("AddressId")]
        [Validation(Required=false)]
        public string AddressId { get; set; }

        [NameInMap("AddressPools")]
        [Validation(Required=false)]
        public DescribeCloudGtmAddressReferenceResponseBodyAddressPools AddressPools { get; set; }
        public class DescribeCloudGtmAddressReferenceResponseBodyAddressPools : TeaModel {
            [NameInMap("AddressPool")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPool> AddressPool { get; set; }
            public class DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPool : TeaModel {
                [NameInMap("AddressLbStrategy")]
                [Validation(Required=false)]
                public string AddressLbStrategy { get; set; }

                [NameInMap("AddressPoolId")]
                [Validation(Required=false)]
                public string AddressPoolId { get; set; }

                [NameInMap("AddressPoolName")]
                [Validation(Required=false)]
                public string AddressPoolName { get; set; }

                [NameInMap("AddressPoolType")]
                [Validation(Required=false)]
                public string AddressPoolType { get; set; }

                [NameInMap("AvailableStatus")]
                [Validation(Required=false)]
                public string AvailableStatus { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                [NameInMap("HealthJudgement")]
                [Validation(Required=false)]
                public string HealthJudgement { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("InstanceConfigs")]
                [Validation(Required=false)]
                public DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigs InstanceConfigs { get; set; }
                public class DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigs : TeaModel {
                    [NameInMap("InstanceConfig")]
                    [Validation(Required=false)]
                    public List<DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigsInstanceConfig> InstanceConfig { get; set; }
                    public class DescribeCloudGtmAddressReferenceResponseBodyAddressPoolsAddressPoolInstanceConfigsInstanceConfig : TeaModel {
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

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SequenceLbStrategyMode")]
                [Validation(Required=false)]
                public string SequenceLbStrategyMode { get; set; }

            }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
