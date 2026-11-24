// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeMediaDistributionResponseBody : TeaModel {
        /// <summary>
        /// <para>The distribution list of audio and video media assets. The list is displayed based on the statistical periods such as natural hours, days, weeks, and months of the start time and end time.</para>
        /// </summary>
        [NameInMap("MediaDistributionList")]
        [Validation(Required=false)]
        public List<DescribeMediaDistributionResponseBodyMediaDistributionList> MediaDistributionList { get; set; }
        public class DescribeMediaDistributionResponseBodyMediaDistributionList : TeaModel {
            /// <summary>
            /// <para>The number of media assets that match the specified time range within the natural statistical period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The end time of the statistical period. The end time is not included. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-14T00:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the statistical period. The start time is included. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
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
