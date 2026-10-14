// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the approval instances.</para>
        /// </summary>
        [NameInMap("ApprovalIds")]
        [Validation(Required=false)]
        public List<string> ApprovalIds { get; set; }

        /// <summary>
        /// <para>The end time when the approval instance was created. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736750500</para>
        /// </summary>
        [NameInMap("CreateEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// <para>The start time when the approval instance was created. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1730000000</para>
        /// </summary>
        [NameInMap("CreateStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        /// <summary>
        /// <para>The department of the user who created the approval instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test Department</para>
        /// </summary>
        [NameInMap("CreatorDepartment")]
        [Validation(Required=false)]
        public string CreatorDepartment { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint device on which the approval instance was created.</para>
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
        /// <para>Mr. Wang</para>
        /// </summary>
        [NameInMap("CreatorUsername")]
        [Validation(Required=false)]
        public string CreatorUsername { get; set; }

        /// <summary>
        /// <para>The page number of the current page for a paging query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of effective statuses of reports. The list uses the flat serialization format and cannot contain duplicate values. Only records with the Approved approval status are matched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: Valid.</description></item>
        /// <item><description>Expired: Invalid or expired.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EffectStatuses")]
        [Validation(Required=false)]
        public List<string> EffectStatuses { get; set; }

        /// <summary>
        /// <para>The ID of the user who operated the approval instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <para>The username of the user who operated the approval instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ms. Li</para>
        /// </summary>
        [NameInMap("OperatorUsername")]
        [Validation(Required=false)]
        public string OperatorUsername { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paging query. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the adapted policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DomainBlacklist</b>: Domain name blacklist.</description></item>
        /// <item><description><b>DomainWhitelist</b>: Domain name whitelist.</description></item>
        /// <item><description><b>SoftwareBlock</b>: Software blocking.</description></item>
        /// <item><description><b>AppUninstall</b>: Endpoint uninstallation.</description></item>
        /// <item><description><b>DlpSend</b>: Outbound file transfer.</description></item>
        /// <item><description><b>PeripheralBlock</b>: Peripheral control.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DlpSend</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The ID of the associated approval process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-fcc351b8a95b****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The name of the associated approval process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The list of report types. The list uses the flat serialization format and cannot contain duplicate values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ApprovalReport: Approval report.</description></item>
        /// <item><description>BackendReport: Backend report.
        /// If you do not specify this parameter, only ApprovalReport is queried by default.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ReportTypes")]
        [Validation(Required=false)]
        public List<string> ReportTypes { get; set; }

        /// <summary>
        /// <para>The ID of the associated approval template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-schema-090134f1ebff****</para>
        /// </summary>
        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

        /// <summary>
        /// <para>The name of the associated approval template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The statuses of the approval instances.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
