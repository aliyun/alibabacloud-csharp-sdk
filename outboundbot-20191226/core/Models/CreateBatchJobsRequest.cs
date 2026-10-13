// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateBatchJobsRequest : TeaModel {
        /// <summary>
        /// <para>The description of the batch job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("BatchJobDescription")]
        [Validation(Required=false)]
        public string BatchJobDescription { get; set; }

        /// <summary>
        /// <para>The name of the batch job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>First job group</para>
        /// </summary>
        [NameInMap("BatchJobName")]
        [Validation(Required=false)]
        public string BatchJobName { get; set; }

        /// <summary>
        /// <para>The list of calling numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;95187&quot;]</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174952ab-9825-4cc9-a5e2-de82d7fa4cdd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The URL to download the Excel file for the batch job.</para>
        /// <remarks>
        /// <para>You can obtain this parameter from the Folder response parameter of the GetJobDataUploadParams operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>52e80b02-0126-4556-a1e6-ef5b3747ed53/a9a3ddc7-d7d7-48cd-82b5-b31bb5510e71_2a66f8ad-dfbb-4980-9b84-439171295a11.xlsx</para>
        /// </summary>
        [NameInMap("JobFilePath")]
        [Validation(Required=false)]
        public string JobFilePath { get; set; }

        /// <summary>
        /// <para>The scenario ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6a668d1-3145-4048-9101-cb3678bb8884</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>The JSON string of the job execution strategy. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxAttemptsPerDay&quot;:2,&quot;name&quot;:&quot;Strategy name&quot;,&quot;workingTime&quot;:[{&quot;beginTime&quot;:&quot;09:00:00&quot;,&quot;endTime&quot;:&quot;12:00:00&quot;},{&quot;beginTime&quot;:&quot;13:00:00&quot;,&quot;endTime&quot;:&quot;18:30:00&quot;}],&quot;minAttemptInterval&quot;:60}</para>
        /// </summary>
        [NameInMap("StrategyJson")]
        [Validation(Required=false)]
        public string StrategyJson { get; set; }

        /// <summary>
        /// <para>Specifies whether the job is submitted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The job is saved as a draft.</description></item>
        /// <item><description>false: The job is submitted.</description></item>
        /// </list>
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
