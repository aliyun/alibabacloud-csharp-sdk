// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateServiceResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The service ID.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The status of the service.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The service version.
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
