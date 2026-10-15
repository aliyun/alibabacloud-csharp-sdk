// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDataLevelPermissionWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The whitelist of the specified row-level or column-level permission type.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDataLevelPermissionWhiteListResponseBodyResult Result { get; set; }
        public class ListDataLevelPermissionWhiteListResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <para>The type of row and column permission for the dataset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ROW_LEVEL: row-level permission</description></item>
            /// <item><description>COLUMN_LEVEL: column-level permission</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROW_LEVEL</para>
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <para>The whitelist information.</para>
            /// </summary>
            [NameInMap("UsersModel")]
            [Validation(Required=false)]
            public ListDataLevelPermissionWhiteListResponseBodyResultUsersModel UsersModel { get; set; }
            public class ListDataLevelPermissionWhiteListResponseBodyResultUsersModel : TeaModel {
                /// <summary>
                /// <para>The list of user group IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;0d5fb19b-***-1248fc27ca51&quot;]</para>
                /// </summary>
                [NameInMap("UserGroups")]
                [Validation(Required=false)]
                public List<string> UserGroups { get; set; }

                /// <summary>
                /// <para>The list of Quick BI user IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;4334***358&quot;]</para>
                /// </summary>
                [NameInMap("Users")]
                [Validation(Required=false)]
                public List<string> Users { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
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
