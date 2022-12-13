// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateServiceGroupResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateServiceGroupResponseBodyData Data { get; set; }
        public class CreateServiceGroupResponseBodyData : TeaModel {
            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
