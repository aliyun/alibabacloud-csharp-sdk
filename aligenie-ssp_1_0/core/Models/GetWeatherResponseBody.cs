// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class GetWeatherResponseBody : TeaModel {
        /// <summary>
        /// <para>HttpCode</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>调用成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7E2****B7C94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>model data</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetWeatherResponseBodyResult Result { get; set; }
        public class GetWeatherResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Current weather</para>
            /// </summary>
            [NameInMap("CurrentMeteorology")]
            [Validation(Required=false)]
            public GetWeatherResponseBodyResultCurrentMeteorology CurrentMeteorology { get; set; }
            public class GetWeatherResponseBodyResultCurrentMeteorology : TeaModel {
                /// <summary>
                /// <para>Temperature</para>
                /// </summary>
                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public GetWeatherResponseBodyResultCurrentMeteorologyTemperature Temperature { get; set; }
                public class GetWeatherResponseBodyResultCurrentMeteorologyTemperature : TeaModel {
                    /// <summary>
                    /// <para>Current temperature value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>36</para>
                    /// </summary>
                    [NameInMap("Current")]
                    [Validation(Required=false)]
                    public string Current { get; set; }

                    /// <summary>
                    /// <para>Description of the current temperature value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>36度</para>
                    /// </summary>
                    [NameInMap("CurrentDesc")]
                    [Validation(Required=false)]
                    public string CurrentDesc { get; set; }

                    /// <summary>
                    /// <para>Maximum temperature value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>37</para>
                    /// </summary>
                    [NameInMap("High")]
                    [Validation(Required=false)]
                    public string High { get; set; }

                    /// <summary>
                    /// <para>Description of the maximum temperature value</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>37度</para>
                    /// </summary>
                    [NameInMap("HighDesc")]
                    [Validation(Required=false)]
                    public string HighDesc { get; set; }

                    /// <summary>
                    /// <para>Temperature with logic, as follows:</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>41</para>
                    /// </summary>
                    [NameInMap("Logical")]
                    [Validation(Required=false)]
                    public string Logical { get; set; }

                    /// <summary>
                    /// <para>Lowest temperature</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>28</para>
                    /// </summary>
                    [NameInMap("Low")]
                    [Validation(Required=false)]
                    public string Low { get; set; }

                    /// <summary>
                    /// <para>Description of the lowest temperature</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>28度</para>
                    /// </summary>
                    [NameInMap("LowDesc")]
                    [Validation(Required=false)]
                    public string LowDesc { get; set; }

                }

                /// <summary>
                /// <para>Daytime weather</para>
                /// </summary>
                [NameInMap("Weather")]
                [Validation(Required=false)]
                public GetWeatherResponseBodyResultCurrentMeteorologyWeather Weather { get; set; }
                public class GetWeatherResponseBodyResultCurrentMeteorologyWeather : TeaModel {
                    /// <summary>
                    /// <para>Weather code: for example, &quot;000,100&quot;</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>000</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Weather name description: &quot;Sunny (000), Multicloud (100), Overcast (101), Rain (200), Light rain (201), Light to moderate rain (202), Moderate rain (203), Moderate to heavy rain (204), Heavy rain (205), Heavy to storm rain (206), Storm rain (207), Heavy storm rain (209), Severe storm rain (211), Showers (212), Thunderstorms (213), Freezing rain (214), Snow (300), Sleet (301), Snow showers (302), Light snow (303), Light to moderate snow (304), Moderate snow (305), Heavy snow (307), Blizzard (309), Fog (400), Dust (501), Sand blowing (502), Sandstorm (503), Severe sandstorm (504), Mostly sunny (000), Partly cloudy (100), Light showers (212), Lightning (213), Ice pellets (214), Thunderstorms with hail (215), Light snow showers (302), Freezing fog (400), Haze (500), Dust whirls (502), Localized showers (212), Thunderstorm (213), Ice needles (214), Hail (215), Intense showers (212)&quot;</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>晴</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

    }

}
