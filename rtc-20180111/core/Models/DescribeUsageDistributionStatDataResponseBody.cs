// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231470C1-ACFB-4C9F-844F-4CFE1E3804C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of usage statistics.</para>
        /// </summary>
        [NameInMap("UsageStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageDistributionStatDataResponseBodyUsageStatList> UsageStatList { get; set; }
        public class DescribeUsageDistributionStatDataResponseBodyUsageStatList : TeaModel {
            /// <summary>
            /// <para>The duration of audio calls, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public long? AudioCallDuration { get; set; }

            /// <summary>
            /// <para>The ratio of the call duration, represented by four decimal places, such as 0.9782.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9782</para>
            /// </summary>
            [NameInMap("CallDurationRatio")]
            [Validation(Required=false)]
            public string CallDurationRatio { get; set; }

            /// <summary>
            /// <para>The statistical dimension. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>When StatDim is set to CHANNEL_ONLINE, valid values are <b>ONE_TO_FIVE</b> (1 to 5 users), <b>SIX_TO_TEN</b> (6 to 10 users), <b>ELEVEN_TO_TWENTY</b> (11 to 20 users), <b>TWENTY_ONE_TO_FIFTY</b> (21 to 50 users), and <b>ABOVE_FIFTY</b> (more than 50 users).  </description></item>
            /// <item><description>When StatDim is set to NETWORK, valid values are <b>WiFi</b>, <b>4G</b>, and others.  </description></item>
            /// <item><description>When StatDim is set to OS, valid values are <b>iOS</b>, <b>Android</b>, and others.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONE_TO_FIVE</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The total duration of calls, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10636</para>
            /// </summary>
            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public long? TotalCallDuration { get; set; }

            /// <summary>
            /// <para>The duration of video calls, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10585</para>
            /// </summary>
            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public long? VideoCallDuration { get; set; }

        }

    }

}
