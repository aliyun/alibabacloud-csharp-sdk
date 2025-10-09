// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityScansResponseBody : TeaModel {
        /// <summary>
        /// <para>The page information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityScansResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityScansResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The list of data quality monitors.</para>
            /// </summary>
            [NameInMap("DataQualityScans")]
            [Validation(Required=false)]
            public List<ListDataQualityScansResponseBodyPageInfoDataQualityScans> DataQualityScans { get; set; }
            public class ListDataQualityScansResponseBodyPageInfoDataQualityScans : TeaModel {
                /// <summary>
                /// <para>The compute engine used during execution. If it is not specified, the data source connection defined in the Spec will be used.</para>
                /// </summary>
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResource ComputeResource { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResource : TeaModel {
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
                    /// <para>The name of the computing engine. Uniquely identifies the engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>emr_cluster_001</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Additional runtime settings for the data quality monitor.</para>
                    /// </summary>
                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResourceRuntime Runtime { get; set; }
                    public class ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResourceRuntime : TeaModel {
                        /// <summary>
                        /// <para>The engine type. These settings are only supported for the EMR compute engine. Valid values:</para>
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
                        /// <para>Additional parameters for the Hive engine. Currently, only mapreduce.job.queuename is supported to set the queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mapreduce.job.queuename=dq_queue</para>
                        /// </summary>
                        [NameInMap("HiveConf")]
                        [Validation(Required=false)]
                        public string HiveConf { get; set; }

                        /// <summary>
                        /// <para>Additional parameters for the Spark engine. Currently, only spark.yarn.queue is supported to set the queue.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>spark.yarn.queue=dq_queue</para>
                        /// </summary>
                        [NameInMap("SparkConf")]
                        [Validation(Required=false)]
                        public string SparkConf { get; set; }

                    }

                }

                /// <summary>
                /// <para>The creation time of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1694512304000</para>
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
                /// <para>The description of the data quality scan task. Maximum length: 65,535 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>This is a hourly run data quality evaluation plan.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The hook configuration after the data quality monitor stops.</para>
                /// </summary>
                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<ListDataQualityScansResponseBodyPageInfoDataQualityScansHooks> Hooks { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansHooks : TeaModel {
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
                /// <para>The ID of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26433</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Last update time of the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17236236472</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The user ID of the last person who updated the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23782382795249</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                /// <summary>
                /// <para>The name of the data quality scan task. Can include digits, letters, Chinese characters, and both half-width and full-width punctuation marks. Maximum length: 255 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hourly partition quality monitoring</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the owner responsible for the data quality monitor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23782382795249</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>Execution parameter definitions for the data quality monitor.</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<ListDataQualityScansResponseBodyPageInfoDataQualityScansParameters> Parameters { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansParameters : TeaModel {
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
                /// <para>59094</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The resource group used during the execution of the data quality monitor.</para>
                /// </summary>
                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListDataQualityScansResponseBodyPageInfoDataQualityScansRuntimeResource RuntimeResource { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansRuntimeResource : TeaModel {
                    /// <summary>
                    /// <para>CU consumption for task running.</para>
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
                    /// <para>Serverless_resource_group_xxxxx</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The ID of the image configured for task running.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-xxxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                }

                /// <summary>
                /// <para>Trigger settings for the data quality monitor.</para>
                /// </summary>
                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListDataQualityScansResponseBodyPageInfoDataQualityScansTrigger Trigger { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansTrigger : TeaModel {
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

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of records per page. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The API request ID, which is generated as a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
