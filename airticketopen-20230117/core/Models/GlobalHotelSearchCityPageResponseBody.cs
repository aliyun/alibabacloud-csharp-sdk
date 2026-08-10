// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelSearchCityPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GlobalHotelSearchCityPageResponseBodyData Data { get; set; }
        public class GlobalHotelSearchCityPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of cities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Cities")]
            [Validation(Required=false)]
            public List<GlobalHotelSearchCityPageResponseBodyDataCities> Cities { get; set; }
            public class GlobalHotelSearchCityPageResponseBodyDataCities : TeaModel {
                /// <summary>
                /// <para>The Chinese name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京市</para>
                /// </summary>
                [NameInMap("CnName")]
                [Validation(Required=false)]
                public string CnName { get; set; }

                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <para>The country code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>156</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public int? Country { get; set; }

                /// <summary>
                /// <para>The country code in ISO 3166-1 alpha-2 format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>The English name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Beijing</para>
                /// </summary>
                [NameInMap("EnName")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                /// <summary>
                /// <para>The administrative level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// <para>The parent city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110000</para>
                /// </summary>
                [NameInMap("ParentCode")]
                [Validation(Required=false)]
                public int? ParentCode { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether there is a next page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CityCodeRequired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>City code cannot be empty</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>TraceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>TraceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
