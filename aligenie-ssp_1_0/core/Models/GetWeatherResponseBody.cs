// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetWeatherResponseBody : TeaModel {
        /// <summary>
        /// HttpCode
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetWeatherResponseBodyResult Result { get; set; }
        public class GetWeatherResponseBodyResult : TeaModel {
            [NameInMap("CurrentMeteorology")]
            [Validation(Required=false)]
            public GetWeatherResponseBodyResultCurrentMeteorology CurrentMeteorology { get; set; }
            public class GetWeatherResponseBodyResultCurrentMeteorology : TeaModel {
                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public GetWeatherResponseBodyResultCurrentMeteorologyTemperature Temperature { get; set; }
                public class GetWeatherResponseBodyResultCurrentMeteorologyTemperature : TeaModel {
                    [NameInMap("Current")]
                    [Validation(Required=false)]
                    public string Current { get; set; }

                    [NameInMap("CurrentDesc")]
                    [Validation(Required=false)]
                    public string CurrentDesc { get; set; }

                    [NameInMap("High")]
                    [Validation(Required=false)]
                    public string High { get; set; }

                    [NameInMap("HighDesc")]
                    [Validation(Required=false)]
                    public string HighDesc { get; set; }

                    [NameInMap("Logical")]
                    [Validation(Required=false)]
                    public string Logical { get; set; }

                    [NameInMap("Low")]
                    [Validation(Required=false)]
                    public string Low { get; set; }

                    [NameInMap("LowDesc")]
                    [Validation(Required=false)]
                    public string LowDesc { get; set; }

                }

                [NameInMap("Weather")]
                [Validation(Required=false)]
                public GetWeatherResponseBodyResultCurrentMeteorologyWeather Weather { get; set; }
                public class GetWeatherResponseBodyResultCurrentMeteorologyWeather : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

    }

}
