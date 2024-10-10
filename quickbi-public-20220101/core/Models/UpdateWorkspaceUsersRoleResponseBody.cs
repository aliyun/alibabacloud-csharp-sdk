// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateWorkspaceUsersRoleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7AAB95D7-2E11-4FE2-94BC-858E4FC0C976</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateWorkspaceUsersRoleResponseBodyResult Result { get; set; }
        public class UpdateWorkspaceUsersRoleResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Failure")]
            [Validation(Required=false)]
            public int? Failure { get; set; }

            [NameInMap("FailureDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailureDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public int? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

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
