// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class QueryEcoRelationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContextMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContextMap { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryEcoRelationResponseBodyData Data { get; set; }
        public class QueryEcoRelationResponseBodyData : TeaModel {
            [NameInMap("CanLoginOfficial")]
            [Validation(Required=false)]
            public bool? CanLoginOfficial { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("IsTopReseller")]
            [Validation(Required=false)]
            public bool? IsTopReseller { get; set; }

            [NameInMap("ResellerProductModeDO")]
            [Validation(Required=false)]
            public QueryEcoRelationResponseBodyDataResellerProductModeDO ResellerProductModeDO { get; set; }
            public class QueryEcoRelationResponseBodyDataResellerProductModeDO : TeaModel {
                [NameInMap("IsService")]
                [Validation(Required=false)]
                public int? IsService { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            [NameInMap("ResellerProductRuleDO")]
            [Validation(Required=false)]
            public QueryEcoRelationResponseBodyDataResellerProductRuleDO ResellerProductRuleDO { get; set; }
            public class QueryEcoRelationResponseBodyDataResellerProductRuleDO : TeaModel {
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
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
