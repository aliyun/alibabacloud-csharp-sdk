// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class CreateResourceShareResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the resource share.
        /// </summary>
        [NameInMap("ResourceShare")]
        [Validation(Required=false)]
        public CreateResourceShareResponseBodyResourceShare ResourceShare { get; set; }
        public class CreateResourceShareResponseBodyResourceShare : TeaModel {
            /// <summary>
            /// Indicates whether resources in the resource share can be shared with accounts outside the resource directory. Valid values:
            /// 
            /// *   false: Resources in the resource share can be shared only with accounts in the resource directory.
            /// *   true: Resources in the resource share can be shared with both accounts in the resource directory and accounts outside the resource directory.
            /// </summary>
            [NameInMap("AllowExternalTargets")]
            [Validation(Required=false)]
            public bool? AllowExternalTargets { get; set; }

            /// <summary>
            /// The time when the resource share was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the resource share.
            /// </summary>
            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            /// <summary>
            /// The name of the resource share.
            /// </summary>
            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            /// <summary>
            /// The owner of the resource share.
            /// </summary>
            [NameInMap("ResourceShareOwner")]
            [Validation(Required=false)]
            public string ResourceShareOwner { get; set; }

            /// <summary>
            /// The status of the resource share. Valid values:
            /// 
            /// *   Active: The resource share is enabled.
            /// *   Pending: The resource share is associated with one or more resource sharing invitations that are waiting for confirmation.
            /// *   Deleting: The resource share is being deleted.
            /// *   Deleted: The resource share is deleted.
            /// 
            /// >  The system deletes the records of resource shares in the Deleted state within 48 hours to 96 hours after you delete the resource shares.
            /// </summary>
            [NameInMap("ResourceShareStatus")]
            [Validation(Required=false)]
            public string ResourceShareStatus { get; set; }

            /// <summary>
            /// The time when the resource share was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
