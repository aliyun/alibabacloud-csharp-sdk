// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetApprovalResponseBody : TeaModel {
        /// <summary>
        /// <para>The approval details list, which typically contains one record.</para>
        /// </summary>
        [NameInMap("Approval")]
        [Validation(Required=false)]
        public List<GetApprovalResponseBodyApproval> Approval { get; set; }
        public class GetApprovalResponseBodyApproval : TeaModel {
            /// <summary>
            /// <para>The details of the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;applicationId&quot;:&quot;pa-application-eb75f0c80c28****&quot;,&quot;applicationName&quot;:&quot;App***&quot;,&quot;associatedPolicyName&quot;:&quot;Private access***&quot;}</para>
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
            /// <para>The approval progress list. For backend reports without approval nodes, an empty array is returned.</para>
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
                    /// <para>user***</para>
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
                /// <para>The execution time of the approval progress node. The value is a UNIX timestamp in seconds.</para>
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
            /// <para>The backend report details. This value is returned only when ReportType is set to BackendReport.</para>
            /// </summary>
            [NameInMap("BackendReportDetail")]
            [Validation(Required=false)]
            public GetApprovalResponseBodyApprovalBackendReportDetail BackendReportDetail { get; set; }
            public class GetApprovalResponseBodyApprovalBackendReportDetail : TeaModel {
                /// <summary>
                /// <para>The associated policy name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Private access***</para>
                /// </summary>
                [NameInMap("AssociatedPolicyName")]
                [Validation(Required=false)]
                public string AssociatedPolicyName { get; set; }

                /// <summary>
                /// <para>The associated policy type, which is the same as PolicyType.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PrivateAccessBlock</para>
                /// </summary>
                [NameInMap("AssociatedPolicyType")]
                [Validation(Required=false)]
                public string AssociatedPolicyType { get; set; }

                /// <summary>
                /// <para>The remark for the backend report, which is the same as the report reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Temporary access for a project</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The report object. The fields vary based on PolicyType. Fields within the object use camelCase naming.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;applicationId&quot;:&quot;pa-application-eb75f0c80c28****&quot;,&quot;applicationName&quot;:&quot;App***&quot;}</para>
                /// </summary>
                [NameInMap("ReportObject")]
                [Validation(Required=false)]
                public object ReportObject { get; set; }

                /// <summary>
                /// <para>The actual effective user of the backend report.</para>
                /// </summary>
                [NameInMap("TargetUser")]
                [Validation(Required=false)]
                public GetApprovalResponseBodyApprovalBackendReportDetailTargetUser TargetUser { get; set; }
                public class GetApprovalResponseBodyApprovalBackendReportDetailTargetUser : TeaModel {
                    /// <summary>
                    /// <para>The SASE user ID of the actual effective user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>su_70a1ed06a900d337527984de27568352fdfed1b19442a886d2a697c0327f****</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    /// <summary>
                    /// <para>The username of the actual effective user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user***</para>
                    /// </summary>
                    [NameInMap("Username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

            }

            /// <summary>
            /// <para>The creation time in the yyyy-MM-dd HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-18 17:48:44</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creation time as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1787046524</para>
            /// </summary>
            [NameInMap("CreateTimeUnix")]
            [Validation(Required=false)]
            public long? CreateTimeUnix { get; set; }

            /// <summary>
            /// <para>The department path of the report initiator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN=cn***,OU=ou***</para>
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
            /// <para>The ID of the user who created the approval instance. For backend reports, this is the actual effective user, not the administrator.</para>
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
            /// <para>user***</para>
            /// </summary>
            [NameInMap("CreatorUsername")]
            [Validation(Required=false)]
            public string CreatorUsername { get; set; }

            /// <summary>
            /// <para>The effective status of the report. This value is an empty string when the approval status is not Approved. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Enabled: valid.</description></item>
            /// <item><description>Expired: expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enabled</para>
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
            /// <item><description><b>DeviceRegistration</b>: Excess registration.</description></item>
            /// <item><description><b>AppUninstall</b>: Client uninstallation.</description></item>
            /// <item><description><b>DlpSend</b>: File outbound transfer.</description></item>
            /// <item><description><b>PeripheralBlock</b>: Peripheral control.</description></item>
            /// <item><description><b>EndpointHardening</b>: Endpoint hardening.</description></item>
            /// <item><description><b>oftwareHardening</b>: Software hardening.</description></item>
            /// <item><description><b>AiAgentBlock</b>: AI Agent control.</description></item>
            /// <item><description><b>PrivateAccessBlock</b>: Private access.</description></item>
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
            /// <para>Approval***</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <para>The reason for creating the approval instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Temporary access for a project</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The report type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ApprovalReport: approval report.</description></item>
            /// <item><description>BackendReport: backend report.</description></item>
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
            /// <para>The instance status. Valid values:</para>
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
            /// <para>The validity duration type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>FixedTime</b>: Expires at a specified time.</description></item>
            /// <item><description><b>Permanent</b>: Permanently valid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Permanent</para>
            /// </summary>
            [NameInMap("ValidityType")]
            [Validation(Required=false)]
            public string ValidityType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6707286-A50E-57B1-B2CF-EFAC59E8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
