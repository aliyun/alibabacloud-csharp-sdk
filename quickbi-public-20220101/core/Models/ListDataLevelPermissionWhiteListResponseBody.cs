// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDataLevelPermissionWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDataLevelPermissionWhiteListResponseBodyResult Result { get; set; }
        public class ListDataLevelPermissionWhiteListResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ROW_LEVEL</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("UsersModel")]
            [Validation(Required=false)]
            public ListDataLevelPermissionWhiteListResponseBodyResultUsersModel UsersModel { get; set; }
            public class ListDataLevelPermissionWhiteListResponseBodyResultUsersModel : TeaModel {
                [NameInMap("UserGroups")]
                [Validation(Required=false)]
                public List<string> UserGroups { get; set; }

                [NameInMap("Users")]
                [Validation(Required=false)]
                public List<string> Users { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
