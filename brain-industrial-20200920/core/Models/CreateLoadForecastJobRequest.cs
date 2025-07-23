// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreateLoadForecastJobRequest : TeaModel {
        [NameInMap("BusinessKey")]
        [Validation(Required=false)]
        public string BusinessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>electricityMeter</para>
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
        /// <para>FIFTEEN_MIN</para>
        /// </summary>
        [NameInMap("Freq")]
        [Validation(Required=false)]
        public string Freq { get; set; }

        [NameInMap("HistoryData")]
        [Validation(Required=false)]
        public List<CreateLoadForecastJobRequestHistoryData> HistoryData { get; set; }
        public class CreateLoadForecastJobRequestHistoryData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-12 00:00:00</para>
            /// </summary>
            [NameInMap("RunTime")]
            [Validation(Required=false)]
            public string RunTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

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
        /// <para>2025-12-12</para>
        /// </summary>
        [NameInMap("RunDate")]
        [Validation(Required=false)]
        public string RunDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>load</para>
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public string SystemType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Asia/Shanghai</para>
        /// </summary>
        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
