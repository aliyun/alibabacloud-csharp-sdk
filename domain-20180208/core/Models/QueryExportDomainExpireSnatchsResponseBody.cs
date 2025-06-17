// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180208.Models
{
    public class QueryExportDomainExpireSnatchsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryExportDomainExpireSnatchsResponseBodyData> Data { get; set; }
        public class QueryExportDomainExpireSnatchsResponseBodyData : TeaModel {
            [NameInMap("AuctionEndTime")]
            [Validation(Required=false)]
            public string AuctionEndTime { get; set; }

            [NameInMap("AuctionRemainingSeconds")]
            [Validation(Required=false)]
            public long? AuctionRemainingSeconds { get; set; }

            [NameInMap("BaiduAntiLink")]
            [Validation(Required=false)]
            public int? BaiduAntiLink { get; set; }

            [NameInMap("BaiduExLink")]
            [Validation(Required=false)]
            public int? BaiduExLink { get; set; }

            [NameInMap("BaiduIndex")]
            [Validation(Required=false)]
            public int? BaiduIndex { get; set; }

            [NameInMap("BaiduWeight")]
            [Validation(Required=false)]
            public int? BaiduWeight { get; set; }

            [NameInMap("BookEndTime")]
            [Validation(Required=false)]
            public string BookEndTime { get; set; }

            [NameInMap("BookRemainingSeconds")]
            [Validation(Required=false)]
            public long? BookRemainingSeconds { get; set; }

            [NameInMap("BookedNum")]
            [Validation(Required=false)]
            public int? BookedNum { get; set; }

            [NameInMap("BookedPartners")]
            [Validation(Required=false)]
            public string BookedPartners { get; set; }

            [NameInMap("Constitute")]
            [Validation(Required=false)]
            public string Constitute { get; set; }

            [NameInMap("CurrencyType")]
            [Validation(Required=false)]
            public string CurrencyType { get; set; }

            [NameInMap("DeliveryTime")]
            [Validation(Required=false)]
            public string DeliveryTime { get; set; }

            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("DomainLen")]
            [Validation(Required=false)]
            public int? DomainLen { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }

            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("FreezeAmount")]
            [Validation(Required=false)]
            public double? FreezeAmount { get; set; }

            [NameInMap("Introduction")]
            [Validation(Required=false)]
            public string Introduction { get; set; }

            [NameInMap("IsPremium")]
            [Validation(Required=false)]
            public bool? IsPremium { get; set; }

            [NameInMap("PartnerTypes")]
            [Validation(Required=false)]
            public string PartnerTypes { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public double? Price { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            [NameInMap("RegDate")]
            [Validation(Required=false)]
            public string RegDate { get; set; }

            [NameInMap("RenewPrice")]
            [Validation(Required=false)]
            public double? RenewPrice { get; set; }

            [NameInMap("Reserved")]
            [Validation(Required=false)]
            public bool? Reserved { get; set; }

            [NameInMap("RmbPrice")]
            [Validation(Required=false)]
            public double? RmbPrice { get; set; }

            [NameInMap("S360Weight")]
            [Validation(Required=false)]
            public int? S360Weight { get; set; }

            [NameInMap("SeoAttributes")]
            [Validation(Required=false)]
            public string SeoAttributes { get; set; }

            [NameInMap("ShortName")]
            [Validation(Required=false)]
            public string ShortName { get; set; }

            [NameInMap("SnatchNo")]
            [Validation(Required=false)]
            public string SnatchNo { get; set; }

            [NameInMap("SnatchTypeDesc")]
            [Validation(Required=false)]
            public string SnatchTypeDesc { get; set; }

            [NameInMap("SougouAntiLink")]
            [Validation(Required=false)]
            public int? SougouAntiLink { get; set; }

            [NameInMap("SougouIndex")]
            [Validation(Required=false)]
            public int? SougouIndex { get; set; }

            [NameInMap("SougouWeight")]
            [Validation(Required=false)]
            public int? SougouWeight { get; set; }

            [NameInMap("Suffix")]
            [Validation(Required=false)]
            public string Suffix { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
