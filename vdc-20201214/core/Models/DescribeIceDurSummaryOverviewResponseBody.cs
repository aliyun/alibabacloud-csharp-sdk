// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeIceDurSummaryOverviewResponseBody : TeaModel {
        /// <summary>
        /// 任务信息
        /// </summary>
        [NameInMap("JobInfoList")]
        [Validation(Required=false)]
        public List<DescribeIceDurSummaryOverviewResponseBodyJobInfoList> JobInfoList { get; set; }
        public class DescribeIceDurSummaryOverviewResponseBodyJobInfoList : TeaModel {
            /// <summary>
            /// 任务时长
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 作业类型
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// 时间维度
            /// </summary>
            [NameInMap("TimeRange")]
            [Validation(Required=false)]
            public string TimeRange { get; set; }

        }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
