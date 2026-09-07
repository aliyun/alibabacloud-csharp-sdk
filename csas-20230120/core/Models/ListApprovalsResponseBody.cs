// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of approval instances.</para>
        /// </summary>
        [NameInMap("Approvals")]
        [Validation(Required=false)]
        public List<ListApprovalsResponseBodyApprovals> Approvals { get; set; }
        public class ListApprovalsResponseBodyApprovals : TeaModel {
            /// <summary>
            /// <para>The details of the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;initiatorName&quot;:&quot;Mr. Wang&quot;,&quot;initiatorDept&quot;:&quot;Testing Department&quot;,&quot;devType&quot;:&quot;windows&quot;,&quot;deviceType&quot;:&quot;usbStorage&quot;,&quot;deviceId&quot;:&quot;FC216E9E3****&quot;,&quot;approvalEndTimestamp&quot;:1736524799,&quot;approvalReason&quot;:&quot;This is a test&quot;}</para>
            /// </summary>
            [NameInMap("ApprovalDetail")]
            [Validation(Required=false)]
            public string ApprovalDetail { get; set; }

            /// <summary>
            /// <para>The instance ID of the approval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-872b5e911b35****</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>The list of approval progress nodes.</para>
            /// </summary>
            [NameInMap("ApprovalProgresses")]
            [Validation(Required=false)]
            public List<ListApprovalsResponseBodyApprovalsApprovalProgresses> ApprovalProgresses { get; set; }
            public class ListApprovalsResponseBodyApprovalsApprovalProgresses : TeaModel {
                /// <summary>
                /// <para>The action performed on the approval progress node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Approve</b>: Approved.</description></item>
                /// <item><description><b>Reject</b>: Rejected.</description></item>
                /// <item><description><b>Revoke</b>: Revoked.</description></item>
                /// <item><description><b>Comment</b>: Commented.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Approve</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The comment on the approval progress node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Approved</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The ID of the executor for the approval progress node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                /// </summary>
                [NameInMap("Executor")]
                [Validation(Required=false)]
                public string Executor { get; set; }

                /// <summary>
                /// <para>The list of operators for the approval progress node.</para>
                /// </summary>
                [NameInMap("Operators")]
                [Validation(Required=false)]
                public List<ListApprovalsResponseBodyApprovalsApprovalProgressesOperators> Operators { get; set; }
                public class ListApprovalsResponseBodyApprovalsApprovalProgressesOperators : TeaModel {
                    /// <summary>
                    /// <para>The ID of the operator for the approval progress node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
                    /// </summary>
                    [NameInMap("SaseUserId")]
                    [Validation(Required=false)]
                    public string SaseUserId { get; set; }

                    /// <summary>
                    /// <para>The username of the operator for the approval progress node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Mr. Wang</para>
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// <para>The status of the approval progress node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b>: Pending approval.</description></item>
                /// <item><description><b>Approved</b>: Approved.</description></item>
                /// <item><description><b>Rejected</b>: Rejected.</description></item>
                /// <item><description><b>Revoked</b>: Revoked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Approved</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The time when the approval progress node was executed. The value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1736752000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The approval type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: built-in approval.</description></item>
            /// <item><description>1: DingTalk approval.</description></item>
            /// <item><description>2: WeCom approval.</description></item>
            /// <item><description>3: Lark approval.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ApprovalType")]
            [Validation(Required=false)]
            public int? ApprovalType { get; set; }

            /// <summary>
            /// <para>The time when the approval instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-15 22:11:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The department of the approval instance creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN=cn***,OU=h***</para>
            /// </summary>
            [NameInMap("CreatorDepartment")]
            [Validation(Required=false)]
            public string CreatorDepartment { get; set; }

            /// <summary>
            /// <para>The terminal device ID of the approval instance creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("CreatorDevTag")]
            [Validation(Required=false)]
            public string CreatorDevTag { get; set; }

            /// <summary>
            /// <para>The ID of the approval instance creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <para>The username of the approval instance creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Wang***</para>
            /// </summary>
            [NameInMap("CreatorUsername")]
            [Validation(Required=false)]
            public string CreatorUsername { get; set; }

            /// <summary>
            /// <para>The filing effective status. An empty string is returned when the approval status is not Approved. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: effective.</description></item>
            /// <item><description>Expired: expired or reached the expiration date.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public string EffectStatus { get; set; }

            /// <summary>
            /// <para>The filing deadline. The value is a UNIX timestamp in seconds. The value 0 is returned when ValidityType is set to Permanent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1757952000</para>
            /// </summary>
            [NameInMap("EndTimestamp")]
            [Validation(Required=false)]
            public long? EndTimestamp { get; set; }

            /// <summary>
            /// <para>The policy type associated with the approval instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DomainBlacklist</b>: Domain name blacklist.</description></item>
            /// <item><description><b>DomainWhitelist</b>: Domain name whitelist.</description></item>
            /// <item><description><b>SoftwareBlock</b>: Software blocking.</description></item>
            /// <item><description><b>DeviceRegistration</b>: Excess registration.</description></item>
            /// <item><description><b>AppUninstall</b>: Endpoint uninstallation.</description></item>
            /// <item><description><b>DlpSend</b>: File outbound transfer.</description></item>
            /// <item><description><b>PeripheralBlock</b>: Peripheral control.</description></item>
            /// <item><description><b>EndpointHardening</b>: Endpoint hardening.</description></item>
            /// <item><description><b>oftwareHardening</b>: Software hardening.</description></item>
            /// <item><description><b>AiAgentBlock</b>: AI Agent control.</description></item>
            /// <item><description><b>PrivateAccessBlock</b>: Internal network access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The ID of the process associated with the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-process-fcc351b8a95b****</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public string ProcessId { get; set; }

            /// <summary>
            /// <para>The name of the process associated with the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test***</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The reason for creating the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Temporary access for the project</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The filing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ApprovalReport: approval filing.</description></item>
            /// <item><description>BackendReport: backend filing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BackendReport</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <para>The content of the template associated with the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;form&quot;: {&quot;labelCol&quot;: 6,&quot;wrapperCol&quot;: 12}}</para>
            /// </summary>
            [NameInMap("SchemaContent")]
            [Validation(Required=false)]
            public string SchemaContent { get; set; }

            /// <summary>
            /// <para>The ID of the template associated with the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-schema-090134f1ebff****</para>
            /// </summary>
            [NameInMap("SchemaId")]
            [Validation(Required=false)]
            public string SchemaId { get; set; }

            /// <summary>
            /// <para>The name of the template associated with the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Template***</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The instance status of the approval. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: Pending approval.</description></item>
            /// <item><description><b>Approved</b>: Approved.</description></item>
            /// <item><description><b>Rejected</b>: Denied.</description></item>
            /// <item><description><b>Revoked</b>: Revoked.</description></item>
            /// <item><description><b>Expired</b>: Expired.</description></item>
            /// <item><description><b>Deleted</b>: Deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The validity duration type. Valid values: FixedTime, Permanent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Permanent</para>
            /// </summary>
            [NameInMap("ValidityType")]
            [Validation(Required=false)]
            public string ValidityType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6965F5BA-53B6-5650-A708-51F090F843BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of approval instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
