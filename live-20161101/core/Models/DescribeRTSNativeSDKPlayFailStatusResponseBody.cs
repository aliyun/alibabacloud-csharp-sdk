// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeRTSNativeSDKPlayFailStatusResponseBody : TeaModel {
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
        /// <para>The end time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The total number of error status codes for each time interval.</para>
        /// </summary>
        [NameInMap("PlayFailStatus")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKPlayFailStatusResponseBodyPlayFailStatus> PlayFailStatus { get; set; }
        public class DescribeRTSNativeSDKPlayFailStatusResponseBodyPlayFailStatus : TeaModel {
            /// <summary>
            /// <para>The beginning of the time interval. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-10T20:00:00Z</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public string TimeStamp { get; set; }

            /// <summary>
            /// <para>DNS resolution failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("V20001")]
            [Validation(Required=false)]
            public string V20001 { get; set; }

            /// <summary>
            /// <para>Authentication failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("V20002")]
            [Validation(Required=false)]
            public string V20002 { get; set; }

            /// <summary>
            /// <para>Connection signaling timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("V20011")]
            [Validation(Required=false)]
            public string V20011 { get; set; }

            /// <summary>
            /// <para>Subscription signaling error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("V20012")]
            [Validation(Required=false)]
            public string V20012 { get; set; }

            /// <summary>
            /// <para>Subscribed stream does not exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("V20013")]
            [Validation(Required=false)]
            public string V20013 { get; set; }

            /// <summary>
            /// <para>Media packet receiving timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("V20052")]
            [Validation(Required=false)]
            public string V20052 { get; set; }

        }

        /// <summary>
        /// <para>Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
