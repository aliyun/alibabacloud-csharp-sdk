// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class GetRelationResponseBody : TeaModel {
        [NameInMap("Class")]
        [Validation(Required=false)]
        public string Class { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRelationResponseBodyData Data { get; set; }
        public class GetRelationResponseBodyData : TeaModel {
            [NameInMap("CanLoginOfficial")]
            [Validation(Required=false)]
            public bool? CanLoginOfficial { get; set; }

            [NameInMap("Class")]
            [Validation(Required=false)]
            public string Class { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("ResellerProductModeDO")]
            [Validation(Required=false)]
            public GetRelationResponseBodyDataResellerProductModeDO ResellerProductModeDO { get; set; }
            public class GetRelationResponseBodyDataResellerProductModeDO : TeaModel {
                [NameInMap("Class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                [NameInMap("IsService")]
                [Validation(Required=false)]
                public long? IsService { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            [NameInMap("ResellerProductRuleDO")]
            [Validation(Required=false)]
            public GetRelationResponseBodyDataResellerProductRuleDO ResellerProductRuleDO { get; set; }
            public class GetRelationResponseBodyDataResellerProductRuleDO : TeaModel {
                [NameInMap("Class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                [NameInMap("CommodityRoute")]
                [Validation(Required=false)]
                public bool? CommodityRoute { get; set; }

                [NameInMap("MultiOrder")]
                [Validation(Required=false)]
                public bool? MultiOrder { get; set; }

                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

            }

            [NameInMap("ResellerUid")]
            [Validation(Required=false)]
            public long? ResellerUid { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TopReseller")]
            [Validation(Required=false)]
            public bool? TopReseller { get; set; }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

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
