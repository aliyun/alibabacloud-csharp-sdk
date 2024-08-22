// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutAsyncInvokeConfigRequest : TeaModel {
        /// <summary>
        /// The asynchronous invocation configurations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PutAsyncInvokeConfigInput Body { get; set; }

        /// <summary>
        /// The version or alias of the function.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
