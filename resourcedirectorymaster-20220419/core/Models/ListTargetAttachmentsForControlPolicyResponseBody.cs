// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListTargetAttachmentsForControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the objects to which the access control policy is attached.
        /// </summary>
        [NameInMap("TargetAttachments")]
        [Validation(Required=false)]
        public ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments TargetAttachments { get; set; }
        public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments : TeaModel {
            [NameInMap("TargetAttachment")]
            [Validation(Required=false)]
            public List<ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment> TargetAttachment { get; set; }
            public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment : TeaModel {
                /// <summary>
                /// The time when the access control policy was attached to the object.
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// The ID of the object.
                /// </summary>
                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                /// <summary>
                /// The name of the object.
                /// </summary>
                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                /// <summary>
                /// The type of the object. Valid values:
                /// 
                /// *   Root: Root folder
                /// *   Folder: subfolder of the Root folder
                /// *   Account: member
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// The total number of objects to which the access control policy is attached.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
