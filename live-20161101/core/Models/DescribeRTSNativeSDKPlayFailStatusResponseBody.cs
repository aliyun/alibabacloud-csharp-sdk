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
        /// <para>The end of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of error status codes at each interval.</para>
        /// </summary>
        [NameInMap("PlayFailStatus")]
        [Validation(Required=false)]
        public List<DescribeRTSNativeSDKPlayFailStatusResponseBodyPlayFailStatus> PlayFailStatus { get; set; }
        public class DescribeRTSNativeSDKPlayFailStatusResponseBodyPlayFailStatus : TeaModel {
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
            /// <para>The status code that indicates failed DNS resolution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("V20001")]
            [Validation(Required=false)]
            public string V20001 { get; set; }

            /// <summary>
            /// <para>The status code that indicates failed authentication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("V20002")]
            [Validation(Required=false)]
            public string V20002 { get; set; }

            /// <summary>
            /// <para>The status code that indicates a connection signaling timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("V20011")]
            [Validation(Required=false)]
            public string V20011 { get; set; }

            /// <summary>
            /// <para>The status code that indicates a subscription signaling error.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("V20012")]
            [Validation(Required=false)]
            public string V20012 { get; set; }

            /// <summary>
            /// <para>The status code indicating that the stream to subscribe to does not exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("V20013")]
            [Validation(Required=false)]
            public string V20013 { get; set; }

            /// <summary>
            /// <para>The status code that indicates a media packet collection timeout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("V20052")]
            [Validation(Required=false)]
            public string V20052 { get; set; }

        }

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

    }

}
