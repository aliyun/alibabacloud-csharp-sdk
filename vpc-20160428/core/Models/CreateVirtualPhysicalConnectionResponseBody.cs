// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVirtualPhysicalConnectionResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Vpconn的实例ID
        /// </summary>
        [NameInMap("VirtualPhysicalConnection")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnection { get; set; }

    }

}
