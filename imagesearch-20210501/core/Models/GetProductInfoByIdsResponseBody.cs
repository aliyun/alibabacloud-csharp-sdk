// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210501.Models
{
    public class GetProductInfoByIdsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProductInfoByIdsResponseBodyData Data { get; set; }
        public class GetProductInfoByIdsResponseBodyData : TeaModel {
            [NameInMap("Auctions")]
            [Validation(Required=false)]
            public List<GetProductInfoByIdsResponseBodyDataAuctions> Auctions { get; set; }
            public class GetProductInfoByIdsResponseBodyDataAuctions : TeaModel {
                [NameInMap("RankScore")]
                [Validation(Required=false)]
                public float? RankScore { get; set; }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public GetProductInfoByIdsResponseBodyDataAuctionsResult Result { get; set; }
                public class GetProductInfoByIdsResponseBodyDataAuctionsResult : TeaModel {
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("CommissionRate")]
                    [Validation(Required=false)]
                    public string CommissionRate { get; set; }

                    [NameInMap("CouponAmount")]
                    [Validation(Required=false)]
                    public int? CouponAmount { get; set; }

                    [NameInMap("CouponEndTime")]
                    [Validation(Required=false)]
                    public string CouponEndTime { get; set; }

                    [NameInMap("CouponInfo")]
                    [Validation(Required=false)]
                    public string CouponInfo { get; set; }

                    [NameInMap("CouponRemainCount")]
                    [Validation(Required=false)]
                    public int? CouponRemainCount { get; set; }

                    [NameInMap("CouponShareUrl")]
                    [Validation(Required=false)]
                    public string CouponShareUrl { get; set; }

                    [NameInMap("CouponStartFee")]
                    [Validation(Required=false)]
                    public string CouponStartFee { get; set; }

                    [NameInMap("CouponStartTime")]
                    [Validation(Required=false)]
                    public string CouponStartTime { get; set; }

                    [NameInMap("CouponTotalCount")]
                    [Validation(Required=false)]
                    public string CouponTotalCount { get; set; }

                    [NameInMap("DeeplinkCouponShareUrl")]
                    [Validation(Required=false)]
                    public string DeeplinkCouponShareUrl { get; set; }

                    [NameInMap("DeeplinkUrl")]
                    [Validation(Required=false)]
                    public string DeeplinkUrl { get; set; }

                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("LevelOneCategoryName")]
                    [Validation(Required=false)]
                    public string LevelOneCategoryName { get; set; }

                    [NameInMap("MaxCommission")]
                    [Validation(Required=false)]
                    public GetProductInfoByIdsResponseBodyDataAuctionsResultMaxCommission MaxCommission { get; set; }
                    public class GetProductInfoByIdsResponseBodyDataAuctionsResultMaxCommission : TeaModel {
                        [NameInMap("MaxCommissionClickUrl")]
                        [Validation(Required=false)]
                        public string MaxCommissionClickUrl { get; set; }

                        [NameInMap("MaxCommissionCouponShareUrl")]
                        [Validation(Required=false)]
                        public string MaxCommissionCouponShareUrl { get; set; }

                        [NameInMap("MaxCommissionRate")]
                        [Validation(Required=false)]
                        public string MaxCommissionRate { get; set; }

                    }

                    [NameInMap("Nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }

                    [NameInMap("PicUrl")]
                    [Validation(Required=false)]
                    public string PicUrl { get; set; }

                    [NameInMap("PriceAfterCoupon")]
                    [Validation(Required=false)]
                    public string PriceAfterCoupon { get; set; }

                    [NameInMap("Provcity")]
                    [Validation(Required=false)]
                    public string Provcity { get; set; }

                    [NameInMap("ReservePrice")]
                    [Validation(Required=false)]
                    public string ReservePrice { get; set; }

                    [NameInMap("SellerId")]
                    [Validation(Required=false)]
                    public string SellerId { get; set; }

                    [NameInMap("ShopTitle")]
                    [Validation(Required=false)]
                    public string ShopTitle { get; set; }

                    [NameInMap("ShortTitle")]
                    [Validation(Required=false)]
                    public string ShortTitle { get; set; }

                    [NameInMap("SubTitle")]
                    [Validation(Required=false)]
                    public string SubTitle { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("UserType")]
                    [Validation(Required=false)]
                    public int? UserType { get; set; }

                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                    [NameInMap("ZkFinalPrice")]
                    [Validation(Required=false)]
                    public string ZkFinalPrice { get; set; }

                }

            }

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
