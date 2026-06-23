// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityEvaluationTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of data quality rules associated with the data quality monitor. If DataQualityRule.Id is specified, the rule corresponding to that ID is associated with the newly created quality monitor. If not specified, a new rule is created from the other fields and associated with the newly created quality monitor.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public string DataQualityRulesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the data source. You can call <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> to obtain the ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the quality monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI create a data quality monitoring test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hook settings.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string HooksShrink { get; set; }

        /// <summary>
        /// <para>The name of the quality monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI create a data quality monitoring test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The notification subscription configuration.</para>
        /// </summary>
        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public string NotificationsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace used by this API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The extended configuration, a JSON-formatted string. This setting takes effect only for EMR-type data quality monitors.</para>
        /// <list type="bullet">
        /// <item><description>queue: The YARN queue used when running EMR data quality validation. The default is the queue configured for the current project.</description></item>
        /// <item><description>sqlEngine: The SQL engine used when running EMR data validation.<list type="bullet">
        /// <item><description>HIVE_SQL</description></item>
        /// <item><description>SPARK_SQL</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;queue&quot;: &quot;default&quot;, &quot;sqlEngine&quot;: &quot;SPARK_SQL&quot; }</para>
        /// </summary>
        [NameInMap("RuntimeConf")]
        [Validation(Required=false)]
        public string RuntimeConf { get; set; }

        /// <summary>
        /// <para>The data quality monitoring object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string TargetShrink { get; set; }

        /// <summary>
        /// <para>The trigger configuration of the data quality validation task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}
