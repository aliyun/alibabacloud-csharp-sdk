// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeIceDurPeriodByDaySubTypeResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 任务信息列表
        /// </summary>
        [NameInMap("JobInfoList")]
        [Validation(Required=false)]
        public List<DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoList> JobInfoList { get; set; }
        public class DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoList : TeaModel {
            /// <summary>
            /// 任务总时长,单位分钟
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// 日期时间戳
            /// </summary>
            [NameInMap("DateTs")]
            [Validation(Required=false)]
            public long? DateTs { get; set; }

            /// <summary>
            /// 子任务信息列表
            /// </summary>
            [NameInMap("SubJobInfoList")]
            [Validation(Required=false)]
            public List<DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoListSubJobInfoList> SubJobInfoList { get; set; }
            public class DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoListSubJobInfoList : TeaModel {
                /// <summary>
                /// 子任务类型
                /// </summary>
                [NameInMap("SubJobType")]
                [Validation(Required=false)]
                public string SubJobType { get; set; }

                /// <summary>
                /// 子任务时长
                /// </summary>
                [NameInMap("SubJobDuration")]
                [Validation(Required=false)]
                public long? SubJobDuration { get; set; }

            }

        }

    }

}
