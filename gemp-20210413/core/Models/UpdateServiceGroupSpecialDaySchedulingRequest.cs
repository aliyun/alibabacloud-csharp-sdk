// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateServiceGroupSpecialDaySchedulingRequest : TeaModel {
        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 排班日期
        /// </summary>
        [NameInMap("schedulingDate")]
        [Validation(Required=false)]
        public string SchedulingDate { get; set; }

        /// <summary>
        /// 特殊排班信息
        /// </summary>
        [NameInMap("schedulingSpecialDays")]
        [Validation(Required=false)]
        public List<UpdateServiceGroupSpecialDaySchedulingRequestSchedulingSpecialDays> SchedulingSpecialDays { get; set; }
        public class UpdateServiceGroupSpecialDaySchedulingRequestSchedulingSpecialDays : TeaModel {
            /// <summary>
            /// 排班结束时间
            /// </summary>
            [NameInMap("schedulingEndTime")]
            [Validation(Required=false)]
            public string SchedulingEndTime { get; set; }

            /// <summary>
            /// 班次顺序
            /// </summary>
            [NameInMap("schedulingOrder")]
            [Validation(Required=false)]
            public int? SchedulingOrder { get; set; }

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

        }

        /// <summary>
        /// 服务组ID
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

    }

}
