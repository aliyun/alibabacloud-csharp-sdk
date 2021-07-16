// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateProblemNoticeRequest : TeaModel {
        /// <summary>
        /// 通告类型 PROBLEM_NOTIFY：故障通告 PROBLEM_UPDATE：故障更新 PROBLEM_UPGRADE：故障升级 PROBLEM_DEGRADE：故障降级 PROBLEM_RECOVER：故障恢复 PROBLEM_REISSUE： 故障补发 PROBLEM_CANCEL：故障取消
        /// </summary>
        [NameInMap("problemNotifyType")]
        [Validation(Required=false)]
        public string ProblemNotifyType { get; set; }

        /// <summary>
        /// 故障Id
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 幂等校验Id
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
