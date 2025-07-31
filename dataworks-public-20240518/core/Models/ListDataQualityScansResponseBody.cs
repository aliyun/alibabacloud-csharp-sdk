// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataQualityScansResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListDataQualityScansResponseBodyPageInfo PageInfo { get; set; }
        public class ListDataQualityScansResponseBodyPageInfo : TeaModel {
            [NameInMap("DataQualityScans")]
            [Validation(Required=false)]
            public List<ListDataQualityScansResponseBodyPageInfoDataQualityScans> DataQualityScans { get; set; }
            public class ListDataQualityScansResponseBodyPageInfoDataQualityScans : TeaModel {
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResource ComputeResource { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Prod</para>
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
                    public ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResourceRuntime Runtime { get; set; }
                    public class ListDataQualityScansResponseBodyPageInfoDataQualityScansComputeResourceRuntime : TeaModel {
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
                        public string HiveConf { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>spark.yarn.queue=dq_queue</para>
                        /// </summary>
                        [NameInMap("SparkConf")]
                        [Validation(Required=false)]
                        public string SparkConf { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1694512304000</para>
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
                public List<ListDataQualityScansResponseBodyPageInfoDataQualityScansHooks> Hooks { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansHooks : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>results.any { r -&gt; r.status == \&quot;Fail\&quot; &amp;&amp; r.rule.severity == \&quot;Normal\&quot; || r.status == \&quot;Error\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; || r.status == \&quot;Warn\&quot; &amp;&amp; r.rule.severity == \&quot;High\&quot; }</para>
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
                /// <para>26433</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17236236472</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23782382795249</para>
                /// </summary>
                [NameInMap("ModifyUser")]
                [Validation(Required=false)]
                public string ModifyUser { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23782382795249</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public List<ListDataQualityScansResponseBodyPageInfoDataQualityScansParameters> Parameters { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansParameters : TeaModel {
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
                /// <para>59094</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("RuntimeResource")]
                [Validation(Required=false)]
                public ListDataQualityScansResponseBodyPageInfoDataQualityScansRuntimeResource RuntimeResource { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansRuntimeResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.25</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public float? Cu { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Serverless_resource_group_xxxxx</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-xxxxx</para>
                    /// </summary>
                    [NameInMap("Image")]
                    [Validation(Required=false)]
                    public string Image { get; set; }

                }

                [NameInMap("Trigger")]
                [Validation(Required=false)]
                public ListDataQualityScansResponseBodyPageInfoDataQualityScansTrigger Trigger { get; set; }
                public class ListDataQualityScansResponseBodyPageInfoDataQualityScansTrigger : TeaModel {
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0bc14115***159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
