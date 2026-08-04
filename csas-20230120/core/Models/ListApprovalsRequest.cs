// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>Collection of approval instance IDs.</para>
        /// </summary>
        [NameInMap("ApprovalIds")]
        [Validation(Required=false)]
        public List<string> ApprovalIds { get; set; }

        /// <summary>
        /// <para>End time when the approval instance was created, in seconds since the Unix epoch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1736750500</para>
        /// </summary>
        [NameInMap("CreateEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// <para>Start time when the approval instance was created, in seconds since the Unix epoch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1730000000</para>
        /// </summary>
        [NameInMap("CreateStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

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
        /// <para>Page number for the current page in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>ID of the user who performed an operation on the approval instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <para>Username of the user who performed an operation on the approval instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>李小姐</para>
        /// </summary>
        [NameInMap("OperatorUsername")]
        [Validation(Required=false)]
        public string OperatorUsername { get; set; }

        /// <summary>
        /// <para>Number of entries per page in a paged query. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Policy type. Valid values:</para>
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// <para>Collection of approval instance statuses.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
