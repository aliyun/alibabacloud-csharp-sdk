// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// 频道分布统计列表。
        /// </summary>
        [NameInMap("StatList")]
        [Validation(Required=false)]
        public List<DescribeChannelDistributionStatDataResponseBodyStatList> StatList { get; set; }
        public class DescribeChannelDistributionStatDataResponseBodyStatList : TeaModel {
            /// <summary>
            /// 统计维度。
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 通信人数。
            /// </summary>
            [NameInMap("CallUserCount")]
            [Validation(Required=false)]
            public int? CallUserCount { get; set; }

            /// <summary>
            /// 通信人数占比，用小数表示，例如1.0000表示通信人数占比为100%。
            /// </summary>
            [NameInMap("CallUserRatio")]
            [Validation(Required=false)]
            public string CallUserRatio { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
