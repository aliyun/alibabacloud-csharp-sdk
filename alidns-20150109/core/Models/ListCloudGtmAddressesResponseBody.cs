// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmAddressesResponseBody : TeaModel {
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public ListCloudGtmAddressesResponseBodyAddresses Addresses { get; set; }
        public class ListCloudGtmAddressesResponseBodyAddresses : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<ListCloudGtmAddressesResponseBodyAddressesAddress> Address { get; set; }
            public class ListCloudGtmAddressesResponseBodyAddressesAddress : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("AddressId")]
                [Validation(Required=false)]
                public string AddressId { get; set; }

                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public string AttributeInfo { get; set; }

                [NameInMap("AvailableMode")]
                [Validation(Required=false)]
                public string AvailableMode { get; set; }

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

                [NameInMap("HealthTasks")]
                [Validation(Required=false)]
                public ListCloudGtmAddressesResponseBodyAddressesAddressHealthTasks HealthTasks { get; set; }
                public class ListCloudGtmAddressesResponseBodyAddressesAddressHealthTasks : TeaModel {
                    [NameInMap("HealthTask")]
                    [Validation(Required=false)]
                    public List<ListCloudGtmAddressesResponseBodyAddressesAddressHealthTasksHealthTask> HealthTask { get; set; }
                    public class ListCloudGtmAddressesResponseBodyAddressesAddressHealthTasksHealthTask : TeaModel {
                        [NameInMap("MonitorStatus")]
                        [Validation(Required=false)]
                        public string MonitorStatus { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        [NameInMap("TemplateName")]
                        [Validation(Required=false)]
                        public string TemplateName { get; set; }

                    }

                }

                [NameInMap("ManualAvailableStatus")]
                [Validation(Required=false)]
                public string ManualAvailableStatus { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

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
