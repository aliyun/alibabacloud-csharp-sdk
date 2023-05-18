// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class UpdateResourceShareRequest : TeaModel {
        /// <summary>
        /// The information of the resource share.
        /// </summary>
        [NameInMap("AllowExternalTargets")]
        [Validation(Required=false)]
        public bool? AllowExternalTargets { get; set; }

        /// <summary>
        /// Specifies whether resources in the resource share can be shared with accounts outside the resource directory. Valid values:
        /// 
        /// *   false: Resources in the resource share can be shared only with accounts in the resource directory.
        /// *   true: Resources in the resource share can be shared with both accounts in the resource directory and accounts outside the resource directory.
        /// </summary>
        [NameInMap("ResourceShareId")]
        [Validation(Required=false)]
        public string ResourceShareId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ResourceShareName")]
        [Validation(Required=false)]
        public string ResourceShareName { get; set; }

    }

}
