// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnBlockedRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the country or region.</para>
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
                /// <para>The larger region to which the country or region belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Middle East</para>
                /// </summary>
                [NameInMap("Continent")]
                [Validation(Required=false)]
                public string Continent { get; set; }

                /// <summary>
                /// <para>The abbreviation of the name of the country or region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AE</para>
                /// </summary>
                [NameInMap("CountriesAndRegions")]
                [Validation(Required=false)]
                public string CountriesAndRegions { get; set; }

                /// <summary>
                /// <para>The name of the country or region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>United Arab Emirates</para>
                /// </summary>
                [NameInMap("CountriesAndRegionsName")]
                [Validation(Required=false)]
                public string CountriesAndRegionsName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFFCDFAD-DACC-484E-9BE6-0AF3B3A0DD23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
