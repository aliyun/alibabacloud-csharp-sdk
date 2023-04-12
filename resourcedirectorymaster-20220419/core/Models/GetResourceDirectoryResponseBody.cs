// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetResourceDirectoryResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the resource directory.
        /// </summary>
        [NameInMap("ResourceDirectory")]
        [Validation(Required=false)]
        public GetResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class GetResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            /// <summary>
            /// The status of the Control Policy feature. Valid values:
            /// 
            /// *   Enabled: The feature is enabled.
            /// *   PendingEnable: The feature is being enabled.
            /// *   Disabled: The feature is disabled.
            /// *   PendingDisable: The feature is being disabled.
            /// </summary>
            [NameInMap("ControlPolicyStatus")]
            [Validation(Required=false)]
            public string ControlPolicyStatus { get; set; }

            /// <summary>
            /// The time when the resource directory was enabled.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The real-name verification information.
            /// </summary>
            [NameInMap("IdentityInformation")]
            [Validation(Required=false)]
            public string IdentityInformation { get; set; }

            /// <summary>
            /// The ID of the management account.
            /// </summary>
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }

            /// <summary>
            /// The name of the management account.
            /// </summary>
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }

            /// <summary>
            /// The status of the member deletion feature. Valid values:
            /// 
            /// *   Enabled: The feature is enabled. You can call the [DeleteAccount](~~DeleteAccount~~) operation to delete members of the resource account type.
            /// *   Disabled: The feature is disabled. You cannot delete members of the resource account type.
            /// </summary>
            [NameInMap("MemberDeletionStatus")]
            [Validation(Required=false)]
            public string MemberDeletionStatus { get; set; }

            /// <summary>
            /// The ID of the resource directory.
            /// </summary>
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }

            /// <summary>
            /// The ID of the Root folder.
            /// </summary>
            [NameInMap("RootFolderId")]
            [Validation(Required=false)]
            public string RootFolderId { get; set; }

        }

    }

}
