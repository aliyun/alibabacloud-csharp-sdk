// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20210501.Models
{
    public class SearchByPicResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchByPicResponseBodyData Data { get; set; }
        public class SearchByPicResponseBodyData : TeaModel {
            [NameInMap("Auctions")]
            [Validation(Required=false)]
            public List<SearchByPicResponseBodyDataAuctions> Auctions { get; set; }
            public class SearchByPicResponseBodyDataAuctions : TeaModel {
                public SearchByPicResponseBodyDataAuctionsResult Result { get; set; }
                public class SearchByPicResponseBodyDataAuctionsResult : TeaModel {
                    [NameInMap("ItemId")]
                    [Validation(Required=false)]
                    public string ItemId { get; set; }

                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Pic")]
                    [Validation(Required=false)]
                    public string Pic { get; set; }

                    [NameInMap("PicUrl")]
                    [Validation(Required=false)]
                    public string PicUrl { get; set; }

                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    [NameInMap("ReservePrice")]
                    [Validation(Required=false)]
                    public string ReservePrice { get; set; }

                    [NameInMap("PromotionPrice")]
                    [Validation(Required=false)]
                    public string PromotionPrice { get; set; }

                    [NameInMap("ZkFinalPrice")]
                    [Validation(Required=false)]
                    public string ZkFinalPrice { get; set; }

                    [NameInMap("PriceAfterCoupon")]
                    [Validation(Required=false)]
                    public string PriceAfterCoupon { get; set; }

                    [NameInMap("UserType")]
                    [Validation(Required=false)]
                    public int? UserType { get; set; }

                    [NameInMap("Provcity")]
                    [Validation(Required=false)]
                    public string Provcity { get; set; }

                    [NameInMap("SellerNickName")]
                    [Validation(Required=false)]
                    public string SellerNickName { get; set; }

                    [NameInMap("Nick")]
                    [Validation(Required=false)]
                    public string Nick { get; set; }

                    [NameInMap("SellerId")]
                    [Validation(Required=false)]
                    public string SellerId { get; set; }

                    [NameInMap("MonthSellCount")]
                    [Validation(Required=false)]
                    public int? MonthSellCount { get; set; }

                    [NameInMap("Volume")]
                    [Validation(Required=false)]
                    public int? Volume { get; set; }

                    [NameInMap("LevelOneCategoryName")]
                    [Validation(Required=false)]
                    public string LevelOneCategoryName { get; set; }

                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("CouponActivityId")]
                    [Validation(Required=false)]
                    public string CouponActivityId { get; set; }

                    [NameInMap("CouponTotalCount")]
                    [Validation(Required=false)]
                    public string CouponTotalCount { get; set; }

                    [NameInMap("CouponSendCount")]
                    [Validation(Required=false)]
                    public string CouponSendCount { get; set; }

                    [NameInMap("CouponRemainCount")]
                    [Validation(Required=false)]
                    public int? CouponRemainCount { get; set; }

                    [NameInMap("CouponStartTime")]
                    [Validation(Required=false)]
                    public string CouponStartTime { get; set; }

                    [NameInMap("CouponEndTime")]
                    [Validation(Required=false)]
                    public string CouponEndTime { get; set; }

                    [NameInMap("CouponStartFee")]
                    [Validation(Required=false)]
                    public string CouponStartFee { get; set; }

                    [NameInMap("CouponAmount")]
                    [Validation(Required=false)]
                    public int? CouponAmount { get; set; }

                    [NameInMap("CouponSaleTextInfo")]
                    [Validation(Required=false)]
                    public string CouponSaleTextInfo { get; set; }

                    [NameInMap("CouponInfo")]
                    [Validation(Required=false)]
                    public string CouponInfo { get; set; }

                    [NameInMap("TkMktRate")]
                    [Validation(Required=false)]
                    public int? TkMktRate { get; set; }

                    [NameInMap("TkRate")]
                    [Validation(Required=false)]
                    public int? TkRate { get; set; }

                    [NameInMap("CommissionRate")]
                    [Validation(Required=false)]
                    public string CommissionRate { get; set; }

                    [NameInMap("CouponShareUrl")]
                    [Validation(Required=false)]
                    public string CouponShareUrl { get; set; }

                    [NameInMap("ClickUrl")]
                    [Validation(Required=false)]
                    public string ClickUrl { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                    [NameInMap("ShortUrl")]
                    [Validation(Required=false)]
                    public string ShortUrl { get; set; }

                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("ShopTitle")]
                    [Validation(Required=false)]
                    public string ShopTitle { get; set; }

                    [NameInMap("MaxCommission")]
                    [Validation(Required=false)]
                    public SearchByPicResponseBodyDataAuctionsResultMaxCommission MaxCommission { get; set; }
                    public class SearchByPicResponseBodyDataAuctionsResultMaxCommission : TeaModel {
                        [NameInMap("MaxCommissionRate")]
                        [Validation(Required=false)]
                        public string MaxCommissionRate { get; set; }
                        [NameInMap("MaxCommissionClickUrl")]
                        [Validation(Required=false)]
                        public string MaxCommissionClickUrl { get; set; }
                        [NameInMap("MaxCommissionCouponShareUrl")]
                        [Validation(Required=false)]
                        public string MaxCommissionCouponShareUrl { get; set; }
                    };

                }
                public float? RankScore { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PicInfo")]
        [Validation(Required=false)]
        public SearchByPicResponseBodyPicInfo PicInfo { get; set; }
        public class SearchByPicResponseBodyPicInfo : TeaModel {
            [NameInMap("MainRegion")]
            [Validation(Required=false)]
            public SearchByPicResponseBodyPicInfoMainRegion MainRegion { get; set; }
            public class SearchByPicResponseBodyPicInfoMainRegion : TeaModel {
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("MultiCategoryId")]
                [Validation(Required=false)]
                public List<SearchByPicResponseBodyPicInfoMainRegionMultiCategoryId> MultiCategoryId { get; set; }
                public class SearchByPicResponseBodyPicInfoMainRegionMultiCategoryId : TeaModel {
                    [NameInMap("CategoryId")]
                    [Validation(Required=false)]
                    public int? CategoryId { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

            }
            [NameInMap("MultiRegion")]
            [Validation(Required=false)]
            public List<SearchByPicResponseBodyPicInfoMultiRegion> MultiRegion { get; set; }
            public class SearchByPicResponseBodyPicInfoMultiRegion : TeaModel {
                public string Region { get; set; }
            }
        };

    }

}
