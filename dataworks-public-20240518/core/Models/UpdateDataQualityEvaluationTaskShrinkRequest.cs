// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityEvaluationTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of monitoring rules that are associated with the monitor.</para>
        /// </summary>
        [NameInMap("DataQualityRules")]
        [Validation(Required=false)]
        public string DataQualityRulesShrink { get; set; }

        /// <summary>
        /// <para>The data source ID. You can call the <a href="https://help.aliyun.com/document_detail/211431.html">ListDataSources</a> operation to query the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>358750</para>
        /// </summary>
        [NameInMap("DataSourceId")]
        [Validation(Required=false)]
        public long? DataSourceId { get; set; }

        /// <summary>
        /// <para>The description of the monitor.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hook.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public string HooksShrink { get; set; }

        /// <summary>
        /// <para>The ID of the monitor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7227061794</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The name of the monitor.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configurations of alert notifications.</para>
        /// </summary>
        [NameInMap("Notifications")]
        [Validation(Required=false)]
        public string NotificationsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The extended configurations in JSON-formatted strings. You can use this parameter only for monitors that are used to monitor the quality of E-MapReduce (EMR) data.</para>
        /// <list type="bullet">
        /// <item><description><para>queue: The Yarn queue used when a monitor checks the quality of EMR data. By default, the queue configured for the current workspace is used.</para>
        /// </description></item>
        /// <item><description><para>sqlEngine: The SQL engine used when a monitor checks the quality of EMR data.</para>
        /// <list type="bullet">
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
        /// <para>The monitored object of the data quality monitoring task.</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string TargetShrink { get; set; }

        /// <summary>
        /// <para>The trigger configuration of the monitor.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string TriggerShrink { get; set; }

    }

}
