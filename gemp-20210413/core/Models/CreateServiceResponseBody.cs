// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateServiceResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateServiceResponseBodyData Data { get; set; }
        public class CreateServiceResponseBodyData : TeaModel {
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }
        };

    }

}
