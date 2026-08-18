// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalResponseBody : TeaModel {
        /// <summary>
        /// <para>The approval instance.</para>
        /// </summary>
        [NameInMap("Approval")]
        [Validation(Required=false)]
        public List<GetApprovalResponseBodyApproval> Approval { get; set; }
        public class GetApprovalResponseBodyApproval : TeaModel {
            /// <summary>
            /// <para>The details of the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;initiatorName&quot;:&quot;John Smith&quot;,&quot;initiatorDept&quot;:&quot;QA Department&quot;,&quot;devType&quot;:&quot;windows&quot;,&quot;deviceType&quot;:&quot;usbStorage&quot;,&quot;deviceId&quot;:&quot;FC216E9E3****&quot;,&quot;approvalEndTimestamp&quot;:1736524799,&quot;approvalReason&quot;:&quot;This is a test&quot;}</para>
            /// </summary>
            [NameInMap("ApprovalDetail")]
            [Validation(Required=false)]
            public string ApprovalDetail { get; set; }

            /// <summary>
            /// <para>The approval instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-3564b140642f****</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>The list of approval progress nodes.</para>
            /// </summary>
            [NameInMap("ApprovalProgresses")]
            [Validation(Required=false)]
            public List<GetApprovalResponseBodyApprovalApprovalProgresses> ApprovalProgresses { get; set; }
            public class GetApprovalResponseBodyApprovalApprovalProgresses : TeaModel {
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
                /// <para>The executor ID of the approval progress node.</para>
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
                public List<GetApprovalResponseBodyApprovalApprovalProgressesOperators> Operators { get; set; }
                public class GetApprovalResponseBodyApprovalApprovalProgressesOperators : TeaModel {
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
                    /// <para>John Smith</para>
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
                /// <para>The time when the action was performed on the approval progress node. The value is a UNIX timestamp in seconds.</para>
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
            /// <para>The backend report details. This parameter is returned only when ReportType is set to BackendReport.</para>
            /// </summary>
            [NameInMap("BackendReportDetail")]
            [Validation(Required=false)]
            public GetApprovalResponseBodyApprovalBackendReportDetail BackendReportDetail { get; set; }
            public class GetApprovalResponseBodyApprovalBackendReportDetail : TeaModel {
                [NameInMap("AssociatedPolicyName")]
                [Validation(Required=false)]
                public string AssociatedPolicyName { get; set; }

                [NameInMap("AssociatedPolicyType")]
                [Validation(Required=false)]
                public string AssociatedPolicyType { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ReportObject")]
                [Validation(Required=false)]
                public object ReportObject { get; set; }

                [NameInMap("TargetUser")]
                [Validation(Required=false)]
                public GetApprovalResponseBodyApprovalBackendReportDetailTargetUser TargetUser { get; set; }
                public class GetApprovalResponseBodyApprovalBackendReportDetailTargetUser : TeaModel {
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// <para>The time when the approval instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-15 22:11:55</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimeUnix")]
            [Validation(Required=false)]
            public long? CreateTimeUnix { get; set; }

            /// <summary>
            /// <para>The department of the user who created the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QA Department</para>
            /// </summary>
            [NameInMap("CreatorDepartment")]
            [Validation(Required=false)]
            public string CreatorDepartment { get; set; }

            /// <summary>
            /// <para>The device ID of the terminal that created the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
            /// </summary>
            [NameInMap("CreatorDevTag")]
            [Validation(Required=false)]
            public string CreatorDevTag { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
            /// </summary>
            [NameInMap("CreatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <para>The username of the user who created the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>John Smith</para>
            /// </summary>
            [NameInMap("CreatorUsername")]
            [Validation(Required=false)]
            public string CreatorUsername { get; set; }

            /// <summary>
            /// <para>The effective status of the report. Enabled indicates that the report is active, and Expired indicates that the report has expired.</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public string EffectStatus { get; set; }

            /// <summary>
            /// <para>The expiration time of the approval instance. The value is a UNIX timestamp in seconds.</para>
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
            /// <item><description><b>AppUninstall</b>: Agent uninstallation.</description></item>
            /// <item><description><b>DlpSend</b>: File outbound transfer.</description></item>
            /// <item><description><b>PeripheralBlock</b>: Peripheral device control.</description></item>
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
            /// <para>Test</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The reason for creating the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The report type. ApprovalReport indicates an approval report, and BackendReport indicates a backend report.</para>
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
            /// <para>Test</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Pending</b>: Pending approval.</description></item>
            /// <item><description><b>Approved</b>: Approved.</description></item>
            /// <item><description><b>Rejected</b>: Denied.</description></item>
            /// <item><description><b>Revoked</b>: Revoked.</description></item>
            /// <item><description><b>Expired</b>: Expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Pending</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The validity duration type. When the value is Permanent, EndTimestamp returns 0.</para>
            /// </summary>
            [NameInMap("ValidityType")]
            [Validation(Required=false)]
            public string ValidityType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E9D7ACD-53D5-56EF-A913-79D148D06299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
