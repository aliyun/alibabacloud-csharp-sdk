// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Avds20171129.Models
{
    public class CreateAvdsOrderRequest : TeaModel {
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("SiteNum")]
        [Validation(Required=false)]
        public string SiteNum { get; set; }

        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        [NameInMap("UrlNum")]
        [Validation(Required=false)]
        public string UrlNum { get; set; }

        [NameInMap("AddVulNum")]
        [Validation(Required=false)]
        public string AddVulNum { get; set; }

    }

}
