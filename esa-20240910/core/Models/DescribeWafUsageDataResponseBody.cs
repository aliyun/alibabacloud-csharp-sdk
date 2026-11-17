// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeWafUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time of the retrieved data. The time is displayed in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-10T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D2***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the data to retrieve. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-10T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("UsageData")]
        [Validation(Required=false)]
        public List<DescribeWafUsageDataResponseBodyUsageData> UsageData { get; set; }
        public class DescribeWafUsageDataResponseBodyUsageData : TeaModel {
            /// <summary>
            /// <para>The number of normal access requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("AccessCount")]
            [Validation(Required=false)]
            public long? AccessCount { get; set; }

            /// <summary>
            /// <para>The number of blocked requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BlockCount")]
            [Validation(Required=false)]
            public long? BlockCount { get; set; }

            /// <summary>
            /// <para>The number of observed requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("ObserveCount")]
            [Validation(Required=false)]
            public long? ObserveCount { get; set; }

            /// <summary>
            /// <para>The name of the domain name record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The start time of the time slice.</para>
            /// <para>The time is displayed in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-10T00:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

        }

    }

}
