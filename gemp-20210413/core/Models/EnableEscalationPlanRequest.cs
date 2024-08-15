// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class EnableEscalationPlanRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("escalationPlanId")]
        [Validation(Required=false)]
        public long? EscalationPlanId { get; set; }

    }

}
