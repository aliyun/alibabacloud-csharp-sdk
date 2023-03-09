// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetBillDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBillDetailResponseBodyData Data { get; set; }
        public class GetBillDetailResponseBodyData : TeaModel {
            [NameInMap("BillEndTime")]
            [Validation(Required=false)]
            public string BillEndTime { get; set; }

            [NameInMap("BillId")]
            [Validation(Required=false)]
            public string BillId { get; set; }

            [NameInMap("BillStartTime")]
            [Validation(Required=false)]
            public string BillStartTime { get; set; }

            [NameInMap("Offering")]
            [Validation(Required=false)]
            public string Offering { get; set; }

            [NameInMap("PayStatus")]
            [Validation(Required=false)]
            public string PayStatus { get; set; }

            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("RegionInfoList")]
            [Validation(Required=false)]
            public GetBillDetailResponseBodyDataRegionInfoList RegionInfoList { get; set; }
            public class GetBillDetailResponseBodyDataRegionInfoList : TeaModel {
                [NameInMap("regionInfo")]
                [Validation(Required=false)]
                public List<GetBillDetailResponseBodyDataRegionInfoListRegionInfo> RegionInfo { get; set; }
                public class GetBillDetailResponseBodyDataRegionInfoListRegionInfo : TeaModel {
                    [NameInMap("DiscountFee")]
                    [Validation(Required=false)]
                    public string DiscountFee { get; set; }

                    [NameInMap("RegionCode")]
                    [Validation(Required=false)]
                    public string RegionCode { get; set; }

                    [NameInMap("RequirePayAmount")]
                    [Validation(Required=false)]
                    public string RequirePayAmount { get; set; }

                    [NameInMap("TotalFee")]
                    [Validation(Required=false)]
                    public string TotalFee { get; set; }

                    [NameInMap("YouhuiquanPayAmount")]
                    [Validation(Required=false)]
                    public string YouhuiquanPayAmount { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
