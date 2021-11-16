// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupSpecialPersonSchedulingResponseBody : TeaModel {
        /// <summary>
        /// 人员排班信息
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetServiceGroupSpecialPersonSchedulingResponseBodyData> Data { get; set; }
        public class GetServiceGroupSpecialPersonSchedulingResponseBodyData : TeaModel {
            /// <summary>
            /// 排班日期
            /// </summary>
            [NameInMap("schedulingDate")]
            [Validation(Required=false)]
            public string SchedulingDate { get; set; }

            /// <summary>
            /// 排班结束时间
            /// </summary>
            [NameInMap("schedulingEndTime")]
            [Validation(Required=false)]
            public string SchedulingEndTime { get; set; }

            /// <summary>
            /// 排班开始时间
            /// </summary>
            [NameInMap("schedulingStartTime")]
            [Validation(Required=false)]
            public string SchedulingStartTime { get; set; }

            /// <summary>
            /// 排班用户ID
            /// </summary>
            [NameInMap("schedulingUserId")]
            [Validation(Required=false)]
            public long? SchedulingUserId { get; set; }

            /// <summary>
            /// 服务组id
            /// </summary>
            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

            /// <summary>
            /// 服务组名字
            /// </summary>
            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
