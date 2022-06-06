// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateOrderForHardwareRequest : TeaModel {
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("CityCode")]
        [Validation(Required=false)]
        public string CityCode { get; set; }

        [NameInMap("CityName")]
        [Validation(Required=false)]
        public string CityName { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        [NameInMap("CountryName")]
        [Validation(Required=false)]
        public string CountryName { get; set; }

        [NameInMap("DetailAddress")]
        [Validation(Required=false)]
        public string DetailAddress { get; set; }

        [NameInMap("DistrictCode")]
        [Validation(Required=false)]
        public string DistrictCode { get; set; }

        [NameInMap("DistrictName")]
        [Validation(Required=false)]
        public string DistrictName { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("HardwareType")]
        [Validation(Required=false)]
        public string HardwareType { get; set; }

        [NameInMap("HardwareVersion")]
        [Validation(Required=false)]
        public string HardwareVersion { get; set; }

        [NameInMap("MobilePhone")]
        [Validation(Required=false)]
        public string MobilePhone { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

        [NameInMap("ProvCode")]
        [Validation(Required=false)]
        public string ProvCode { get; set; }

        [NameInMap("ProvName")]
        [Validation(Required=false)]
        public string ProvName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StreetCode")]
        [Validation(Required=false)]
        public string StreetCode { get; set; }

        [NameInMap("StreetName")]
        [Validation(Required=false)]
        public string StreetName { get; set; }

        [NameInMap("ZipCode")]
        [Validation(Required=false)]
        public string ZipCode { get; set; }

    }

}
