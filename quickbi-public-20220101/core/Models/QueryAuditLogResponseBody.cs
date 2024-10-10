// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryAuditLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>78C1AA2D-9201-599E-A0BA-6FC462E57A95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryAuditLogResponseBodyResult> Result { get; set; }
        public class QueryAuditLogResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-04-16 13:17:39</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wukaibis</para>
            /// </summary>
            [NameInMap("OperatorAccountName")]
            [Validation(Required=false)]
            public string OperatorAccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>buc_344078</para>
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CREATE</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>87c6b145-090c-43e1-9426-8f93be23****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

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
