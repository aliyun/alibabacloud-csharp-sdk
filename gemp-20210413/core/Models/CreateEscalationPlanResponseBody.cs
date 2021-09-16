// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateEscalationPlanResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateEscalationPlanResponseBodyData Data { get; set; }
        public class CreateEscalationPlanResponseBodyData : TeaModel {
            [NameInMap("escalationPlanId")]
            [Validation(Required=false)]
            public long? EscalationPlanId { get; set; }
        };

    }

}
