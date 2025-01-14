// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalsResponseBody : TeaModel {
        [NameInMap("Approvals")]
        [Validation(Required=false)]
        public List<ListApprovalsResponseBodyApprovals> Approvals { get; set; }
        public class ListApprovalsResponseBodyApprovals : TeaModel {
            [NameInMap("ApprovalDetail")]
            [Validation(Required=false)]
            public string ApprovalDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-872b5e911b35****</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            [NameInMap("ApprovalProgresses")]
            [Validation(Required=false)]
            public List<ListApprovalsResponseBodyApprovalsApprovalProgresses> ApprovalProgresses { get; set; }
            public class ListApprovalsResponseBodyApprovalsApprovalProgresses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Approve</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                [NameInMap("Operators")]
                [Validation(Required=false)]
                public List<ListApprovalsResponseBodyApprovalsApprovalProgressesOperators> Operators { get; set; }
                public class ListApprovalsResponseBodyApprovalsApprovalProgressesOperators : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                    /// </summary>
                    [NameInMap("SaseUserId")]
                    [Validation(Required=false)]
                    public string SaseUserId { get; set; }

                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Approved</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1736752000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-11-15 22:11:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreatorDepartment")]
            [Validation(Required=false)]
            public string CreatorDepartment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("CreatorDevTag")]
            [Validation(Required=false)]
            public string CreatorDevTag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("CreatorUsername")]
            [Validation(Required=false)]
            public string CreatorUsername { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1757952000</para>
            /// </summary>
            [NameInMap("EndTimestamp")]
            [Validation(Required=false)]
            public long? EndTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-process-fcc351b8a95b****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;form&quot;: {&quot;labelCol&quot;: 6,&quot;wrapperCol&quot;: 12}}</para>
            /// </summary>
            [NameInMap("SchemaContent")]
            [Validation(Required=false)]
            public string SchemaContent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6965F5BA-53B6-5650-A708-51F090F843BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
