// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class PlaceSearchNovaResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PlaceSearchNovaResponseBodyData> Data { get; set; }
        public class PlaceSearchNovaResponseBodyData : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>010</para>
            /// </summary>
            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("cityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>445</para>
            /// </summary>
            [NameInMap("distanceMeter")]
            [Validation(Required=false)]
            public string DistanceMeter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110105</para>
            /// </summary>
            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            [NameInMap("districtName")]
            [Validation(Required=false)]
            public string DistrictName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>34360</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("images")]
            [Validation(Required=false)]
            public List<PlaceSearchNovaResponseBodyDataImages> Images { get; set; }
            public class PlaceSearchNovaResponseBodyDataImages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://aos-comment.amap.com/B000A8UNZV/comment/f0a5ca9b58a31f63f8af51f459f75e4b_2048_2048_80.jpg">https://aos-comment.amap.com/B000A8UNZV/comment/f0a5ca9b58a31f63f8af51f459f75e4b_2048_2048_80.jpg</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>39.990039</para>
            /// </summary>
            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>116.482145</para>
            /// </summary>
            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("metadata")]
            [Validation(Required=false)]
            public PlaceSearchNovaResponseBodyDataMetadata Metadata { get; set; }
            public class PlaceSearchNovaResponseBodyDataMetadata : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>78</para>
                /// </summary>
                [NameInMap("averageSpend")]
                [Validation(Required=false)]
                public string AverageSpend { get; set; }

                [NameInMap("businessArea")]
                [Validation(Required=false)]
                public string BusinessArea { get; set; }

                [NameInMap("dailyOpeningHours")]
                [Validation(Required=false)]
                public string DailyOpeningHours { get; set; }

                [NameInMap("mainTag")]
                [Validation(Required=false)]
                public string MainTag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>010-83847583</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;value\&quot;:\&quot;nttd\&quot;,\&quot;key\&quot;:\&quot;owner\&quot;}]</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                [NameInMap("weeklyOpeningDays")]
                [Validation(Required=false)]
                public string WeeklyOpeningDays { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hydro-project/hydro-res-auth</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110000</para>
            /// </summary>
            [NameInMap("provinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

            [NameInMap("provinceName")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110200</para>
            /// </summary>
            [NameInMap("typeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            [NameInMap("types")]
            [Validation(Required=false)]
            public string Types { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Access was denied, message: Unauthorized.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
