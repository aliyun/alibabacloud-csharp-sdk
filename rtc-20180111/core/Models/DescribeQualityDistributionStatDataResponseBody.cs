// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityDistributionStatDataResponseBody : TeaModel {
        [NameInMap("QualityStatDataList")]
        [Validation(Required=false)]
        public List<DescribeQualityDistributionStatDataResponseBodyQualityStatDataList> QualityStatDataList { get; set; }
        public class DescribeQualityDistributionStatDataResponseBodyQualityStatDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>554</para>
            /// </summary>
            [NameInMap("AudioDelay")]
            [Validation(Required=false)]
            public long? AudioDelay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9953</para>
            /// </summary>
            [NameInMap("AudioHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string AudioHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0014</para>
            /// </summary>
            [NameInMap("AudioStuckRate")]
            [Validation(Required=false)]
            public string AudioStuckRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0000</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9560</para>
            /// </summary>
            [NameInMap("JoinChannelSucFiveSecRate")]
            [Validation(Required=false)]
            public string JoinChannelSucFiveSecRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9575</para>
            /// </summary>
            [NameInMap("JoinChannelSucRate")]
            [Validation(Required=false)]
            public string JoinChannelSucRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONE_TO_FIVE</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>517</para>
            /// </summary>
            [NameInMap("VideoDelay")]
            [Validation(Required=false)]
            public long? VideoDelay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1299</para>
            /// </summary>
            [NameInMap("VideoFirstPicDuration")]
            [Validation(Required=false)]
            public long? VideoFirstPicDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9981</para>
            /// </summary>
            [NameInMap("VideoHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string VideoHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0264</para>
            /// </summary>
            [NameInMap("VideoStuckRate")]
            [Validation(Required=false)]
            public string VideoStuckRate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
