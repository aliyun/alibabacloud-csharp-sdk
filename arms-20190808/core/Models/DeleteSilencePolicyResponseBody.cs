// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteSilencePolicyResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the silence policy was deleted successfully. Valid values:
        /// 
        /// *   `true`: The silence policy was deleted successfully.
        /// *   `false`: The silence policy failed to be deleted.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DeleteSilencePolicy**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
