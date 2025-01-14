// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalsRequest : TeaModel {
        [NameInMap("ApprovalIds")]
        [Validation(Required=false)]
        public List<string> ApprovalIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1736750500</para>
        /// </summary>
        [NameInMap("CreateEndTime")]
        [Validation(Required=false)]
        public long? CreateEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1730000000</para>
        /// </summary>
        [NameInMap("CreateStartTime")]
        [Validation(Required=false)]
        public long? CreateStartTime { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("OperatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("OperatorUsername")]
        [Validation(Required=false)]
        public string OperatorUsername { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>approval-schema-090134f1ebff****</para>
        /// </summary>
        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
