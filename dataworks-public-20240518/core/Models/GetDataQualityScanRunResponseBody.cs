// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanRunResponseBody : TeaModel {
        [NameInMap("DataQualityScanRun")]
        [Validation(Required=false)]
        public GetDataQualityScanRunResponseBodyDataQualityScanRun DataQualityScanRun { get; set; }
        public class GetDataQualityScanRunResponseBodyDataQualityScanRun : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1706247622000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1706247622000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1016440997</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetDataQualityScanRunResponseBodyDataQualityScanRunParameters> Parameters { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dt</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>$[yyyy-mm-dd-1]</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<GetDataQualityScanRunResponseBodyDataQualityScanRunResults> Results { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1725506795000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Details")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunResultsDetails> Details { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunResultsDetails : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100.0</para>
                    /// </summary>
                    [NameInMap("CheckValue")]
                    [Validation(Required=false)]
                    public string CheckValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("ReferenceValue")]
                    [Validation(Required=false)]
                    public string ReferenceValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Fail</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("Rule")]
                [Validation(Required=false)]
                public string Rule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{
                ///   &quot;value&quot;: &quot;100.0&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Sample")]
                [Validation(Required=false)]
                public string Sample { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Fail</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Scan")]
            [Validation(Required=false)]
            public GetDataQualityScanRunResponseBodyDataQualityScanRunScan Scan { get; set; }
            public class GetDataQualityScanRunResponseBodyDataQualityScanRunScan : TeaModel {
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResource ComputeResource { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Dev</para>
                    /// </summary>
                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>emr_cluster_001</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Runtime")]
                    [Validation(Required=false)]
                    public GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResourceRuntime Runtime { get; set; }
                    public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanComputeResourceRuntime : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Hive</para>
                        /// </summary>
                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>mapreduce.job.queuename=dq_queue</para>
                        /// </summary>
                        [NameInMap("HiveConf")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> HiveConf { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>spark.yarn.queue=dq_queue</para>
                        /// </summary>
                        [NameInMap("SparkConf")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> SparkConf { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1706247622000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>This is a hourly run data quality evaluation plan.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Hooks")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunScanHooks> Hooks { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanHooks : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>results.any { r -&gt; r.status == \&quot;fail\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
                    /// </summary>
                    [NameInMap("Condition")]
                    [Validation(Required=false)]
                    public string Condition { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BlockTaskInstance</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>21077</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1706247622000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7892346529452</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<GetDataQualityScanRunResponseBodyDataQualityScanRunScanParameters> Parameters { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanParameters : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dt</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>$[yyyy-mm-dd-1]</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>164024</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanRuntimeResource RuntimeResource { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanRuntimeResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public float? Cu { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60597</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-xxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public GetDataQualityScanRunResponseBodyDataQualityScanRunScanTrigger Trigger { get; set; }
                public class GetDataQualityScanRunResponseBodyDataQualityScanRunScanTrigger : TeaModel {
                    [NameInMap("TaskIds")]
                    [Validation(Required=false)]
                    public List<long?> TaskIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>BySchedule</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Fail</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc14115****159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
