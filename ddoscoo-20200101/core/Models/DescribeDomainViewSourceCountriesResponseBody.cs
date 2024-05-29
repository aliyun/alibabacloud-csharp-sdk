// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewSourceCountriesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the country or area from which the requests are sent.
        /// </summary>
        [NameInMap("SourceCountrys")]
        [Validation(Required=false)]
        public List<DescribeDomainViewSourceCountriesResponseBodySourceCountrys> SourceCountrys { get; set; }
        public class DescribeDomainViewSourceCountriesResponseBodySourceCountrys : TeaModel {
            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The abbreviation of the country or area. For more information, see the **Codes of countries and areas** section of the [Codes of administrative regions in China and codes of countries and areas](https://help.aliyun.com/document_detail/167926.html) topic. For example, **cn** indicates China, and **us** indicates the United States.
            /// </summary>
            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

        }

    }

}
