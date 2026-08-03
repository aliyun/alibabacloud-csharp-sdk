// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class SearchCityPageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchCityPageResponseBodyData Data { get; set; }
        public class SearchCityPageResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("Cities")]
            [Validation(Required=false)]
            public List<SearchCityPageResponseBodyDataCities> Cities { get; set; }
            public class SearchCityPageResponseBodyDataCities : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>北京市</para>
                /// </summary>
                [NameInMap("CnName")]
                [Validation(Required=false)]
                public string CnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>156</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public int? Country { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Beijing</para>
                /// </summary>
                [NameInMap("EnName")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>110000</para>
                /// </summary>
                [NameInMap("ParentCode")]
                [Validation(Required=false)]
                public int? ParentCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public int? Region { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CityCodeRequired</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>城市编码不能为空</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>260E4F99-983D-1919-834C-5C42E98E5B2B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TraceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
