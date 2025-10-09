// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanRunResponseBody : TeaModel {
        /// <summary>
        /// <para>Data quality monitoring running records.</para>
        /// </summary>
        [NameInMap("DataQualityScanRun")]
        [Validation(Required=false)]
        public GetDataQualityScanRunResponseBodyDataQualityScanRun DataQualityScanRun { get; set; }
        public class GetDataQualityScanRunResponseBodyDataQualityScanRun : TeaModel {
            /// <summary>
            /// <para>The time when the data quality monitor starts running.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706247622000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the data quality monitor stops.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1706247622000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <para>The running record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1016440997</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The parameter settings used during the actual running.</para>
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
            /// <para>The validation results of each rule.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<GetDataQualityScanRunResponseBodyDataQualityScanRunResults> Results { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunResults : TeaModel {
                /// <summary>
                /// <para>The time when the validation result is generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1725506795000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The information about the data quality check.</para>
                /// </summary>
                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunResultsDetails> Details { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunResultsDetails : TeaModel {
                    /// <summary>
                    /// <para>The final value used for comparison with the threshold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100.0</para>
                    /// </summary>
                    [NameInMap("CheckValue")]
                    [Validation(Required=false)]
                    public string CheckValue { get; set; }

                    /// <summary>
                    /// <para>The reference sample used as the baseline for calculating the CheckedValue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ReferenceValue")]
                    [Validation(Required=false)]
                    public string ReferenceValue { get; set; }

                    /// <summary>
                    /// <para>The final comparison result status.</para>
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
                /// <para>The snapshot of the rule Spec at the start of the validation.</para>
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
                /// <para>The sample value used in the validation.</para>
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
                /// <para>The validation result status.</para>
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
            /// <para>The snapshot of the data quality monitor configuration at the start of the validation.</para>
            /// </summary>
            [NameInMap("Scan")]
            [Validation(Required=false)]
            public GetDataQualityScanRunResponseBodyDataQualityScanRunScan Scan { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunScan : TeaModel {
                /// <summary>
                /// <para>The computing resource settings of the data quality monitor.</para>
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResource ComputeResource { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResource : TeaModel {
                    /// <summary>
                    /// <para>The workspace environment to which the compute engine belongs.</para>
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
                    /// <para>The name of the computing resource, which corresponds to the Name attribute in the ComputeResource data structure of the computing resource API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>emr_cluster_001</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The additional runtime settings of the data quality monitor.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResourceRuntime Runtime { get; set; }
                    public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResourceRuntime : TeaModel {
                        /// <summary>
                        /// <para>The type of the compute engine. Only EMR compute engines support these settings.</para>
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
                        /// <para>Additional parameters for the Hive engine. Currently, only mapreduce.job.queuename is supported to specify the queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mapreduce.job.queuename=dq_queue</para>
                        /// </summary>
                        [NameInMap("HiveConf")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> HiveConf { get; set; }

                        /// <summary>
                        /// <para>Additional parameters for the Spark engine. Currently, only spark.yarn.queue is supported to specify the queue.</para>
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
                /// <para>1706247622000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <para>The description of the data quality validation task. Maximum length: 65,535 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a hourly run data quality evaluation plan.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The hook configurations after the data quality monitor stops.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunScanHooks> Hooks { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanHooks : TeaModel {
                    /// <summary>
                    /// <para>The hook trigger condition. Currently, only one type of expression syntax is supported:</para>
                    /// <list type="bullet">
                    /// <item><description>Specify combinations of severity levels and validation statuses for multiple rules, such as <c>results.any { r -&gt; r.status == \\&quot;Fail\\&quot; &amp;&amp; r.rule.severity == \\&quot;Normal\\&quot; || r.status == \\&quot;Error\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; || r.status == \\&quot;Warn\\&quot; &amp;&amp; r.rule.severity == \\&quot;High\\&quot; }</c>. This means the hook is triggered if any executed rule has Fail with Normal severity, Error with High severity, or Warn with High severity. In the conditional expression, the severity value matches that in the Spec code, and the status value matches that in DataQualityResult.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <para>The type of the hook.</para>
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
                /// <para>The data quality monitor ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21077</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The last update time of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1706247622000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The last updater of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The name of the data quality validation task. It can contain digits, letters, Chinese characters, and both half-width and full-width punctuation marks, with a maximum length of 255 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hourly partition quality monitoring</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The parameter settings of the data quality monitor.</para>
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
                /// <para>The resource group used for running the data quality monitor.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanRuntimeResource RuntimeResource { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>Reserved CUs for the resource group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public float? Cu { get; set; }

                    /// <summary>
                    /// <para>The resource group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60597</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The image ID of the run configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-xxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                }

                /// <summary>
                /// <para>The data quality monitor Spec. For more information, see <a href="https://help.aliyun.com/document_detail/2963394.html">Data quality Spec configuration description</a>.</para>
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
                /// <para>The trigger configurations of the data quality monitor.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanTrigger Trigger { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanTrigger : TeaModel {
                    /// <summary>
                    /// <para>If the trigger mode is set to BySchedule, the scheduling task ID must be specified.</para>
                    /// </summary>
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <para>The trigger method of the data quality monitor.</para>
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
            /// <para>The current running status.</para>
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
