// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityScanRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency token.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-customized-uuid</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The compute engine used when the data quality monitor runs. This parameter is optional. If it is not specified, the data source connection specified in the Spec is used.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRequestComputeResource ComputeResource { get; set; }
        public class CreateDataQualityScanRequestComputeResource : TeaModel {
            /// <summary>
            /// <para>The workspace environment to which the compute engine belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prod: production environment</description></item>
            /// <item><description>Dev: development environment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Dev</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The name of the compute engine, which serves as a unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr_first</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The additional settings for the data quality monitor at runtime.</para>
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public CreateDataQualityScanRequestComputeResourceRuntime Runtime { get; set; }
            public class CreateDataQualityScanRequestComputeResourceRuntime : TeaModel {
                /// <summary>
                /// <para>The type of the engine used. Only the E-MapReduce (EMR) compute engine supports this setting. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Hive: Hive SQL</description></item>
                /// <item><description>Spark: Spark SQL</description></item>
                /// <item><description>Kyuubi</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Hive</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The additional parameter settings when the Hive engine is used. Currently, only the queue can be set by using mapreduce.job.queuename.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;mapreduce.job.queuename&quot;: &quot;dq_queue&quot;}</para>
                /// </summary>
                [NameInMap("HiveConf")]
                [Validation(Required=false)]
                public Dictionary<string, object> HiveConf { get; set; }

                /// <summary>
                /// <para>The additional parameter settings when the Spark engine is used. Currently, only the queue can be set by using spark.yarn.queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;spark.yarn.queue&quot;: &quot;dq_queue&quot;}</para>
                /// </summary>
                [NameInMap("SparkConf")]
                [Validation(Required=false)]
                public Dictionary<string, object> SparkConf { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily data quality scanning of ods tables.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The configuration for hooks that run after the data quality monitor finishes.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRequestHooks> Hooks { get; set; }
        public class CreateDataQualityScanRequestHooks : TeaModel {
            /// <summary>
            /// <para>The condition that triggers the hook. When this condition is met, the hook is triggered. Currently, only one expression syntax is supported:</para>
            /// <para>Specify multiple groups of rule severity levels and rule check statuses. For example, <c>results.any { r -&gt; r.status == \\&quot;Fail\\&quot; &amp;&amp; r.rule.severity == \\&quot;Normal\\&quot; || r.status == \\&quot;Error\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; || r.status == \\&quot;Warn\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; }</c> indicates that among the executed rules, if the check result of a rule with the severity of Normal is Fail, the check result of a rule with the severity of High is Error, or the check result of a rule with the severity of High is Warn, the condition is met. The enumerations of severity in the conditional expression are consistent with those in the spec, and the enumerations of status are consistent with those in DataQualityResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>results.any { r -&gt; r.status == \&quot;Fail\&quot; &amp;&amp; r.rule.severity == \&quot;Normal\&quot; || r.status == \&quot;Error\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; || r.status == \&quot;Warn\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The type of the hook. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BlockTaskInstance: blocks task instance scheduling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BlockTaskInstance</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_quality_scan_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The user ID of the owner of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The execution parameter definitions of the data quality monitor.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRequestParameters> Parameters { get; set; }
        public class CreateDataQualityScanRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>triggerTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://dataworks.console.aliyun.com/overview">DataWorks console</a> and go to the Workspace Management page to obtain the workspace ID. This parameter specifies the DataWorks workspace for the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group used when the data quality monitor runs.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateDataQualityScanRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The compute unit (CU) consumption of the runtime configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public float? Cu { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0525242e-d0ee-4bda-bc73-765d82f6a34a</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The image ID of the runtime configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

        }

        /// <summary>
        /// <para>The Spec code that defines the data quality monitor. For more information, see <a href="https://help.aliyun.com/document_detail/2963394.html">Data quality spec configuration guide</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;datasets&quot;: [
        ///         {
        ///             &quot;type&quot;: &quot;Table&quot;,
        ///             &quot;dataSource&quot;: {
        ///                 &quot;name&quot;: &quot;odps_first&quot;,
        ///                 &quot;envType&quot;: &quot;Prod&quot;
        ///             },
        ///             &quot;tables&quot;: [
        ///                 &quot;ods_d_user_info&quot;
        ///             ],
        ///             &quot;filter&quot;: &quot;pt = $[yyyymmdd-1]&quot;
        ///         }
        ///     ],
        ///     &quot;rules&quot;: [
        ///         {
        ///             &quot;assertion&quot;: &quot;row_count &gt; 0&quot;
        ///         }, {
        ///             &quot;templateId&quot;: &quot;SYSTEM:field:null_value:fixed&quot;,
        ///             &quot;pass&quot;: &quot;when = 0&quot;,
        ///             &quot;name&quot;: &quot;The id cannot be empty.&quot;,
        ///             &quot;severity&quot;: &quot;High&quot;,
        ///              &quot;identity&quot;: &quot;a-customized-data-quality-rule-uuid&quot;
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The trigger settings of the data quality monitor.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public CreateDataQualityScanRequestTrigger Trigger { get; set; }
        public class CreateDataQualityScanRequestTrigger : TeaModel {
            /// <summary>
            /// <para>The IDs of the scheduled tasks that trigger the data quality monitor when the trigger method is set to BySchedule.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>The trigger method of the data quality monitor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ByManual: manual trigger. This is the default value.</description></item>
            /// <item><description>BySchedule: scheduled task instance trigger.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BySchedule</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
