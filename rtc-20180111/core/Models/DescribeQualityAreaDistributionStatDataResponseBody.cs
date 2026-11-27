// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityAreaDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of quality distribution data.</para>
        /// </summary>
        [NameInMap("QualityStatDataList")]
        [Validation(Required=false)]
        public List<DescribeQualityAreaDistributionStatDataResponseBodyQualityStatDataList> QualityStatDataList { get; set; }
        public class DescribeQualityAreaDistributionStatDataResponseBodyQualityStatDataList : TeaModel {
            /// <summary>
            /// <para>The audio delay, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>347</para>
            /// </summary>
            [NameInMap("AudioDelay")]
            [Validation(Required=false)]
            public long? AudioDelay { get; set; }

            /// <summary>
            /// <para>The high-quality transmission rate of audio, represented by a four-decimal number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9933</para>
            /// </summary>
            [NameInMap("AudioHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string AudioHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <para>The audio stuttering rate, represented by a four-decimal number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0021</para>
            /// </summary>
            [NameInMap("AudioStuckRate")]
            [Validation(Required=false)]
            public string AudioStuckRate { get; set; }

            /// <summary>
            /// <para>The ratio of the call duration, represented by a four-decimal number. For example, 1.0000 indicates that the call duration ratio is 100%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6654</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <para>The success rate of joining a channel within 5 seconds, represented by a four-decimal number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9338</para>
            /// </summary>
            [NameInMap("JoinChannelSucFiveSecRate")]
            [Validation(Required=false)]
            public string JoinChannelSucFiveSecRate { get; set; }

            /// <summary>
            /// <para>The success rate of joining a channel, represented by a four-decimal number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9356</para>
            /// </summary>
            [NameInMap("JoinChannelSucRate")]
            [Validation(Required=false)]
            public string JoinChannelSucRate { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China_Zhejiang Province</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The video delay, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>291</para>
            /// </summary>
            [NameInMap("VideoDelay")]
            [Validation(Required=false)]
            public long? VideoDelay { get; set; }

            /// <summary>
            /// <para>The time taken to render the first video frame, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1363</para>
            /// </summary>
            [NameInMap("VideoFirstPicDuration")]
            [Validation(Required=false)]
            public long? VideoFirstPicDuration { get; set; }

            /// <summary>
            /// <para>The high-quality transmission rate of video, represented by a four-decimal number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9967</para>
            /// </summary>
            [NameInMap("VideoHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string VideoHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <para>The video stuttering rate, represented by a four-decimal number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0058</para>
            /// </summary>
            [NameInMap("VideoStuckRate")]
            [Validation(Required=false)]
            public string VideoStuckRate { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
