// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRtcDurationDataResponseBody : TeaModel {
        [NameInMap("DurationDataPerInterval")]
        [Validation(Required=false)]
        public DescribeRtcDurationDataResponseBodyDurationDataPerInterval DurationDataPerInterval { get; set; }
        public class DescribeRtcDurationDataResponseBodyDurationDataPerInterval : TeaModel {
            [NameInMap("DurationModule")]
            [Validation(Required=false)]
            public List<DescribeRtcDurationDataResponseBodyDurationDataPerIntervalDurationModule> DurationModule { get; set; }
            public class DescribeRtcDurationDataResponseBodyDurationDataPerIntervalDurationModule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("AudioDuration")]
                [Validation(Required=false)]
                public long? AudioDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ContentDuration")]
                [Validation(Required=false)]
                public long? ContentDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-02-04T05:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("TotalDuration")]
                [Validation(Required=false)]
                public long? TotalDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("V1080Duration")]
                [Validation(Required=false)]
                public long? V1080Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("V360Duration")]
                [Validation(Required=false)]
                public long? V360Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("V720Duration")]
                [Validation(Required=false)]
                public long? V720Duration { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
