// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20161118.Models
{
    public class QueryConsumeInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryConsumeInstancesResponseBodyData Data { get; set; }
        public class QueryConsumeInstancesResponseBodyData : TeaModel {
            [NameInMap("ConsumeInstanceModel")]
            [Validation(Required=false)]
            public List<QueryConsumeInstancesResponseBodyDataConsumeInstanceModel> ConsumeInstanceModel { get; set; }
            public class QueryConsumeInstancesResponseBodyDataConsumeInstanceModel : TeaModel {
                [NameInMap("BuyerId")]
                [Validation(Required=false)]
                public long? BuyerId { get; set; }

                [NameInMap("CashPayAmount")]
                [Validation(Required=false)]
                public string CashPayAmount { get; set; }

                [NameInMap("CommodityCode")]
                [Validation(Required=false)]
                public string CommodityCode { get; set; }

                [NameInMap("ConsumeAmount")]
                [Validation(Required=false)]
                public string ConsumeAmount { get; set; }

                [NameInMap("ConsumeCategory")]
                [Validation(Required=false)]
                public string ConsumeCategory { get; set; }

                [NameInMap("ConsumeDetailMap")]
                [Validation(Required=false)]
                public string ConsumeDetailMap { get; set; }

                [NameInMap("ConsumePeriod")]
                [Validation(Required=false)]
                public string ConsumePeriod { get; set; }

                [NameInMap("ConsumeTime")]
                [Validation(Required=false)]
                public string ConsumeTime { get; set; }

                [NameInMap("CouponPayAmount")]
                [Validation(Required=false)]
                public string CouponPayAmount { get; set; }

                [NameInMap("FreeAmount")]
                [Validation(Required=false)]
                public string FreeAmount { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceNick")]
                [Validation(Required=false)]
                public string InstanceNick { get; set; }

                [NameInMap("InternetIp")]
                [Validation(Required=false)]
                public string InternetIp { get; set; }

                [NameInMap("IntranetIp")]
                [Validation(Required=false)]
                public string IntranetIp { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public long? OwnerId { get; set; }

                [NameInMap("PayStatus")]
                [Validation(Required=false)]
                public string PayStatus { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("RequireAmount")]
                [Validation(Required=false)]
                public string RequireAmount { get; set; }

                [NameInMap("ServiceDuration")]
                [Validation(Required=false)]
                public string ServiceDuration { get; set; }

                [NameInMap("ServiceEndTime")]
                [Validation(Required=false)]
                public string ServiceEndTime { get; set; }

                [NameInMap("ServiceStartTime")]
                [Validation(Required=false)]
                public string ServiceStartTime { get; set; }

                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("UnclearAmount")]
                [Validation(Required=false)]
                public string UnclearAmount { get; set; }

                [NameInMap("bizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextPageMinId")]
        [Validation(Required=false)]
        public long? NextPageMinId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
