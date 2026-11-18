// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class QueryResult : TeaModel {
        /// <summary>
        /// <para>The list of returned locations.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<QueryResultData> Data { get; set; }
        public class QueryResultData : TeaModel {
            /// <summary>
            /// <para>The detailed address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No. 22 Fayun Lane, West Lake Scenic Area</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The city code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0571</para>
            /// </summary>
            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The city name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou</para>
            /// </summary>
            [NameInMap("cityName")]
            [Validation(Required=false)]
            public string CityName { get; set; }

            /// <summary>
            /// <para>The distance from the center point in meters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>815</para>
            /// </summary>
            [NameInMap("distanceMeter")]
            [Validation(Required=false)]
            public string DistanceMeter { get; set; }

            /// <summary>
            /// <para>The district code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330106</para>
            /// </summary>
            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            /// <summary>
            /// <para>The district name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xihu District</para>
            /// </summary>
            [NameInMap("districtName")]
            [Validation(Required=false)]
            public string DistrictName { get; set; }

            /// <summary>
            /// <para>The internal identifier of the location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B023B0BI3J</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The list of images.</para>
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<QueryResultDataImages> Images { get; set; }
            public class QueryResultDataImages : TeaModel {
                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Lobby</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The image URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://store.example.com/showpic/e76beb3bedca3fe0375cef12742ea23e">http://store.example.com/showpic/e76beb3bedca3fe0375cef12742ea23e</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The latitude of the location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.234403</para>
            /// </summary>
            [NameInMap("latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            /// <summary>
            /// <para>The longitude of the location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.097327</para>
            /// </summary>
            [NameInMap("longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            /// <summary>
            /// <para>The related business information.</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public QueryResultDataMetadata Metadata { get; set; }
            public class QueryResultDataMetadata : TeaModel {
                /// <summary>
                /// <para>The average spend in CNY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("averageSpend")]
                [Validation(Required=false)]
                public string AverageSpend { get; set; }

                /// <summary>
                /// <para>The business area.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Central Area of West Lake Tourist Zone</para>
                /// </summary>
                [NameInMap("businessArea")]
                [Validation(Required=false)]
                public string BusinessArea { get; set; }

                /// <summary>
                /// <para>The business hours for today.</para>
                /// 
                /// <b>Example:</b>
                /// <para>09:00-18:00</para>
                /// </summary>
                [NameInMap("dailyOpeningHours")]
                [Validation(Required=false)]
                public string DailyOpeningHours { get; set; }

                /// <summary>
                /// <para>The main tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Luxury</para>
                /// </summary>
                [NameInMap("mainTag")]
                [Validation(Required=false)]
                public string MainTag { get; set; }

                /// <summary>
                /// <para>The contact phone numbers. Multiple numbers are separated by vertical bars.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0571-8732****</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The rating.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.7</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public string Score { get; set; }

                /// <summary>
                /// <para>The weekly opening days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Monday to Sunday</para>
                /// </summary>
                [NameInMap("weeklyOpeningDays")]
                [Validation(Required=false)]
                public string WeeklyOpeningDays { get; set; }

            }

            /// <summary>
            /// <para>The location name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Amanfayun Hangzhou</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The province code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330000</para>
            /// </summary>
            [NameInMap("provinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

            /// <summary>
            /// <para>The province name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhejiang Province</para>
            /// </summary>
            [NameInMap("provinceName")]
            [Validation(Required=false)]
            public string ProvinceName { get; set; }

            /// <summary>
            /// <para>The location type code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100102</para>
            /// </summary>
            [NameInMap("typeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            /// <summary>
            /// <para>The location types. Multiple types are separated by vertical bars.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accommodation|Hotel|Five-star hotel</para>
            /// </summary>
            [NameInMap("types")]
            [Validation(Required=false)]
            public string Types { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15A85F99-408F-5BFA-B617-0C7D3E732ABD</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
