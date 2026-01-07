// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentWorkspaceMemberResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataAgentWorkspaceMemberResponseBodyData Data { get; set; }
        public class ListDataAgentWorkspaceMemberResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListDataAgentWorkspaceMemberResponseBodyDataContent> Content { get; set; }
            public class ListDataAgentWorkspaceMemberResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1765961516</para>
                /// </summary>
                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public string JoinTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20282*****7591</para>
                /// </summary>
                [NameInMap("MemberId")]
                [Validation(Required=false)]
                public string MemberId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>member</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("RunningTaskNumber")]
                [Validation(Required=false)]
                public long? RunningTaskNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("TotalTaskNumber")]
                [Validation(Required=false)]
                public long? TotalTaskNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yunqitest</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>no use</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>no use</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>no use</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DMS-DA-40114</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Specified parameter is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E0D2-*****-A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
