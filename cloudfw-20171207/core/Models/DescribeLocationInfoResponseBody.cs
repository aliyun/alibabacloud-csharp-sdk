// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeLocationInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of regions in China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340</para>
        /// </summary>
        [NameInMap("CnCount")]
        [Validation(Required=false)]
        public int? CnCount { get; set; }

        /// <summary>
        /// <para>The list of regions in China.</para>
        /// </summary>
        [NameInMap("CnList")]
        [Validation(Required=false)]
        public List<DescribeLocationInfoResponseBodyCnList> CnList { get; set; }
        public class DescribeLocationInfoResponseBodyCnList : TeaModel {
            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3301</para>
            /// </summary>
            [NameInMap("LocId")]
            [Validation(Required=false)]
            public string LocId { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou City</para>
            /// </summary>
            [NameInMap("LocName")]
            [Validation(Required=false)]
            public string LocName { get; set; }

        }

        /// <summary>
        /// <para>The information about provinces and cities in China.</para>
        /// </summary>
        [NameInMap("CnProvinceList")]
        [Validation(Required=false)]
        public List<DescribeLocationInfoResponseBodyCnProvinceList> CnProvinceList { get; set; }
        public class DescribeLocationInfoResponseBodyCnProvinceList : TeaModel {
            /// <summary>
            /// <para>The list of city codes.</para>
            /// </summary>
            [NameInMap("Cities")]
            [Validation(Required=false)]
            public List<DescribeLocationInfoResponseBodyCnProvinceListCities> Cities { get; set; }
            public class DescribeLocationInfoResponseBodyCnProvinceListCities : TeaModel {
                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("LocId")]
                [Validation(Required=false)]
                public string LocId { get; set; }

                /// <summary>
                /// <para>The name of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("LocName")]
                [Validation(Required=false)]
                public string LocName { get; set; }

            }

            /// <summary>
            /// <para>The name of the province.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang</para>
            /// </summary>
            [NameInMap("ProvinceName")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

        }

        /// <summary>
        /// <para>The number of regions outside China.</para>
        /// 
        /// <b>Example:</b>
        /// <para>238</para>
        /// </summary>
        [NameInMap("OverseasCount")]
        [Validation(Required=false)]
        public int? OverseasCount { get; set; }

        /// <summary>
        /// <para>The list of regions outside China.</para>
        /// </summary>
        [NameInMap("OverseasList")]
        [Validation(Required=false)]
        public List<DescribeLocationInfoResponseBodyOverseasList> OverseasList { get; set; }
        public class DescribeLocationInfoResponseBodyOverseasList : TeaModel {
            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>US</para>
            /// </summary>
            [NameInMap("LocId")]
            [Validation(Required=false)]
            public string LocId { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>United States</para>
            /// </summary>
            [NameInMap("LocName")]
            [Validation(Required=false)]
            public string LocName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD3BE433-FAB0-55D8-918A-69B306****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
