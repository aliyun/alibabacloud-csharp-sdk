// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityEvaluationTaskInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data quality monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200001</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTaskId")]
        [Validation(Required=false)]
        public long? DataQualityEvaluationTaskId { get; set; }

        /// <summary>
        /// <para>Data quality verification execution parameters in JSON format. The available keys are as follows:</para>
        /// <list type="bullet">
        /// <item><description>triggerTime: the millisecond timestamp of the trigger time. The baseline time of the $[yyyymmdd] expression in the data range of data quality monitoring. Required.</description></item>
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
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter is used to determine the DataWorks workspaces used for this API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Resource Group information, which must be filled in when running non-MaxCompute data quality verification.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public string RuntimeResourceShrink { get; set; }

    }

}
