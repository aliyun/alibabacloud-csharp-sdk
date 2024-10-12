// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetPermissionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PaiDLC:ListJobs</para>
        /// </summary>
        [NameInMap("PermissionCode")]
        [Validation(Required=false)]
        public string PermissionCode { get; set; }

        [NameInMap("PermissionRules")]
        [Validation(Required=false)]
        public List<GetPermissionResponseBodyPermissionRules> PermissionRules { get; set; }
        public class GetPermissionResponseBodyPermissionRules : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
