// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewSourceProvincesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array consisting of the details of the administrative region in China from which the requests are sent.
        /// </summary>
        [NameInMap("SourceProvinces")]
        [Validation(Required=false)]
        public List<DescribeDomainViewSourceProvincesResponseBodySourceProvinces> SourceProvinces { get; set; }
        public class DescribeDomainViewSourceProvincesResponseBodySourceProvinces : TeaModel {
            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The ID of the region inside China. For more information, see the **Codes of administrative regions in China** section of the [Codes of administrative regions in China and codes of countries and areas](https://help.aliyun.com/document_detail/167926.html) topic. For example, **110000** indicates Beijing, and **120000** indicates Tianjin.
            /// </summary>
            [NameInMap("ProvinceId")]
            [Validation(Required=false)]
            public string ProvinceId { get; set; }

        }

    }

}
