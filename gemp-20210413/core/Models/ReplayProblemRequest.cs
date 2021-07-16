// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ReplayProblemRequest : TeaModel {
        /// <summary>
        /// 故障ID
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 复盘负责人ID
        /// </summary>
        [NameInMap("replayDutyUserId")]
        [Validation(Required=false)]
        public long? ReplayDutyUserId { get; set; }

        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
