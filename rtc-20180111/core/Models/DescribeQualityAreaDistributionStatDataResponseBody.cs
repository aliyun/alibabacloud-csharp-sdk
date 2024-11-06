// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityAreaDistributionStatDataResponseBody : TeaModel {
        [NameInMap("QualityStatDataList")]
        [Validation(Required=false)]
        public List<DescribeQualityAreaDistributionStatDataResponseBodyQualityStatDataList> QualityStatDataList { get; set; }
        public class DescribeQualityAreaDistributionStatDataResponseBodyQualityStatDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>347</para>
            /// </summary>
            [NameInMap("AudioDelay")]
            [Validation(Required=false)]
            public long? AudioDelay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9933</para>
            /// </summary>
            [NameInMap("AudioHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string AudioHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0021</para>
            /// </summary>
            [NameInMap("AudioStuckRate")]
            [Validation(Required=false)]
            public string AudioStuckRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.6654</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9338</para>
            /// </summary>
            [NameInMap("JoinChannelSucFiveSecRate")]
            [Validation(Required=false)]
            public string JoinChannelSucFiveSecRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9356</para>
            /// </summary>
            [NameInMap("JoinChannelSucRate")]
            [Validation(Required=false)]
            public string JoinChannelSucRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>中国_浙江省</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>291</para>
            /// </summary>
            [NameInMap("VideoDelay")]
            [Validation(Required=false)]
            public long? VideoDelay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1363</para>
            /// </summary>
            [NameInMap("VideoFirstPicDuration")]
            [Validation(Required=false)]
            public long? VideoFirstPicDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9967</para>
            /// </summary>
            [NameInMap("VideoHighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string VideoHighQualityTransmissionRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0058</para>
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
