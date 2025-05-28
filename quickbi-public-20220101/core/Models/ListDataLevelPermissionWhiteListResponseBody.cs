// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDataLevelPermissionWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whitelist for the specified row-level permission type.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDataLevelPermissionWhiteListResponseBodyResult Result { get; set; }
        public class ListDataLevelPermissionWhiteListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <para>Type of dataset row and column permissions. Possible values:</para>
            /// <list type="bullet">
            /// <item><description>ROW_LEVEL: Row-level permission</description></item>
            /// <item><description>COLUMN_LEVEL: Column-level permission</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROW_LEVEL</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>Whitelist information.</para>
            /// </summary>
            [NameInMap("UsersModel")]
            [Validation(Required=false)]
            public ListDataLevelPermissionWhiteListResponseBodyResultUsersModel UsersModel { get; set; }
            public class ListDataLevelPermissionWhiteListResponseBodyResultUsersModel : TeaModel {
                /// <summary>
                /// <para>UserGroups.</para>
                /// </summary>
                [NameInMap("UserGroups")]
                [Validation(Required=false)]
                public List<string> UserGroups { get; set; }

                /// <summary>
                /// <para>Users.</para>
                /// </summary>
                [NameInMap("Users")]
                [Validation(Required=false)]
                public List<string> Users { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Request succeeded</description></item>
        /// <item><description>false: Request failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
