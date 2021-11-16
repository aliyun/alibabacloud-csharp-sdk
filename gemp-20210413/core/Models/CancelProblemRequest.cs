// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CancelProblemRequest : TeaModel {
        /// <summary>
        /// 取消原因
        /// </summary>
        [NameInMap("cancelReason")]
        [Validation(Required=false)]
        public long? CancelReason { get; set; }

        /// <summary>
        /// 取消原因描述
        /// </summary>
        [NameInMap("cancelReasonDescription")]
        [Validation(Required=false)]
        public string CancelReasonDescription { get; set; }

        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 故障id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// PROBLEM_NOTIFY	通告类型 PROBLEM_NOTIFY：故障通告 PROBLEM_UPDATE：故障更新 PROBLEM_UPGRADE：故障升级 PROBLEM_DEGRADE：故障降级 PROBLEM_RECOVER：故障恢复 PROBLEM_REISSUE： 故障补发 PROBLEM_CANCEL：故障取消
        /// </summary>
        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public long? ProblemNotifyType { get; set; }

    }

}
