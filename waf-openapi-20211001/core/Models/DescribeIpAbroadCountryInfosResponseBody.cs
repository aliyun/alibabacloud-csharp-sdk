// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeIpAbroadCountryInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of country information outside China.</para>
        /// </summary>
        [NameInMap("AbroadInfos")]
        [Validation(Required=false)]
        public List<DescribeIpAbroadCountryInfosResponseBodyAbroadInfos> AbroadInfos { get; set; }
        public class DescribeIpAbroadCountryInfosResponseBodyAbroadInfos : TeaModel {
            /// <summary>
            /// <para>The continent to which the country belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>North America</para>
            /// </summary>
            [NameInMap("Continent")]
            [Validation(Required=false)]
            public string Continent { get; set; }

            /// <summary>
            /// <para>The ID of the country.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The name of the country.</para>
            /// 
            /// <b>Example:</b>
            /// <para>United States</para>
            /// </summary>
            [NameInMap("CountryName")]
            [Validation(Required=false)]
            public string CountryName { get; set; }

            /// <summary>
            /// <para>The list of region information outside China.</para>
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<DescribeIpAbroadCountryInfosResponseBodyAbroadInfosRegions> Regions { get; set; }
            public class DescribeIpAbroadCountryInfosResponseBodyAbroadInfosRegions : TeaModel {
                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>US-CA</para>
                /// </summary>
                [NameInMap("AbroadRegionId")]
                [Validation(Required=false)]
                public string AbroadRegionId { get; set; }

                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>California</para>
                /// </summary>
                [NameInMap("AbroadRegionName")]
                [Validation(Required=false)]
                public string AbroadRegionName { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Valid values: 1 to 500. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
