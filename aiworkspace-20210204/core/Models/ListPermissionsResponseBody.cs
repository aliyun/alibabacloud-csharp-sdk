// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>PaiDLC:GetTensorboard</para>
            /// </summary>
            [NameInMap("PermissionCode")]
            [Validation(Required=false)]
            public string PermissionCode { get; set; }

            [NameInMap("PermissionRules")]
            [Validation(Required=false)]
            public List<ListPermissionsResponseBodyPermissionsPermissionRules> PermissionRules { get; set; }
            public class ListPermissionsResponseBodyPermissionsPermissionRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PRIVATE</para>
                /// </summary>
                [NameInMap("Accessibility")]
                [Validation(Required=false)]
                public string Accessibility { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CREATOR</para>
                /// </summary>
                [NameInMap("EntityAccessType")]
                [Validation(Required=false)]
                public string EntityAccessType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-B******8174039A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
