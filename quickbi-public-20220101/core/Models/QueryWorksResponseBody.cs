// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorksResponseBodyResult Result { get; set; }
        public class QueryWorksResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Auth3rdFlag")]
            [Validation(Required=false)]
            public int? Auth3rdFlag { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryWorksResponseBodyResultDirectory Directory { get; set; }
            public class QueryWorksResponseBodyResultDirectory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>83d37ba6-d909-48a2-a517-f4d05c3a****</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                [NameInMap("PathName")]
                [Validation(Required=false)]
                public string PathName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1496651577000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1496651577000</para>
            /// </summary>
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }

            [NameInMap("ModifyName")]
            [Validation(Required=false)]
            public string ModifyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9187a612aa474e2a8ac1414d5529****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("PublicFlag")]
            [Validation(Required=false)]
            public bool? PublicFlag { get; set; }

            [NameInMap("PublicInvalidTime")]
            [Validation(Required=false)]
            public long? PublicInvalidTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public string SecurityLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("WorkName")]
            [Validation(Required=false)]
            public string WorkName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PAGE</para>
            /// </summary>
            [NameInMap("WorkType")]
            [Validation(Required=false)]
            public string WorkType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>95296e95-ca89-4c7d-8af9-dedf0ad0****</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>87c6b145-090c-43e1-9426-8f93be23****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

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
