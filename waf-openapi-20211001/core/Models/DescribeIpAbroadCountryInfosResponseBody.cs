// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeIpAbroadCountryInfosResponseBody : TeaModel {
        [NameInMap("AbroadInfos")]
        [Validation(Required=false)]
        public List<DescribeIpAbroadCountryInfosResponseBodyAbroadInfos> AbroadInfos { get; set; }
        public class DescribeIpAbroadCountryInfosResponseBodyAbroadInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>北美洲</para>
            /// </summary>
            [NameInMap("Continent")]
            [Validation(Required=false)]
            public string Continent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>美国</para>
            /// </summary>
            [NameInMap("CountryName")]
            [Validation(Required=false)]
            public string CountryName { get; set; }

            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<DescribeIpAbroadCountryInfosResponseBodyAbroadInfosRegions> Regions { get; set; }
            public class DescribeIpAbroadCountryInfosResponseBodyAbroadInfosRegions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>US-CA</para>
                /// </summary>
                [NameInMap("AbroadRegionId")]
                [Validation(Required=false)]
                public string AbroadRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>加利福尼亚州</para>
                /// </summary>
                [NameInMap("AbroadRegionName")]
                [Validation(Required=false)]
                public string AbroadRegionName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
