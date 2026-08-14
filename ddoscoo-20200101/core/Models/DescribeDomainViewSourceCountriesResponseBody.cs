// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewSourceCountriesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceCountrys")]
        [Validation(Required=false)]
        public List<DescribeDomainViewSourceCountriesResponseBodySourceCountrys> SourceCountrys { get; set; }
        public class DescribeDomainViewSourceCountriesResponseBodySourceCountrys : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

        }

    }

}
