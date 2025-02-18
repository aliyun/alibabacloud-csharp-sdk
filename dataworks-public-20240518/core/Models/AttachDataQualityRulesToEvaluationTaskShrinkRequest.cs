// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class AttachDataQualityRulesToEvaluationTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data quality monitoring task that is associated with the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200001</para>
        /// </summary>
        [NameInMap("DataQualityEvaluationTaskId")]
        [Validation(Required=false)]
        public long? DataQualityEvaluationTaskId { get; set; }

        /// <summary>
        /// <para>The IDs of the monitoring rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DataQualityRuleIds")]
        [Validation(Required=false)]
        public string DataQualityRuleIdsShrink { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID. You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
