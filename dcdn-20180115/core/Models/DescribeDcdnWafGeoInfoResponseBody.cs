// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafGeoInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of information about the country or region.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafGeoInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafGeoInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The information about the country or region.</para>
            /// </summary>
            [NameInMap("Continents")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafGeoInfoResponseBodyContentContinents> Continents { get; set; }
            public class DescribeDcdnWafGeoInfoResponseBodyContentContinents : TeaModel {
                /// <summary>
                /// <para>The district to which the country or region belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The region information.</para>
                /// </summary>
                [NameInMap("Regions")]
                [Validation(Required=false)]
                public List<DescribeDcdnWafGeoInfoResponseBodyContentContinentsRegions> Regions { get; set; }
                public class DescribeDcdnWafGeoInfoResponseBodyContentContinentsRegions : TeaModel {
                    /// <summary>
                    /// <para>The name of the country or region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Beijing</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The code of the country or region.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>110000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The type of the region.</para>
            /// <list type="bullet">
            /// <item><description>CN: China</description></item>
            /// <item><description>Other: outside China</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
