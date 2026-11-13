// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The run record of the data quality monitor.</para>
        /// </summary>
        [NameInMap("DataQualityScanRun")]
        [Validation(Required=false)]
        public GetDataQualityScanRunResponseBodyDataQualityScanRun DataQualityScanRun { get; set; }
        public class GetDataQualityScanRunResponseBodyDataQualityScanRun : TeaModel {
            /// <summary>
            /// <para>The time when the data quality monitoring run started.</para>
            /// <para>The value is a 13-digit number, such as <c>1706247622000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706247622000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the data quality monitoring run ended.</para>
            /// <para>The value is a 13-digit number, such as <c>1706247622000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706247622000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The ID of the run record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1016440997</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The parameter settings used during the actual run.</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetDataQualityScanRunResponseBodyDataQualityScanRunParameters> Parameters { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunParameters : TeaModel {
                /// <summary>
                /// <para>The parameter name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dt</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$[yyyy-mm-dd-1]</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The check results for individual rules.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<GetDataQualityScanRunResponseBodyDataQualityScanRunResults> Results { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunResults : TeaModel {
                /// <summary>
                /// <para>The time when the check result was generated.</para>
                /// <para>The value is a 13-digit number, such as <c>1725506795000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725506795000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The details of the current check.</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunResultsDetails> Details { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunResultsDetails : TeaModel {
                    /// <summary>
                    /// <para>The final value used to compare with the threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.0</para>
                    /// </summary>
                    [NameInMap("CheckValue")]
                    [Validation(Required=false)]
                    public string CheckValue { get; set; }

                    /// <summary>
                    /// <para>The baseline value from the referenced sample used to calculate CheckedValue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ReferenceValue")]
                    [Validation(Required=false)]
                    public string ReferenceValue { get; set; }

                    /// <summary>
                    /// <para>The status of the final comparison result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Pass</description></item>
                    /// <item><description>Error</description></item>
                    /// <item><description>Warn</description></item>
                    /// <item><description>Fail</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Fail</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The snapshot of the rule spec at the start of the check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;templateId&quot;: &quot;SYSTEM:field:null_value:fixed&quot;,
                ///     &quot;pass&quot;: &quot;when = 0&quot;,
                ///     &quot;name&quot;: &quot;The id cannot be empty.&quot;,
                ///     &quot;severity&quot;: &quot;High&quot;,
                ///     &quot;identity&quot;: &quot;a-customized-data-quality-rule-uuid&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <para>The sample value used for the current check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;value&quot;: &quot;100.0&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <para>The status of the check result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Pass</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Error</description></item>
                /// <item><description>Warn</description></item>
                /// <item><description>Fail</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Fail</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The snapshot of the data quality monitoring configuration at the start of the check.</para>
            /// </summary>
            [NameInMap("Scan")]
            [Validation(Required=false)]
            public GetDataQualityScanRunResponseBodyDataQualityScanRunScan Scan { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunScan : TeaModel {
                /// <summary>
                /// <para>The compute resource settings of the data quality monitoring task.</para>
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResource ComputeResource { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResource : TeaModel {
                    /// <summary>
                    /// <para>The workspace environment to which the compute engine belongs. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Prod</description></item>
                    /// <item><description>Dev</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Dev</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <para>The name of the compute resource. This corresponds to the Name property in the ComputeResource data structure of the compute resource API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>emr_cluster_001</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The additional runtime settings for the data quality monitoring task.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResourceRuntime Runtime { get; set; }
                    public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResourceRuntime : TeaModel {
                        /// <summary>
                        /// <para>The type of the engine used. Only the E-MapReduce (EMR) compute engine supports this setting. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Hive</description></item>
                        /// <item><description>Spark</description></item>
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
                        /// <para>The additional parameter settings when the Hive engine is used. Currently, only the queue can be configured by using mapreduce.job.queuename.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;mapreduce.job.queuename&quot;: &quot;dq_queue&quot;}</para>
                        /// </summary>
                        [NameInMap("HiveConf")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> HiveConf { get; set; }

                        /// <summary>
                        /// <para>The additional parameter settings when the Spark engine is used. Currently, only the queue can be configured by using spark.yarn.queue.</para>
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
                /// <para>The time when the data quality monitoring task was created.</para>
                /// <para>The value is a 13-digit number, such as <c>1706247622000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1706247622000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The user who created the data quality monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The description of the data quality check task. The description can be up to 65,535 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a hourly run data quality evaluation plan.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The configuration for hooks that run after the data quality monitor finishes.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunScanHooks> Hooks { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanHooks : TeaModel {
                    /// <summary>
                    /// <para>The condition that triggers the hook. Currently, only one expression syntax is supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify multiple groups of rule severity types and rule check statuses. For example, <c>results.any { r -&gt; r.status == \\&quot;Fail\\&quot; &amp;&amp; r.rule.severity == \\&quot;Normal\\&quot; || r.status == \\&quot;Error\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; || r.status == \\&quot;Warn\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; }</c> indicates that the condition is met if the check result of a rule with the severity of Normal is Fail, the check result of a rule with the severity of High is Error, or the check result of a rule with the severity of High is Warn among the executed rules. The enum values of severity in the conditional expression are the same as those in the spec, and the enum values of status are the same as those in DataQualityResult.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The hook type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>BlockTaskInstance</description></item>
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
                /// <para>21077</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The time when the data quality monitoring task was updated.</para>
                /// <para>The value is a 13-digit number, such as <c>1706247622000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1706247622000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The user who last updated the data quality monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The name of the data quality check task. The name can contain digits, letters, Chinese characters, and half-width or full-width punctuation marks, and can be up to 255 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hourly partition quality monitoring</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner of the data quality monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The parameter settings of the data quality monitoring task.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunScanParameters> Parameters { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanParameters : TeaModel {
                    /// <summary>
                    /// <para>The parameter name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dt</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The parameter value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>$[yyyy-mm-dd-1]</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>164024</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The resource group used when the data quality monitoring task runs.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanRuntimeResource RuntimeResource { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>The reserved compute units (CUs) of the resource group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public float? Cu { get; set; }

                    /// <summary>
                    /// <para>The ID of the resource group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60597</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The ID of the image used for the run configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-xxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                }

                /// <summary>
                /// <para>The spec of the data quality monitoring task. For more information, see <a href="https://help.aliyun.com/document_detail/2963394.html">Data quality spec configuration guide</a>.</para>
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
                /// <para>The trigger configuration of the data quality monitoring task.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanTrigger Trigger { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanTrigger : TeaModel {
                    /// <summary>
                    /// <para>The IDs of the scheduling tasks that trigger the data quality monitoring task when the trigger method is set to BySchedule.</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>The trigger method of the data quality monitoring task. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ByManual</description></item>
                    /// <item><description>BySchedule</description></item>
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
            /// <para>The current run status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pass</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Error</description></item>
            /// <item><description>Warn</description></item>
            /// <item><description>Fail</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Fail</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115****159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
