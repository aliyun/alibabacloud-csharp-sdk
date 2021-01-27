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
                public string CreateTime { get; set; }
                public string EndTime { get; set; }
                public string ExpectedReleaseTime { get; set; }
                public string InstanceID { get; set; }
                public long? OwnerId { get; set; }
                public string ProductCode { get; set; }
                public string ProductType { get; set; }
                public string Region { get; set; }
                public string ReleaseTime { get; set; }
                public string RenewStatus { get; set; }
                public int? RenewalDuration { get; set; }
                public string RenewalDurationUnit { get; set; }
                public string Seller { get; set; }
                public long? SellerId { get; set; }
                public string Status { get; set; }
                public string StopTime { get; set; }
                public string SubStatus { get; set; }
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
        };

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
