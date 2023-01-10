// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class InvokeFunctionRequest : TeaModel {
        /// <summary>
        /// The event to be processed by the function. Set this parameter to a binary string. Function Compute passes the event to the function for processing.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public byte[] Body { get; set; }

        /// <summary>
        /// The version or alias of the service.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
