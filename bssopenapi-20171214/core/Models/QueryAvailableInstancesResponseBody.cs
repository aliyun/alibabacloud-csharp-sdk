// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryAvailableInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAvailableInstancesResponseBodyData Data { get; set; }
        public class QueryAvailableInstancesResponseBodyData : TeaModel {
            [NameInMap("InstanceList")]
            [Validation(Required=false)]
            public List<QueryAvailableInstancesResponseBodyDataInstanceList> InstanceList { get; set; }
            public class QueryAvailableInstancesResponseBodyDataInstanceList : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExpectedReleaseTime")]
                [Validation(Required=false)]
                public string ExpectedReleaseTime { get; set; }

                [NameInMap("InstanceID")]
                [Validation(Required=false)]
                public string InstanceID { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                [NameInMap("RenewStatus")]
                [Validation(Required=false)]
                public string RenewStatus { get; set; }

                [NameInMap("RenewalDuration")]
                [Validation(Required=false)]
                public int? RenewalDuration { get; set; }

                [NameInMap("RenewalDurationUnit")]
                [Validation(Required=false)]
                public string RenewalDurationUnit { get; set; }

                [NameInMap("Seller")]
                [Validation(Required=false)]
                public string Seller { get; set; }

                [NameInMap("SellerId")]
                [Validation(Required=false)]
                public long? SellerId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                [NameInMap("SubscriptionType")]
                [Validation(Required=false)]
                public string SubscriptionType { get; set; }

            }

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
