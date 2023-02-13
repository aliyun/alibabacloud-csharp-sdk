// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateActivationResponseBody : TeaModel {
        /// <summary>
        /// The value of the activation code. The value is returned only once after the CreateActivation operation is called and cannot be subsequently queried. Properly save the return value.
        /// </summary>
        [NameInMap("ActivationCode")]
        [Validation(Required=false)]
        public string ActivationCode { get; set; }

        /// <summary>
        /// The ID of the activation code.
        /// </summary>
        [NameInMap("ActivationId")]
        [Validation(Required=false)]
        public string ActivationId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
