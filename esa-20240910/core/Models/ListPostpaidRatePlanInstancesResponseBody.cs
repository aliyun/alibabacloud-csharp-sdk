// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListPostpaidRatePlanInstancesResponseBody : TeaModel {
        [NameInMap("InstanceInfo")]
        [Validation(Required=false)]
        public List<ListPostpaidRatePlanInstancesResponseBodyInstanceInfo> InstanceInfo { get; set; }
        public class ListPostpaidRatePlanInstancesResponseBodyInstanceInfo : TeaModel {
            [NameInMap("BillingMethod")]
            [Validation(Required=false)]
            public string BillingMethod { get; set; }

            [NameInMap("BillingMode")]
            [Validation(Required=false)]
            public string BillingMode { get; set; }

            [NameInMap("Coverages")]
            [Validation(Required=false)]
            public string Coverages { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ExpectedUpdateTime")]
            [Validation(Required=false)]
            public string ExpectedUpdateTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("PlanName")]
            [Validation(Required=false)]
            public string PlanName { get; set; }

            [NameInMap("PlanNameCn")]
            [Validation(Required=false)]
            public string PlanNameCn { get; set; }

            [NameInMap("PlanType")]
            [Validation(Required=false)]
            public string PlanType { get; set; }

            [NameInMap("SiteQuota")]
            [Validation(Required=false)]
            public string SiteQuota { get; set; }

            [NameInMap("Sites")]
            [Validation(Required=false)]
            public List<ListPostpaidRatePlanInstancesResponseBodyInstanceInfoSites> Sites { get; set; }
            public class ListPostpaidRatePlanInstancesResponseBodyInstanceInfoSites : TeaModel {
                [NameInMap("SiteId")]
                [Validation(Required=false)]
                public long? SiteId { get; set; }

                [NameInMap("SiteName")]
                [Validation(Required=false)]
                public string SiteName { get; set; }

                [NameInMap("SiteStatus")]
                [Validation(Required=false)]
                public string SiteStatus { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
