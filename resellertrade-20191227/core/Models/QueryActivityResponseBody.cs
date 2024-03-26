// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResellerTrade20191227.Models
{
    public class QueryActivityResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ContextMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ContextMap { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryActivityResponseBodyData Data { get; set; }
        public class QueryActivityResponseBodyData : TeaModel {
            [NameInMap("ActivityId")]
            [Validation(Required=false)]
            public long? ActivityId { get; set; }

            [NameInMap("ActivityName")]
            [Validation(Required=false)]
            public string ActivityName { get; set; }

            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public List<long?> BlackList { get; set; }

            [NameInMap("CommodityCodeList")]
            [Validation(Required=false)]
            public List<string> CommodityCodeList { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ExtMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtMap { get; set; }

            [NameInMap("PromotionDescription")]
            [Validation(Required=false)]
            public string PromotionDescription { get; set; }

            [NameInMap("PromotionValue")]
            [Validation(Required=false)]
            public double? PromotionValue { get; set; }

            [NameInMap("RegionList")]
            [Validation(Required=false)]
            public List<string> RegionList { get; set; }

            [NameInMap("SellerIdList")]
            [Validation(Required=false)]
            public List<long?> SellerIdList { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TestAccountList")]
            [Validation(Required=false)]
            public List<long?> TestAccountList { get; set; }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public List<long?> WhiteList { get; set; }

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
