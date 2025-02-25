// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeDDoSBpsListResponseBody : TeaModel {
        /// <summary>
        /// <para>The interval between each piece of data, in seconds.</para>
        /// <para>Generated based on the interval between StartTime and EndTime: less than 1 hour, 60s; 1 hour or more but less than 1 day, 300s; 1 day or more but less than a week, 1800s; 1 week or more, 3600s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public int? DataInterval { get; set; }

        /// <summary>
        /// <para>A list of network bandwidth data for each time interval.</para>
        /// </summary>
        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeDDoSBpsListResponseBodyDataModule> DataModule { get; set; }
        public class DescribeDDoSBpsListResponseBodyDataModule : TeaModel {
            /// <summary>
            /// <para>Attack bandwidth, in bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9000000000</para>
            /// </summary>
            [NameInMap("AttackBps")]
            [Validation(Required=false)]
            public long? AttackBps { get; set; }

            /// <summary>
            /// <para>Attack PPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9000000</para>
            /// </summary>
            [NameInMap("AttackPps")]
            [Validation(Required=false)]
            public long? AttackPps { get; set; }

            /// <summary>
            /// <para>Normal business bandwidth, in bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000000</para>
            /// </summary>
            [NameInMap("NormalBps")]
            [Validation(Required=false)]
            public long? NormalBps { get; set; }

            /// <summary>
            /// <para>Normal business PPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("NormalPps")]
            [Validation(Required=false)]
            public long? NormalPps { get; set; }

            /// <summary>
            /// <para>The timestamp of this data, in ISO8601 format, using UTC+0, formatted as: yyyy-MM-ddTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-14T17:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <para>Total bandwidth, in bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000000000</para>
            /// </summary>
            [NameInMap("TotalBps")]
            [Validation(Required=false)]
            public long? TotalBps { get; set; }

            /// <summary>
            /// <para>Total PPS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000</para>
            /// </summary>
            [NameInMap("TotalPps")]
            [Validation(Required=false)]
            public long? TotalPps { get; set; }

        }

        /// <summary>
        /// <para>The end time for fetching data. In ISO8601 format, using UTC+0, formatted as: yyyy-MM-ddTHH:mm:ssZ.</para>
        /// <para>The end time must be later than the start time, and the span between start and end times should not exceed 31 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-18T06:19:42Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time for fetching data. In ISO8601 format, using UTC, formatted as: YYYY-MM-DDThh:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-05-14T17:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
