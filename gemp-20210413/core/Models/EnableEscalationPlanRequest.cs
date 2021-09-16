// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class EnableEscalationPlanRequest : TeaModel {
        /// <summary>
        /// 升级计划ID
        /// </summary>
        [NameInMap("escalationPlanId")]
        [Validation(Required=false)]
        public long? EscalationPlanId { get; set; }

        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
