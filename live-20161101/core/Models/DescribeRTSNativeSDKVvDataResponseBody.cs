// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKVvDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The end of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of playbacks and the number of successful playbacks at each interval.</para>
        /// </summary>
        [NameInMap("VvData")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKVvDataResponseBodyVvData> VvData { get; set; }
        public class DescribeRTSNativeSDKVvDataResponseBodyVvData : TeaModel {
            /// <summary>
            /// <para>The timestamp of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <para>The number of successful playbacks within the period of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("VvSuccess")]
            [Validation(Required=false)]
            public string VvSuccess { get; set; }

            /// <summary>
            /// <para>The total number of playbacks within the period of time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("VvTotal")]
            [Validation(Required=false)]
            public string VvTotal { get; set; }

        }

    }

}
