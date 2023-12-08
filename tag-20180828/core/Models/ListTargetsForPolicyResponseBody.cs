// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListTargetsForPolicyResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the object belongs to the resource directory. Valid values:
        /// 
        /// *   true: The object belongs to the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
        /// *   false: The object does not belong to the resource directory. This value is available if you use the Tag Policy feature in single-account mode.
        /// </summary>
        [NameInMap("IsRd")]
        [Validation(Required=false)]
        public bool? IsRd { get; set; }

        /// <summary>
        /// Indicates whether the next query is required.
        /// 
        /// *   If the value of this parameter is empty (`"NextToken": ""`), all results are returned, and the next query is not required.
        /// *   If the value of this parameter is not empty, the next query is required, and the value is the token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the resource directory.
        /// 
        /// >  This parameter is returned only if you use the Tag Policy feature in multi-account mode.
        /// </summary>
        [NameInMap("RdId")]
        [Validation(Required=false)]
        public string RdId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The objects to which the tag policy is attached.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<ListTargetsForPolicyResponseBodyTargets> Targets { get; set; }
        public class ListTargetsForPolicyResponseBodyTargets : TeaModel {
            /// <summary>
            /// The ID of the object.
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// The type of the object. Valid values:
            /// 
            /// *   USER: the current logon account. This value is available if you use the Tag Policy feature in single-account mode.
            /// *   ROOT: the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// *   FOLDER: a folder other than the Root folder in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// *   ACCOUNT: a member in the resource directory. This value is available if you use the Tag Policy feature in multi-account mode.
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public int? TargetType { get; set; }

        }

    }

}
