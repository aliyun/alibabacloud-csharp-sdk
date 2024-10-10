// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddWorkspaceUsersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7AAB95D7-2E11-4FE2-94BC-858E4FC0C976</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddWorkspaceUsersResponseBodyResult Result { get; set; }
        public class AddWorkspaceUsersResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Failure")]
            [Validation(Required=false)]
            public int? Failure { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;2046274934845893&quot; : &quot;AE0150010001: This user already exists.&quot;, &quot;1213444447906552&quot; : &quot;AE0150010001: This user already exists.&quot;}</para>
            /// </summary>
            [NameInMap("FailureDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailureDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public int? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
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
