// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeBlockedRegionsResponseBody : TeaModel {
        /// <summary>
        /// The information returned.
        /// </summary>
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public DescribeBlockedRegionsResponseBodyInfoList InfoList { get; set; }
        public class DescribeBlockedRegionsResponseBodyInfoList : TeaModel {
            [NameInMap("InfoItem")]
            [Validation(Required=false)]
            public List<DescribeBlockedRegionsResponseBodyInfoListInfoItem> InfoItem { get; set; }
            public class DescribeBlockedRegionsResponseBodyInfoListInfoItem : TeaModel {
                /// <summary>
                /// The district to which the country or region belongs.
                /// </summary>
                [NameInMap("Continent")]
                [Validation(Required=false)]
                public string Continent { get; set; }

                /// <summary>
                /// The abbreviation of the name of the country or region.
                /// </summary>
                [NameInMap("CountriesAndRegions")]
                [Validation(Required=false)]
                public string CountriesAndRegions { get; set; }

                /// <summary>
                /// The name of the country or region.
                /// </summary>
                [NameInMap("CountriesAndRegionsName")]
                [Validation(Required=false)]
                public string CountriesAndRegionsName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
