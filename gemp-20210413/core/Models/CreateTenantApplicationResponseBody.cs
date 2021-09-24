// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateTenantApplicationResponseBody : TeaModel {
        /// <summary>
        /// id of the req
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateTenantApplicationResponseBodyData Data { get; set; }
        public class CreateTenantApplicationResponseBodyData : TeaModel {
            [NameInMap("openUrl")]
            [Validation(Required=false)]
            public string OpenUrl { get; set; }
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

    }

}
