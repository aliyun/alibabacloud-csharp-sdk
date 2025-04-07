// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class RgeoCodeResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public RgeoCodeResponseBodyData Data { get; set; }
        public class RgeoCodeResponseBodyData : TeaModel {
            [NameInMap("building")]
            [Validation(Required=false)]
            public RgeoCodeResponseBodyDataBuilding Building { get; set; }
            public class RgeoCodeResponseBodyDataBuilding : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("businessAreas")]
            [Validation(Required=false)]
            public List<RgeoCodeResponseBodyDataBusinessAreas> BusinessAreas { get; set; }
            public class RgeoCodeResponseBodyDataBusinessAreas : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>110108</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>39.996850</para>
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>116.294214</para>
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>010</para>
            /// </summary>
            [NameInMap("cityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("district")]
            [Validation(Required=false)]
            public string District { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110108</para>
            /// </summary>
            [NameInMap("districtCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            [NameInMap("formattedAddress")]
            [Validation(Required=false)]
            public string FormattedAddress { get; set; }

            [NameInMap("neighborhood")]
            [Validation(Required=false)]
            public RgeoCodeResponseBodyDataNeighborhood Neighborhood { get; set; }
            public class RgeoCodeResponseBodyDataNeighborhood : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("streetNumber")]
            [Validation(Required=false)]
            public RgeoCodeResponseBodyDataStreetNumber StreetNumber { get; set; }
            public class RgeoCodeResponseBodyDataStreetNumber : TeaModel {
                [NameInMap("direction")]
                [Validation(Required=false)]
                public string Direction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>289.832</para>
                /// </summary>
                [NameInMap("distanceMeter")]
                [Validation(Required=false)]
                public string DistanceMeter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>39.986542</para>
                /// </summary>
                [NameInMap("latitude")]
                [Validation(Required=false)]
                public string Latitude { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>116.311943</para>
                /// </summary>
                [NameInMap("longitude")]
                [Validation(Required=false)]
                public string Longitude { get; set; }

                [NameInMap("number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("street")]
                [Validation(Required=false)]
                public string Street { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>110108015000</para>
            /// </summary>
            [NameInMap("townCode")]
            [Validation(Required=false)]
            public string TownCode { get; set; }

            [NameInMap("townShip")]
            [Validation(Required=false)]
            public string TownShip { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
