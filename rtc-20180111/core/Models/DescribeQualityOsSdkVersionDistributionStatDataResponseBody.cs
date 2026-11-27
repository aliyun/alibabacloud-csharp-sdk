// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityOsSdkVersionDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data for operating systems and SDK versions in quality statistics.</para>
        /// </summary>
        [NameInMap("QualityOsSdkVersionStatDataList")]
        [Validation(Required=false)]
        public List<DescribeQualityOsSdkVersionDistributionStatDataResponseBodyQualityOsSdkVersionStatDataList> QualityOsSdkVersionStatDataList { get; set; }
        public class DescribeQualityOsSdkVersionDistributionStatDataResponseBodyQualityOsSdkVersionStatDataList : TeaModel {
            /// <summary>
            /// <para>The audio delay, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>248</para>
            /// </summary>
            [NameInMap("AudioDelay")]
            [Validation(Required=false)]
            public long? AudioDelay { get; set; }

            /// <summary>
            /// <para>The audio high-quality transmission rate, represented by four decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9987</para>
            /// </summary>
            [NameInMap("AudioHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string AudioHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <para>The audio stuttering rate, represented by four decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0011</para>
            /// </summary>
            [NameInMap("AudioStuckRate")]
            [Validation(Required=false)]
            public string AudioStuckRate { get; set; }

            /// <summary>
            /// <para>The call duration ratio, represented by four decimal places. For example, 1.0000 indicates that the call duration ratio is 100%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0984</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <para>The 5-second channel join success rate, represented by four decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8276</para>
            /// </summary>
            [NameInMap("JoinChannelSucFiveSecRate")]
            [Validation(Required=false)]
            public string JoinChannelSucFiveSecRate { get; set; }

            /// <summary>
            /// <para>The channel join success rate, represented by four decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.8276</para>
            /// </summary>
            [NameInMap("JoinChannelSucRate")]
            [Validation(Required=false)]
            public string JoinChannelSucRate { get; set; }

            /// <summary>
            /// <para>The SDK version name, such as 1.0.0 or 1.1.1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.1.0.210316.dev--release/rtcsdk_v2.1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The operating system name, such as iOS or Android.</para>
            /// 
            /// <b>Example:</b>
            /// <para>macOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>The video delay, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>333</para>
            /// </summary>
            [NameInMap("VideoDelay")]
            [Validation(Required=false)]
            public long? VideoDelay { get; set; }

            /// <summary>
            /// <para>The first video frame rendering time, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5643</para>
            /// </summary>
            [NameInMap("VideoFirstPicDuration")]
            [Validation(Required=false)]
            public long? VideoFirstPicDuration { get; set; }

            /// <summary>
            /// <para>The video high-quality transmission rate, represented by four decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9997</para>
            /// </summary>
            [NameInMap("VideoHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string VideoHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <para>The video stuttering rate, represented by four decimal places.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0054</para>
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
