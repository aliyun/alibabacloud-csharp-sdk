// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBlockedRegionsResponseBody : TeaModel {
        /// <summary>
        /// The information about the country or region.
        /// </summary>
        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public DescribeDcdnBlockedRegionsResponseBodyInfoList InfoList { get; set; }
        public class DescribeDcdnBlockedRegionsResponseBodyInfoList : TeaModel {
            [NameInMap("InfoItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnBlockedRegionsResponseBodyInfoListInfoItem> InfoItem { get; set; }
            public class DescribeDcdnBlockedRegionsResponseBodyInfoListInfoItem : TeaModel {
                /// <summary>
                /// The larger region to which the country or region belongs.
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
