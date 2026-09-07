// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>The collection of approval instance IDs.</para>
        /// </summary>
        [NameInMap("ApprovalIds")]
        [Validation(Required=false)]
        public List<string> ApprovalIds { get; set; }

        /// <summary>
        /// <para>The end time for querying approval instance creation, in seconds-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736750500</para>
        /// </summary>
        [NameInMap("CreateEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// <para>The start time for querying approval instance creation, in seconds-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1730000000</para>
        /// </summary>
        [NameInMap("CreateStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

        /// <summary>
        /// <para>The department of the approval instance creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QA Department</para>
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
        /// <para>Mr. Wang</para>
        /// </summary>
        [NameInMap("CreatorUsername")]
        [Validation(Required=false)]
        public string CreatorUsername { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of report effective statuses, serialized in Flat format. Duplicate values are not allowed. Only records with an approval status of Approved are matched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: effective.</description></item>
        /// <item><description>Expired: expired or invalidated.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EffectStatuses")]
        [Validation(Required=false)]
        public List<string> EffectStatuses { get; set; }

        /// <summary>
        /// <para>The ID of the approval instance operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <para>The username of the approval instance operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ms. Li</para>
        /// </summary>
        [NameInMap("OperatorUsername")]
        [Validation(Required=false)]
        public string OperatorUsername { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The adaptation policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DomainBlacklist</b>: Domain name blacklist.</description></item>
        /// <item><description><b>DomainWhitelist</b>: Domain name whitelist.</description></item>
        /// <item><description><b>SoftwareBlock</b>: Software blocking.</description></item>
        /// <item><description><b>AppUninstall</b>: Agent uninstallation.</description></item>
        /// <item><description><b>DlpSend</b>: File outbound transfer.</description></item>
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
        /// <para>The associated approval process ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-fcc351b8a95b****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <para>The associated approval process name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The list of report types, serialized in Flat format. Duplicate values are not allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ApprovalReport: approval report.</description></item>
        /// <item><description>BackendReport: backend report.
        /// If not specified, only ApprovalReport is queried by default.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ReportTypes")]
        [Validation(Required=false)]
        public List<string> ReportTypes { get; set; }

        /// <summary>
        /// <para>The associated approval template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-schema-090134f1ebff****</para>
        /// </summary>
        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

        /// <summary>
        /// <para>The associated approval template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>The collection of approval instance statuses.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
