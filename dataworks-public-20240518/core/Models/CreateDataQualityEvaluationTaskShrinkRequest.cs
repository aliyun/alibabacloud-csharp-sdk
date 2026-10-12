// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityEvaluationTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of data quality rules associated with the data quality monitoring task. If DataQualityRule.Id is specified, the rule corresponding to the ID is associated with the new quality monitoring task. If it is not specified, a new rule is created by using other fields and associated with the new quality monitoring task.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public string DataQualityRulesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the data source. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to query the ID of the data source.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the data quality monitoring task.</para>
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
        /// <para>The name of the data quality monitoring task.</para>
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
        /// <para>This parameter is used to determine the DataWorks workspace used to invoke this API operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The extension configurations in JSON string format. This parameter takes effect only for EMR data quality monitoring tasks.</para>
        /// <list type="bullet">
        /// <item><description>queue: the YARN queue used to execute EMR data validation. Default value: the queue configured for the project.</description></item>
        /// <item><description>sqlEngine: the SQL engine used to execute EMR data validation. Valid values:<list type="bullet">
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
        /// <para>The monitored object for the data quality monitoring task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string TargetShrink { get; set; }

        /// <summary>
        /// <para>The trigger configuration for the data quality check task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}
