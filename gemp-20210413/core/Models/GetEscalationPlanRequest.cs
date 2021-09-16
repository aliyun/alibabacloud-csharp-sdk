// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetEscalationPlanRequest : TeaModel {
        /// <summary>
        /// 升级计划id
        /// </summary>
        [NameInMap("escalationPlanId")]
        [Validation(Required=false)]
        public long? EscalationPlanId { get; set; }

        /// <summary>
        /// 幂等标识
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
