// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateIncidentSubtotalResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateIncidentSubtotalResponseBodyData Data { get; set; }
        public class CreateIncidentSubtotalResponseBodyData : TeaModel {
            [NameInMap("subtotalId")]
            [Validation(Required=false)]
            public long? SubtotalId { get; set; }
        };

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
