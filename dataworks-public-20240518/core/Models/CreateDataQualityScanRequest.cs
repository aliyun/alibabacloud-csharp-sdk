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
        /// <para>The compute engine used at runtime. If not specified, the data source defined in the Spec is used.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRequestComputeResource ComputeResource { get; set; }
        public class CreateDataQualityScanRequestComputeResource : TeaModel {
            /// <summary>
            /// <para>The workspace environment to which the compute engine belongs.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prod: production environment .</description></item>
            /// <item><description>Dev: development environment.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Dev</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The name of the compute engine, which is a unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>emr_first</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>More settings for data quality monitoring at runtime.</para>
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public CreateDataQualityScanRequestComputeResourceRuntime Runtime { get; set; }
            public class CreateDataQualityScanRequestComputeResourceRuntime : TeaModel {
                /// <summary>
                /// <para>The type of the compute engine. Only EMR compute engines support these settings.</para>
                /// <para>Valid values:</para>
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
                /// <para>Additional Hive engine parameters. Currently, only the mapreduce.job.queuename parameter is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mapreduce.job.queuename=dq_queue</para>
                /// </summary>
                [NameInMap("HiveConf")]
                [Validation(Required=false)]
                public Dictionary<string, object> HiveConf { get; set; }

                /// <summary>
                /// <para>Additional Spark engine parameters. Currently, only the spark.yarn.queue parameter is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>spark.yarn.queue=dq_queue</para>
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
        /// <para>The Hook configurations after the data quality monitoring run ends.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRequestHooks> Hooks { get; set; }
        public class CreateDataQualityScanRequestHooks : TeaModel {
            /// <summary>
            /// <para>The Hook trigger condition. The hook will run if the condition is met. Currently, only one type of expression syntax is supported:</para>
            /// <para>You can specify multiple combinations of rule severity levels and validation statuses using an expression such as <c>results.any { r -&gt; r.status == \\&quot;Fail\\&quot; &amp;&amp; r.rule.severity == \\&quot;Normal\\&quot; || r.status == \\&quot;Error\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; || r.status == \\&quot;Warn\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; }</c>. This expression means the condition is met if any executed rule has a result of Fail with severity Normal, Error with severity High, or Warn with severity High. In the condition expression, the values of severity and status are predefined enums. The values of severity must match those defined in the Spec, and the values of status must match those in DataQualityResult.</para>
            /// 
            /// <b>Example:</b>
            /// <para>results.any { r -&gt; r.status == \&quot;Fail\&quot; &amp;&amp; r.rule.severity == \&quot;Normal\&quot; || r.status == \&quot;Error\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; || r.status == \&quot;Warn\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The type of the Hook.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BlockTaskInstance: Blocks the scheduling of the task instance.</description></item>
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
        /// <para>The data quality monitoring name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>data_quality_scan_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the user who owns of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The definition of execution parameters for the data quality monitoring.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRequestParameters> Parameters { get; set; }
        public class CreateDataQualityScanRequestParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>triggerTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$[yyyymmdd-1]</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the workspace configuration page to obtain the workspace ID. This parameter is required to specify the target DataWorks workspace for this API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group used during execution of the data quality monitoring.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateDataQualityScanRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <para>The default number of CUs configured for task running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public float? Cu { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0525242e-d0ee-4bda-bc73-765d82f6a34a</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the image configured for task running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

        }

        /// <summary>
        /// <para>Spec code for the content of the data quality monitoring.</para>
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
        /// <para>The trigger configurations of the data quality monitoring task.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public CreateDataQualityScanRequestTrigger Trigger { get; set; }
        public class CreateDataQualityScanRequestTrigger : TeaModel {
            /// <summary>
            /// <para>If the trigger mode is set to BySchedule, the scheduling task ID must be specified.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>The trigger mode of the monitoring task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ByManual: Manual trigger. This is the default setting.</description></item>
            /// <item><description>BySchedule: Triggered by a scheduled task instance.</description></item>
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
