// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreatePowerForecastByFileUrlJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>stationA</para>
        /// </summary>
        [NameInMap("BusinessKey")]
        [Validation(Required=false)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FULL</para>
        /// </summary>
        [NameInMap("DataMode")]
        [Validation(Required=false)]
        public string DataMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>solarInverter</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DAY_AHEAD</para>
        /// </summary>
        [NameInMap("ForecastHorizon")]
        [Validation(Required=false)]
        public string ForecastHorizon { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FIFTEEN_MIN</para>
        /// </summary>
        [NameInMap("Freq")]
        [Validation(Required=false)]
        public string Freq { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://bucket.oss-cn-hangzhou.aliyuncs.com/dir/target_file.csv">https://bucket.oss-cn-hangzhou.aliyuncs.com/dir/target_file.csv</a></para>
        /// </summary>
        [NameInMap("HistoryUrl")]
        [Validation(Required=false)]
        public string HistoryUrl { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public CreatePowerForecastByFileUrlJobRequestLocation Location { get; set; }
        public class CreatePowerForecastByFileUrlJobRequestLocation : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10.123</para>
            /// </summary>
            [NameInMap("Altitude")]
            [Validation(Required=false)]
            public double? Altitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40.027</para>
            /// </summary>
            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public double? Latitude { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120.042</para>
            /// </summary>
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public double? Longitude { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>latest</para>
        /// </summary>
        [NameInMap("ModelVersion")]
        [Validation(Required=false)]
        public string ModelVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-01-01</para>
        /// </summary>
        [NameInMap("RunDate")]
        [Validation(Required=false)]
        public string RunDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>solar</para>
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public string SystemType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>runTime</para>
        /// </summary>
        [NameInMap("TimeColumn")]
        [Validation(Required=false)]
        public string TimeColumn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("ValueColumn")]
        [Validation(Required=false)]
        public string ValueColumn { get; set; }

    }

}
