// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of quality statistics data.</para>
        /// </summary>
        [NameInMap("QualityStatDataList")]
        [Validation(Required=false)]
        public List<DescribeQualityDistributionStatDataResponseBodyQualityStatDataList> QualityStatDataList { get; set; }
        public class DescribeQualityDistributionStatDataResponseBodyQualityStatDataList : TeaModel {
            /// <summary>
            /// <para>Audio delay, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>554</para>
            /// </summary>
            [NameInMap("AudioDelay")]
            [Validation(Required=false)]
            public long? AudioDelay { get; set; }

            /// <summary>
            /// <para>Audio high-quality transmission rate, represented as a four-digit decimal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9953</para>
            /// </summary>
            [NameInMap("AudioHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string AudioHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <para>The Audio Lag Rate, represented as a four-digit decimal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0014</para>
            /// </summary>
            [NameInMap("AudioStuckRate")]
            [Validation(Required=false)]
            public string AudioStuckRate { get; set; }

            /// <summary>
            /// <para>The call duration ratio, represented as a four-digit decimal. For example, 1.0000 indicates that the call duration accounts for 100% of the total usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0000</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <para>Five-second channel join success rate, represented as a four-digit decimal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9560</para>
            /// </summary>
            [NameInMap("JoinChannelSucFiveSecRate")]
            [Validation(Required=false)]
            public string JoinChannelSucFiveSecRate { get; set; }

            /// <summary>
            /// <para>The channel join success rate, represented as a four-digit decimal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9575</para>
            /// </summary>
            [NameInMap("JoinChannelSucRate")]
            [Validation(Required=false)]
            public string JoinChannelSucRate { get; set; }

            /// <summary>
            /// <para>Statistical dimension. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description>When StatDim is CHANNELONLINE: <b>ONE_TO_FIVE</b> (1–5 participants), <b>SIX_TO_TEN</b> (6–10 participants), <b>ELEVEN_TO_TWENTY</b> (11–20 participants), <b>TWENTYONE_TO_FIFTY</b> (21–50 participants), <b>ABOVE_FIFTY</b> (more than 50 participants).  </description></item>
            /// <item><description>When StatDim is NETWORK: <b>WiFi</b>, <b>4G</b>, etc.  </description></item>
            /// <item><description>When StatDim is OS: <b>iOS</b>, <b>Android</b>, etc.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE_TO_FIVE</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Video delay, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>517</para>
            /// </summary>
            [NameInMap("VideoDelay")]
            [Validation(Required=false)]
            public long? VideoDelay { get; set; }

            /// <summary>
            /// <para>Time to first video frame, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1299</para>
            /// </summary>
            [NameInMap("VideoFirstPicDuration")]
            [Validation(Required=false)]
            public long? VideoFirstPicDuration { get; set; }

            /// <summary>
            /// <para>Video high-quality transmission rate, represented as a four-digit decimal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9981</para>
            /// </summary>
            [NameInMap("VideoHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string VideoHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <para>The Video Lag Rate, represented as a four-digit decimal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0264</para>
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
