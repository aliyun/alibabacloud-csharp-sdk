// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public SearchCloudGtmInstancesResponseBodyInstances Instances { get; set; }
        public class SearchCloudGtmInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<SearchCloudGtmInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class SearchCloudGtmInstancesResponseBodyInstancesInstance : TeaModel {
                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("ExpireTimestamp")]
                [Validation(Required=false)]
                public string ExpireTimestamp { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("MonitorTaskQuota")]
                [Validation(Required=false)]
                public int? MonitorTaskQuota { get; set; }

                [NameInMap("MonthlyEmailUsed")]
                [Validation(Required=false)]
                public int? MonthlyEmailUsed { get; set; }

                [NameInMap("MonthlySmsQuota")]
                [Validation(Required=false)]
                public int? MonthlySmsQuota { get; set; }

                [NameInMap("MonthlySmsUsed")]
                [Validation(Required=false)]
                public int? MonthlySmsUsed { get; set; }

                [NameInMap("MonthlyWebhookUsed")]
                [Validation(Required=false)]
                public int? MonthlyWebhookUsed { get; set; }

                [NameInMap("ScheduleDomainName")]
                [Validation(Required=false)]
                public string ScheduleDomainName { get; set; }

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
