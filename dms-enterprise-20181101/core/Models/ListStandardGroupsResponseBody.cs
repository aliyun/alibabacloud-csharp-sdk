// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListStandardGroupsResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The security rule sets returned.
        /// </summary>
        [NameInMap("StandardGroupList")]
        [Validation(Required=false)]
        public List<ListStandardGroupsResponseBodyStandardGroupList> StandardGroupList { get; set; }
        public class ListStandardGroupsResponseBodyStandardGroupList : TeaModel {
            /// <summary>
            /// The type of the database engine. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The description of the security rule set.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the security rule set.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            /// <summary>
            /// The control mode. Valid values:
            /// 
            /// *   **NONE_CONTROL**: Flexible Management
            /// *   **STABLE**: Stable Change
            /// *   **COMMON**: Security Collaboration
            /// </summary>
            [NameInMap("GroupMode")]
            [Validation(Required=false)]
            public string GroupMode { get; set; }

            /// <summary>
            /// The name of the security rule set.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The ID of the user who queries the security sets.
            /// </summary>
            [NameInMap("LastMenderId")]
            [Validation(Required=false)]
            public long? LastMenderId { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
