// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceCountriesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of countries or areas from which the requests are sent.
        /// </summary>
        [NameInMap("SourceCountrys")]
        [Validation(Required=false)]
        public List<DescribePortViewSourceCountriesResponseBodySourceCountrys> SourceCountrys { get; set; }
        public class DescribePortViewSourceCountriesResponseBodySourceCountrys : TeaModel {
            /// <summary>
            /// The number of requests.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The abbreviation of the country or area. For example, **cn** indicates China and **us** indicates the United States.
            /// 
            /// > For more information, see [Location parameters](~~167926~~).
            /// </summary>
            [NameInMap("CountryId")]
            [Validation(Required=false)]
            public string CountryId { get; set; }

        }

    }

}
