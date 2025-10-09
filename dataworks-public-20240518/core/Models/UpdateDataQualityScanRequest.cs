// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityScanRequest : TeaModel {
        /// <summary>
        /// <para>The compute engine used during execution. If it\&quot;s not specified, the data source connection defined in the Spec will be used.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public UpdateDataQualityScanRequestComputeResource ComputeResource { get; set; }
        public class UpdateDataQualityScanRequestComputeResource : TeaModel {
            /// <summary>
            /// <para>Workspace environment of the compute engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prod</description></item>
            /// <item><description>Dev</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <para>The name of the compute engine, which is a unique identifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto_createAlertRule_Finished_1kUTk6</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Additional settings for the compute engine.</para>
            /// </summary>
            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public UpdateDataQualityScanRequestComputeResourceRuntime Runtime { get; set; }
            public class UpdateDataQualityScanRequestComputeResourceRuntime : TeaModel {
                /// <summary>
                /// <para>The engine type. These settings are only supported for the EMR compute engine.This setting? Valid values:</para>
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
        /// <para>Description of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily data quality scanning of ods tables.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The hook configuration after the data quality monitor stops.</para>
        /// </summary>
        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<UpdateDataQualityScanRequestHooks> Hooks { get; set; }
        public class UpdateDataQualityScanRequestHooks : TeaModel {
            /// <summary>
            /// <para>The hook trigger condition. When this condition is met, the hook is triggered. Valid expression format:</para>
            /// <para>Specifies multiple combinations of rule severity levels and rule validation statuses, such as <c>results.any { r -&gt; r.status == \\&quot;Fail\\&quot; &amp;&amp; r.rule.severity == \\&quot;Normal\\&quot; || r.status == \\&quot;Error\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; || r.status == \\&quot;Warn\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; }</c>. This means the hook is triggered if any executed rule has Fail with Normal severity, Error with High severity, or Warn with High severity. The severity values must match those defined in the Spec. The status values must match those in DataQualityResult.</para>
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
            /// <item><description>BlockTaskInstance: Block the scheduling of the task instance.</description></item>
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
        /// <para>The ID of the data quality monitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

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
        /// <para>231263586109857423</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The definition of execution parameters for the data quality monitor.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<UpdateDataQualityScanRequestParameters> Parameters { get; set; }
        public class UpdateDataQualityScanRequestParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>temp_237669.zip_byBwm_1734661241752</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>smtp.qiye.aliyun.com</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the DataWorks workspace where the data quality monitor resides. You can obtain the workspace ID by calling the <a href="https://help.aliyun.com/document_detail/2852607.html">ListProjects</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource group used during the execution of the data quality monitor.</para>
        /// </summary>
        [NameInMap("RuntimeResource")]
        [Validation(Required=false)]
        public UpdateDataQualityScanRequestRuntimeResource RuntimeResource { get; set; }
        public class UpdateDataQualityScanRequestRuntimeResource : TeaModel {
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
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20315</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The image ID of the task runtime configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

        }

        /// <summary>
        /// <para>The Spec code of the data quality monitoring content. For more information, see <a href="https://help.aliyun.com/document_detail/2963394.html">Data quality Spec configuration description</a>.</para>
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
        /// <para>Trigger settings for the data quality monitor.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public UpdateDataQualityScanRequestTrigger Trigger { get; set; }
        public class UpdateDataQualityScanRequestTrigger : TeaModel {
            /// <summary>
            /// <para>If the trigger mode is BySchedule, the ID of the scheduling task that triggers the monitor must be configured.</para>
            /// </summary>
            [NameInMap("TaskIds")]
            [Validation(Required=false)]
            public List<long?> TaskIds { get; set; }

            /// <summary>
            /// <para>The trigger mode of the data quality monitor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ByManual: Manually triggered. Default setting.</description></item>
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
