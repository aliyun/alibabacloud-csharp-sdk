// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeMediaDistributionResponseBody : TeaModel {
        /// <summary>
        /// <para>The distribution list of audio and video media assets. Statistics are displayed based on the statistical period (calendar hour, day, week, or month) within the specified time range.</para>
        /// </summary>
        [NameInMap("MediaDistributionList")]
        [Validation(Required=false)]
        public List<DescribeMediaDistributionResponseBodyMediaDistributionList> MediaDistributionList { get; set; }
        public class DescribeMediaDistributionResponseBodyMediaDistributionList : TeaModel {
            /// <summary>
            /// <para>The number of media assets that match the specified time range within the statistical period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The end time (exclusive) of the statistical period. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-14T00:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time (inclusive) of the statistical period. Format: yyyy-MM-ddTHH:mm:ssZ (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-13T00:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of audio and video media assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
