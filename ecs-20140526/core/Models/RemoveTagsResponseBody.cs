// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RemoveTagsResponseBody : TeaModel {
        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   disk
        /// *   instance
        /// *   image
        /// *   securitygroup
        /// *   snapshot
        /// 
        /// All the preceding values must be in lowercase.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
