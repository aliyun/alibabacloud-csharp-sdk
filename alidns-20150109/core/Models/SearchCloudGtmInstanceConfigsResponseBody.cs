// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmInstanceConfigsResponseBody : TeaModel {
        [NameInMap("InstanceConfigs")]
        [Validation(Required=false)]
        public SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigs InstanceConfigs { get; set; }
        public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigs : TeaModel {
            [NameInMap("InstanceConfig")]
            [Validation(Required=false)]
            public List<SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfig> InstanceConfig { get; set; }
            public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfig : TeaModel {
                [NameInMap("AddressPoolLbStrategy")]
                [Validation(Required=false)]
                public string AddressPoolLbStrategy { get; set; }

                [NameInMap("AddressPools")]
                [Validation(Required=false)]
                public SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPools AddressPools { get; set; }
                public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPools : TeaModel {
                    [NameInMap("AddressPool")]
                    [Validation(Required=false)]
                    public List<SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPool> AddressPool { get; set; }
                    public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPool : TeaModel {
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

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("CreateTimestamp")]
                        [Validation(Required=false)]
                        public long? CreateTimestamp { get; set; }

                        [NameInMap("EnableStatus")]
                        [Validation(Required=false)]
                        public string EnableStatus { get; set; }

                        [NameInMap("HealthJudgement")]
                        [Validation(Required=false)]
                        public string HealthJudgement { get; set; }

                        [NameInMap("HealthStatus")]
                        [Validation(Required=false)]
                        public string HealthStatus { get; set; }

                        [NameInMap("RequestSource")]
                        [Validation(Required=false)]
                        public SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPoolRequestSource RequestSource { get; set; }
                        public class SearchCloudGtmInstanceConfigsResponseBodyInstanceConfigsInstanceConfigAddressPoolsAddressPoolRequestSource : TeaModel {
                            [NameInMap("RequestSource")]
                            [Validation(Required=false)]
                            public List<string> RequestSource { get; set; }

                        }

                        [NameInMap("SeqNonPreemptiveSchedule")]
                        [Validation(Required=false)]
                        public bool? SeqNonPreemptiveSchedule { get; set; }

                        [NameInMap("SequenceLbStrategyMode")]
                        [Validation(Required=false)]
                        public string SequenceLbStrategyMode { get; set; }

                        [NameInMap("SerialNumber")]
                        [Validation(Required=false)]
                        public int? SerialNumber { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                        [NameInMap("UpdateTimestamp")]
                        [Validation(Required=false)]
                        public long? UpdateTimestamp { get; set; }

                        [NameInMap("WeightValue")]
                        [Validation(Required=false)]
                        public int? WeightValue { get; set; }

                    }

                }

                [NameInMap("AvailableStatus")]
                [Validation(Required=false)]
                public string AvailableStatus { get; set; }

                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("EnableStatus")]
                [Validation(Required=false)]
                public string EnableStatus { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

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

                [NameInMap("ScheduleZoneMode")]
                [Validation(Required=false)]
                public string ScheduleZoneMode { get; set; }

                [NameInMap("ScheduleZoneName")]
                [Validation(Required=false)]
                public string ScheduleZoneName { get; set; }

                [NameInMap("SequenceLbStrategyMode")]
                [Validation(Required=false)]
                public string SequenceLbStrategyMode { get; set; }

                [NameInMap("Ttl")]
                [Validation(Required=false)]
                public int? Ttl { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
