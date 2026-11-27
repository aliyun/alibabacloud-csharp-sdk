// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageOsSdkVersionDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of SDK version data in usage statistics.</para>
        /// </summary>
        [NameInMap("UsageOsSdkVersionStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageOsSdkVersionDistributionStatDataResponseBodyUsageOsSdkVersionStatList> UsageOsSdkVersionStatList { get; set; }
        public class DescribeUsageOsSdkVersionDistributionStatDataResponseBodyUsageOsSdkVersionStatList : TeaModel {
            /// <summary>
            /// <para>Audio call duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public long? AudioCallDuration { get; set; }

            /// <summary>
            /// <para>Call duration ratio, represented as a four-decimal number, such as 0.0984.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0984</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <para>SDK version name, such as 1.0.0 or 1.1.1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Operating system, such as iOS or Android.</para>
            /// 
            /// <b>Example:</b>
            /// <para>macOS</para>
            /// </summary>
            [NameInMap("Os")]
            [Validation(Required=false)]
            public string Os { get; set; }

            /// <summary>
            /// <para>Total call duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>476</para>
            /// </summary>
            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public long? TotalCallDuration { get; set; }

            /// <summary>
            /// <para>Video call duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>473</para>
            /// </summary>
            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public long? VideoCallDuration { get; set; }

        }

    }

}
