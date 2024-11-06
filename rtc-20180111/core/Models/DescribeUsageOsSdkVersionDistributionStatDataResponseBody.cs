// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageOsSdkVersionDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageOsSdkVersionStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageOsSdkVersionDistributionStatDataResponseBodyUsageOsSdkVersionStatList> UsageOsSdkVersionStatList { get; set; }
        public class DescribeUsageOsSdkVersionDistributionStatDataResponseBodyUsageOsSdkVersionStatList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public long? AudioCallDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0984</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>macOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>476</para>
            /// </summary>
            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public long? TotalCallDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>473</para>
            /// </summary>
            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public long? VideoCallDuration { get; set; }

        }

    }

}
