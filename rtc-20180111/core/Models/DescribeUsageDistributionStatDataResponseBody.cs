// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageDistributionStatDataResponseBodyUsageStatList> UsageStatList { get; set; }
        public class DescribeUsageDistributionStatDataResponseBodyUsageStatList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public long? AudioCallDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.9782</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONE_TO_FIVE</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10636</para>
            /// </summary>
            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public long? TotalCallDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10585</para>
            /// </summary>
            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public long? VideoCallDuration { get; set; }

        }

    }

}
