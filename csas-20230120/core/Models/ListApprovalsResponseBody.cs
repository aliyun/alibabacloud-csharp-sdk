// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalsResponseBody : TeaModel {
        /// <summary>
        /// <para>List of approval instances.</para>
        /// </summary>
        [NameInMap("Approvals")]
        [Validation(Required=false)]
        public List<ListApprovalsResponseBodyApprovals> Approvals { get; set; }
        public class ListApprovalsResponseBodyApprovals : TeaModel {
            /// <summary>
            /// <para>Details of the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;initiatorName&quot;:&quot;王先生&quot;,&quot;initiatorDept&quot;:&quot;测试部&quot;,&quot;devType&quot;:&quot;windows&quot;,&quot;deviceType&quot;:&quot;usbStorage&quot;,&quot;deviceId&quot;:&quot;FC216E9E3****&quot;,&quot;approvalEndTimestamp&quot;:1736524799,&quot;approvalReason&quot;:&quot;这是一个测试&quot;}</para>
            /// </summary>
            [NameInMap("ApprovalDetail")]
            [Validation(Required=false)]
            public string ApprovalDetail { get; set; }

            /// <summary>
            /// <para>Approval instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-872b5e911b35****</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>List of approval progress nodes.</para>
            /// </summary>
            [NameInMap("ApprovalProgresses")]
            [Validation(Required=false)]
            public List<ListApprovalsResponseBodyApprovalsApprovalProgresses> ApprovalProgresses { get; set; }
            public class ListApprovalsResponseBodyApprovalsApprovalProgresses : TeaModel {
                /// <summary>
                /// <para>Action performed at the approval progress node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Approve</b>: Approve.</para>
                /// </description></item>
                /// <item><description><para><b>Reject</b>: Reject.</para>
                /// </description></item>
                /// <item><description><para><b>Revoke</b>: Revoke.</para>
                /// </description></item>
                /// <item><description><para><b>Comment</b>: Comment.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Approve</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>Comment added at the approval progress node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>审核通过</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>ID of the executor for the approval progress node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>List of operators for the approval progress node.</para>
                /// </summary>
                [NameInMap("Operators")]
                [Validation(Required=false)]
                public List<ListApprovalsResponseBodyApprovalsApprovalProgressesOperators> Operators { get; set; }
                public class ListApprovalsResponseBodyApprovalsApprovalProgressesOperators : TeaModel {
                    /// <summary>
                    /// <para>ID of the operator for the approval progress node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                    /// </summary>
                    [NameInMap("SaseUserId")]
                    [Validation(Required=false)]
                    public string SaseUserId { get; set; }

                    /// <summary>
                    /// <para>Username of the operator for the approval progress node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>王先生</para>
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// <para>Status of the approval progress node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Pending</b>: Pending approval.</para>
                /// </description></item>
                /// <item><description><para><b>Approved</b>: Approved.</para>
                /// </description></item>
                /// <item><description><para><b>Rejected</b>: Rejected.</para>
                /// </description></item>
                /// <item><description><para><b>Revoked</b>: Revoked.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Approved</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Time when the action was performed at the approval progress node, in seconds since the Unix epoch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736752000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public int? ApprovalType { get; set; }

            /// <summary>
            /// <para>Time when the approval instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-15 22:11:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Department of the user who created the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试部</para>
            /// </summary>
            [NameInMap("CreatorDepartment")]
            [Validation(Required=false)]
            public string CreatorDepartment { get; set; }

            /// <summary>
            /// <para>ID of the device used to create the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("CreatorDevTag")]
            [Validation(Required=false)]
            public string CreatorDevTag { get; set; }

            /// <summary>
            /// <para>ID of the user who created the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <para>Username of the user who created the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>王先生</para>
            /// </summary>
            [NameInMap("CreatorUsername")]
            [Validation(Required=false)]
            public string CreatorUsername { get; set; }

            /// <summary>
            /// <para>Expiration time of the approval instance, in seconds since the Unix epoch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757952000</para>
            /// </summary>
            [NameInMap("EndTimestamp")]
            [Validation(Required=false)]
            public long? EndTimestamp { get; set; }

            /// <summary>
            /// <para>Policy type associated with the approval instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>DomainBlacklist</b>: Domain blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>DomainWhitelist</b>: Domain whitelist.</para>
            /// </description></item>
            /// <item><description><para><b>SoftwareBlock</b>: Software blocking.</para>
            /// </description></item>
            /// <item><description><para><b>AppUninstall</b>: App uninstallation.</para>
            /// </description></item>
            /// <item><description><para><b>DlpSend</b>: File outbound transfer.</para>
            /// </description></item>
            /// <item><description><para><b>PeripheralBlock</b>: Peripheral control.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>ID of the associated approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-process-fcc351b8a95b****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>Name of the associated approval process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>Reason for creating the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一个测试</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Content of the associated approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;form&quot;: {&quot;labelCol&quot;: 6,&quot;wrapperCol&quot;: 12}}</para>
            /// </summary>
            [NameInMap("SchemaContent")]
            [Validation(Required=false)]
            public string SchemaContent { get; set; }

            /// <summary>
            /// <para>ID of the associated approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

            /// <summary>
            /// <para>Name of the associated approval template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>Status of the approval instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Pending</b>: Pending approval.</para>
            /// </description></item>
            /// <item><description><para><b>Approved</b>: Approved.</para>
            /// </description></item>
            /// <item><description><para><b>Rejected</b>: Rejected.</para>
            /// </description></item>
            /// <item><description><para><b>Revoked</b>: Revoked.</para>
            /// </description></item>
            /// <item><description><para><b>Expired</b>: Expired.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6965F5BA-53B6-5650-A708-51F090F843BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of approval instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
