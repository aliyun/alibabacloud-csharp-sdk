// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetTenantApplicationResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetTenantApplicationResponseBodyData Data { get; set; }
        public class GetTenantApplicationResponseBodyData : TeaModel {
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }
            [NameInMap("channel")]
            [Validation(Required=false)]
            public string Channel { get; set; }
            [NameInMap("corporationId")]
            [Validation(Required=false)]
            public string CorporationId { get; set; }
            [NameInMap("progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
        };

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
