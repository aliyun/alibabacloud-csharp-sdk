// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeUsageAreaDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// 用量统计地域分布数据
        /// </summary>
        [NameInMap("UsageAreaStatList")]
        [Validation(Required=false)]
        public List<DescribeUsageAreaDistributionStatDataResponseBodyUsageAreaStatList> UsageAreaStatList { get; set; }
        public class DescribeUsageAreaDistributionStatDataResponseBodyUsageAreaStatList : TeaModel {
            /// <summary>
            /// 地域名称，如中国
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 音频通话时长，单位分钟
            /// </summary>
            [NameInMap("AudioCallDuration")]
            [Validation(Required=false)]
            public int? AudioCallDuration { get; set; }

            /// <summary>
            /// 视频通话时长，单位分钟
            /// </summary>
            [NameInMap("VideoCallDuration")]
            [Validation(Required=false)]
            public int? VideoCallDuration { get; set; }

            /// <summary>
            /// 总通话时长，单位分钟
            /// </summary>
            [NameInMap("TotalCallDuration")]
            [Validation(Required=false)]
            public int? TotalCallDuration { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
