// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceProvincesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Details about the administrative region in China from which the requests are sent.
        /// </summary>
        [NameInMap("SourceProvinces")]
        [Validation(Required=false)]
        public List<DescribePortViewSourceProvincesResponseBodySourceProvinces> SourceProvinces { get; set; }
        public class DescribePortViewSourceProvincesResponseBodySourceProvinces : TeaModel {
            /// <summary>
            /// The total number of requests that are sent from the ISP.
            /// 
            /// > This parameter does not indicate the accurate number of requests. You can use this parameter to calculate the proportion of requests from different administrative regions in China.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The ID of the administrative region in China from which the requests are sent. For example, **110000** indicates Beijing, and **120000** indicates Tianjin.
            /// 
            /// > For more information, see [Location parameters](~~167926~~).
            /// </summary>
            [NameInMap("ProvinceId")]
            [Validation(Required=false)]
            public string ProvinceId { get; set; }

        }

    }

}
