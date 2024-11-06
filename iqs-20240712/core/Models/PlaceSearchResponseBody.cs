// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class PlaceSearchResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<PlaceSearchResponseBodyData> Data { get; set; }
        public class PlaceSearchResponseBodyData : TeaModel {
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("cityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            [NameInMap("districtName")]
            [Validation(Required=false)]
            public string DistrictName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100936</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("images")]
            [Validation(Required=false)]
            public List<PlaceSearchResponseBodyDataImages> Images { get; set; }
            public class PlaceSearchResponseBodyDataImages : TeaModel {
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://store.is.autonavi.com/showpic/d3dd18fa5fb617d02cf7f1aabae80b78">http://store.is.autonavi.com/showpic/d3dd18fa5fb617d02cf7f1aabae80b78</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("metadata")]
            [Validation(Required=false)]
            public PlaceSearchResponseBodyDataMetadata Metadata { get; set; }
            public class PlaceSearchResponseBodyDataMetadata : TeaModel {
                [NameInMap("businessArea")]
                [Validation(Required=false)]
                public string BusinessArea { get; set; }

                [NameInMap("dailyOpeningHours")]
                [Validation(Required=false)]
                public string DailyOpeningHours { get; set; }

                [NameInMap("mainTag")]
                [Validation(Required=false)]
                public string MainTag { get; set; }

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

            [NameInMap("provinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

            [NameInMap("provinceName")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

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
        /// <para>Access was denied, message: No such namespace namespaces/general-perf-cn-shenzhen-e-default.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
