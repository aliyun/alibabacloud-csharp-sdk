// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeUsageAreaDistributionStatDataResponseBody : TeaModel {
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
        /// <para>The regional distribution data of usage statistics.</para>
        /// </summary>
        [NameInMap("UsageAreaStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageAreaDistributionStatDataResponseBodyUsageAreaStatList> UsageAreaStatList { get; set; }
        public class DescribeUsageAreaDistributionStatDataResponseBodyUsageAreaStatList : TeaModel {
            /// <summary>
            /// <para>Audio call duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45</para>
            /// </summary>
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public int? AudioCallDuration { get; set; }

            /// <summary>
            /// <para>Region name, such as China.</para>
            /// 
            /// <b>Example:</b>
            /// <para>中国_浙江省</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Total call duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4821</para>
            /// </summary>
            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public int? TotalCallDuration { get; set; }

            /// <summary>
            /// <para>Video call duration, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4776</para>
            /// </summary>
            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public int? VideoCallDuration { get; set; }

        }

    }

}
