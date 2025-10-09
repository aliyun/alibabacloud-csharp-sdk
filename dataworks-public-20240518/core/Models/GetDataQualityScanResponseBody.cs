// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanResponseBody : TeaModel {
        /// <summary>
        /// <para>Data quality monitoring details.</para>
        /// </summary>
        [NameInMap("DataQualityScan")]
        [Validation(Required=false)]
        public GetDataQualityScanResponseBodyDataQualityScan DataQualityScan { get; set; }
        public class GetDataQualityScanResponseBodyDataQualityScan : TeaModel {
            /// <summary>
            /// <para>The compute engine used at runtime. Optional. If not specified, the data source defined in the Spec is used.</para>
            /// </summary>
            [NameInMap("ComputeResource")]
            [Validation(Required=false)]
            public GetDataQualityScanResponseBodyDataQualityScanComputeResource ComputeResource { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanComputeResource : TeaModel {
                /// <summary>
                /// <para>The workspace environment to which the compute engine belongs.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prod: production environment .</description></item>
                /// <item><description>Dev: development environment.</description></item>
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
                /// <para>polardb_to_holo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>More settings for data quality monitor at runtime.</para>
                /// </summary>
                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public GetDataQualityScanResponseBodyDataQualityScanComputeResourceRuntime Runtime { get; set; }
                public class GetDataQualityScanResponseBodyDataQualityScanComputeResourceRuntime : TeaModel {
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
            /// <para>The creation time of the data quality monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731550150000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who creates the data quality monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2374924198591250</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The data quality monitor description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aily data quality scanning of ods tables.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The Hook configurations after the data quality monitoring run ends.</para>
            /// </summary>
            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public List<GetDataQualityScanResponseBodyDataQualityScanHooks> Hooks { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanHooks : TeaModel {
                /// <summary>
                /// <para>The Hook trigger condition. The hook will run if the condition is met. Currently, only one type of expression syntax is supported:</para>
                /// <list type="bullet">
                /// <item><description>You can specify multiple combinations of rule severity levels and validation statuses using an expression such as <c>results.any { r -&gt; r.status == \\&quot;Fail\\&quot; &amp;&amp; r.rule.severity == \\&quot;Normal\\&quot; || r.status == \\&quot;Error\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; || r.status == \\&quot;Warn\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; }</c>. This expression means the condition is met if any executed rule has a result of Fail with severity Normal, Error with severity High, or Warn with severity High. In the condition expression, the values of severity and status are predefined enums. The values of severity must match those defined in the Spec, and the values of status must match those in DataQualityResult.</description></item>
                /// </list>
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
                /// <item><description>BlockTaskInstance: BlockTaskInstance: Blocks the scheduling of the task instance.</description></item>
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
            /// <para>The data quality monitoring ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Last modified time of the data quality monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1731550150000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modifies the data quality monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23482597582479</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <para>The data quality monitor name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data_quality_scan_001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the user who owns the data quality monitor.</para>
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
            public List<GetDataQualityScanResponseBodyDataQualityScanParameters> Parameters { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanParameters : TeaModel {
                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e2e_autolabel</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The workspace ID where the data quality monitor resides. You can obtain the workspace ID by calling the <a href="https://help.aliyun.com/document_detail/2780068.html">ListProjects</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The resource group used during the running of the data quality monitor.</para>
            /// </summary>
            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public GetDataQualityScanResponseBodyDataQualityScanRuntimeResource RuntimeResource { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanRuntimeResource : TeaModel {
                /// <summary>
                /// <para>Reserved compute units (CU) for the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122878</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The image ID used in the runtime configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hp-tlp-e2e-repo-registry-vpc.cn-heyuan-acdr-1.cr.aliyuncs.com/hp-service/worker:9b28b6d-202506091008</para>
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
            public GetDataQualityScanResponseBodyDataQualityScanTrigger Trigger { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanTrigger : TeaModel {
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>204EAF68-CCE3-5112-8DA0-E7A60F02XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
