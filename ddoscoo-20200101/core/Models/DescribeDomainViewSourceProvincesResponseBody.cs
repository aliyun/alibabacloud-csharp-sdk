// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewSourceProvincesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceProvinces")]
        [Validation(Required=false)]
        public List<DescribeDomainViewSourceProvincesResponseBodySourceProvinces> SourceProvinces { get; set; }
        public class DescribeDomainViewSourceProvincesResponseBodySourceProvinces : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("ProvinceId")]
            [Validation(Required=false)]
            public string ProvinceId { get; set; }

        }

    }

}
