// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yunjian20211217.Models
{
    public class PageDemandPlanWithDemandInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public PageDemandPlanWithDemandInfoResponseBodyData Data { get; set; }
        public class PageDemandPlanWithDemandInfoResponseBodyData : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<PageDemandPlanWithDemandInfoResponseBodyDataData> Data { get; set; }
            public class PageDemandPlanWithDemandInfoResponseBodyDataData : TeaModel {
                [NameInMap("accountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                [NameInMap("accountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                [NameInMap("approvalNodeStatus")]
                [Validation(Required=false)]
                public string ApprovalNodeStatus { get; set; }

                [NameInMap("approvalStatus")]
                [Validation(Required=false)]
                public string ApprovalStatus { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("deliveryPlanId")]
                [Validation(Required=false)]
                public string DeliveryPlanId { get; set; }

                [NameInMap("deliveryStatus")]
                [Validation(Required=false)]
                public string DeliveryStatus { get; set; }

                [NameInMap("demandDesc")]
                [Validation(Required=false)]
                public string DemandDesc { get; set; }

                [NameInMap("demandId")]
                [Validation(Required=false)]
                public long? DemandId { get; set; }

                [NameInMap("demandName")]
                [Validation(Required=false)]
                public string DemandName { get; set; }

                [NameInMap("demandPlanId")]
                [Validation(Required=false)]
                public double? DemandPlanId { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("requirementObjectCode")]
                [Validation(Required=false)]
                public string RequirementObjectCode { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
