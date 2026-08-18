// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityEvaluationTaskInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data quality check task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000011</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTaskId")]
        [Validation(Required=false)]
        public long? DataQualityEvaluationTaskId { get; set; }

        /// <summary>
        /// <para>The execution parameters of the data quality check in JSON format. The following keys are available:</para>
        /// <list type="bullet">
        /// <item><description>triggerTime: the timestamp in milliseconds of the trigger time. This value is used as the base time for the $[yyyymmdd] expression in the data range of the data quality monitoring task. This key is required.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;triggerTime&quot;: 1733284062000 }</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can logon to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Storage Management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for this API invoke operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group information. This parameter is required when running data quality checks on non-MaxCompute data.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public CreateDataQualityEvaluationTaskInstanceRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateDataQualityEvaluationTaskInstanceRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The CU consumption configured for the task. This parameter is required if you use a serverless resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public double? Cu { get; set; }

            /// <summary>
            /// <para>The identifier of the schedule resource group configured for the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63900680</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

    }

}
