// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CheckInstanceExistResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the instance exists. Valid values:
        /// - **true**: The instance exists.
        /// - **false**: The instance does not exist.
        /// </summary>
        [NameInMap("IsExistInstance")]
        [Validation(Required=false)]
        public bool? IsExistInstance { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
