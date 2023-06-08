// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGeoInfoResponseBody : TeaModel {
        /// <summary>
        /// The type of information about the country or region.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafGeoInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafGeoInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// The information about the country or region.
            /// </summary>
            [NameInMap("Continents")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafGeoInfoResponseBodyContentContinents> Continents { get; set; }
            public class DescribeDcdnWafGeoInfoResponseBodyContentContinents : TeaModel {
                /// <summary>
                /// The district to which the country or region belongs.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The region information.
                /// </summary>
                [NameInMap("Regions")]
                [Validation(Required=false)]
                public List<DescribeDcdnWafGeoInfoResponseBodyContentContinentsRegions> Regions { get; set; }
                public class DescribeDcdnWafGeoInfoResponseBodyContentContinentsRegions : TeaModel {
                    /// <summary>
                    /// The name of the country or region.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The code of the country or region.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// The type of the region.
            /// 
            /// *   CN: China
            /// *   Other: outside China
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
