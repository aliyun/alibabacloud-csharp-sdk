// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyBatchJobsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BatchJobName")]
        [Validation(Required=false)]
        public string BatchJobName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;95187&quot;]</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>52e80b02-0126-4556-a1e6-ef5b3747ed53/a9a3ddc7-d7d7-48cd-82b5-b31bb5510e71_2a66f8ad-dfbb-4980-9b84-439171295a11.xlsx</para>
        /// </summary>
        [NameInMap("JobFilePath")]
        [Validation(Required=false)]
        public string JobFilePath { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6a668d1-3145-4048-9101-cb3678bb8884</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c6a668d1-3145-4048-9101-cb3678bb8884</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7d820242-f4f0-4d2e-ae35-b424c41cbc5b</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Submitted")]
        [Validation(Required=false)]
        public bool? Submitted { get; set; }

    }

}
