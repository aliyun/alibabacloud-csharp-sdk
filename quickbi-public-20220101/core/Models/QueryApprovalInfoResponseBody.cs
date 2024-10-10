// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryApprovalInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryApprovalInfoResponseBodyResult Result { get; set; }
        public class QueryApprovalInfoResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryApprovalInfoResponseBodyResultData> Data { get; set; }
            public class QueryApprovalInfoResponseBodyResultData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1359508</para>
                /// </summary>
                [NameInMap("ApplicantId")]
                [Validation(Required=false)]
                public string ApplicantId { get; set; }

                [NameInMap("ApplicantName")]
                [Validation(Required=false)]
                public string ApplicantName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64813ef6da58e80eef8ed2f9</para>
                /// </summary>
                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("ApplyReason")]
                [Validation(Required=false)]
                public string ApplyReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sdasascasxasd</para>
                /// </summary>
                [NameInMap("ApproverId")]
                [Validation(Required=false)]
                public string ApproverId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>data_fusion_002</para>
                /// </summary>
                [NameInMap("ApproverName")]
                [Validation(Required=false)]
                public string ApproverName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DeleteFlag")]
                [Validation(Required=false)]
                public bool? DeleteFlag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1708568097135</para>
                /// </summary>
                [NameInMap("ExpireDate")]
                [Validation(Required=false)]
                public long? ExpireDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FlagStatus")]
                [Validation(Required=false)]
                public int? FlagStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1687315758</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1640595729000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("HandleReason")]
                [Validation(Required=false)]
                public string HandleReason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acl-ct4t2e4u2x4ej1bzur</para>
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DASHBOARD</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public int? Start { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

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
