// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityEvaluationTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>List of data quality rules associated with the data quality monitoring.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public string DataQualityRulesShrink { get; set; }

        /// <summary>
        /// <para>Data source ID. You can call <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> to obtain the data source ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>358750</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>Description of the quality monitoring task</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI data quality monitoring test.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Callback settings</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string HooksShrink { get; set; }

        /// <summary>
        /// <para>Data quality monitoring ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7227061794</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Name of the quality monitoring task</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI data quality monitoring test.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Notification subscription configuration</para>
        /// </summary>
        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public string NotificationsShrink { get; set; }

        /// <summary>
        /// <para>Workspace ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Extended configuration. A JSON-formatted string. Takes effect only for EMR-type data quality monitoring.</para>
        /// <list type="bullet">
        /// <item><description>queue: The YARN queue used when executing EMR data quality validation. Defaults to the queue configured for the current project.</description></item>
        /// <item><description>sqlEngine: The SQL engine used when executing EMR data validation.<list type="bullet">
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
        /// <para>Data quality monitoring object</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string TargetShrink { get; set; }

        /// <summary>
        /// <para>Trigger configuration of the data quality validation task</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}
