// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDataQualityScanResponseBody : TeaModel {
        [NameInMap("DataQualityScan")]
        [Validation(Required=false)]
        public GetDataQualityScanResponseBodyDataQualityScan DataQualityScan { get; set; }
        public class GetDataQualityScanResponseBodyDataQualityScan : TeaModel {
            [NameInMap("ComputeResource")]
            [Validation(Required=false)]
            public GetDataQualityScanResponseBodyDataQualityScanComputeResource ComputeResource { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanComputeResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>polardb_to_holo</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public GetDataQualityScanResponseBodyDataQualityScanComputeResourceRuntime Runtime { get; set; }
                public class GetDataQualityScanResponseBodyDataQualityScanComputeResourceRuntime : TeaModel {
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
            /// <para>1731550150000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2374924198591250</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Hooks")]
            [Validation(Required=false)]
            public List<GetDataQualityScanResponseBodyDataQualityScanHooks> Hooks { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanHooks : TeaModel {
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
            /// <para>10001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1731550150000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23482597582479</para>
            /// </summary>
            [NameInMap("ModifyUser")]
            [Validation(Required=false)]
            public string ModifyUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>data_quality_scan_001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>231263586109857423</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public List<GetDataQualityScanResponseBodyDataQualityScanParameters> Parameters { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>e2e_autolabel</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>101</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("RuntimeResource")]
            [Validation(Required=false)]
            public GetDataQualityScanResponseBodyDataQualityScanRuntimeResource RuntimeResource { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanRuntimeResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Cu")]
                [Validation(Required=false)]
                public float? Cu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>122878</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hp-tlp-e2e-repo-registry-vpc.cn-heyuan-acdr-1.cr.aliyuncs.com/hp-service/worker:9b28b6d-202506091008</para>
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
            public GetDataQualityScanResponseBodyDataQualityScanTrigger Trigger { get; set; }
            public class GetDataQualityScanResponseBodyDataQualityScanTrigger : TeaModel {
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
