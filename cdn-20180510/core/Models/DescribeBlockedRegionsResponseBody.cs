// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeBlockedRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information returned.</para>
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
                /// <para>The district to which the country or region belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Asia</para>
                /// </summary>
                [NameInMap("Continent")]
                [Validation(Required=false)]
                public string Continent { get; set; }

                /// <summary>
                /// <para>The abbreviation of the name of the country or region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AF</para>
                /// </summary>
                [NameInMap("CountriesAndRegions")]
                [Validation(Required=false)]
                public string CountriesAndRegions { get; set; }

                /// <summary>
                /// <para>The name of the country or region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Afghanistan</para>
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
