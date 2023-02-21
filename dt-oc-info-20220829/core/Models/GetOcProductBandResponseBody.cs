// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcProductBandResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOcProductBandResponseBodyData> Data { get; set; }
        public class GetOcProductBandResponseBodyData : TeaModel {
            [NameInMap("BrandIntroduction")]
            [Validation(Required=false)]
            public string BrandIntroduction { get; set; }

            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("ProductIntroduction")]
            [Validation(Required=false)]
            public string ProductIntroduction { get; set; }

            [NameInMap("ProductLogo")]
            [Validation(Required=false)]
            public string ProductLogo { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("ProductTag")]
            [Validation(Required=false)]
            public string ProductTag { get; set; }

            [NameInMap("ProductWebsite")]
            [Validation(Required=false)]
            public string ProductWebsite { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
