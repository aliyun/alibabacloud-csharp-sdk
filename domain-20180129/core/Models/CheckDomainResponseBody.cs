// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class CheckDomainResponseBody : TeaModel {
        [NameInMap("Avail")]
        [Validation(Required=false)]
        public string Avail { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DynamicCheck")]
        [Validation(Required=false)]
        public bool? DynamicCheck { get; set; }

        [NameInMap("Premium")]
        [Validation(Required=false)]
        public string Premium { get; set; }

        [NameInMap("Price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StaticPriceInfo")]
        [Validation(Required=false)]
        public CheckDomainResponseBodyStaticPriceInfo StaticPriceInfo { get; set; }
        public class CheckDomainResponseBodyStaticPriceInfo : TeaModel {
            [NameInMap("PriceInfo")]
            [Validation(Required=false)]
            public List<CheckDomainResponseBodyStaticPriceInfoPriceInfo> PriceInfo { get; set; }
            public class CheckDomainResponseBodyStaticPriceInfoPriceInfo : TeaModel {
                [NameInMap("action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("money")]
                [Validation(Required=false)]
                public double? Money { get; set; }

                [NameInMap("period")]
                [Validation(Required=false)]
                public long? Period { get; set; }

            }

        }

    }

}
