// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDataQualityScanRequest : TeaModel {
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public UpdateDataQualityScanRequestComputeResource ComputeResource { get; set; }
        public class UpdateDataQualityScanRequestComputeResource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Prod</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>auto_createAlertRule_Finished_1kUTk6</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public UpdateDataQualityScanRequestComputeResourceRuntime Runtime { get; set; }
            public class UpdateDataQualityScanRequestComputeResourceRuntime : TeaModel {
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

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Hooks")]
        [Validation(Required=false)]
        public List<UpdateDataQualityScanRequestHooks> Hooks { get; set; }
        public class UpdateDataQualityScanRequestHooks : TeaModel {
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
        public List<UpdateDataQualityScanRequestParameters> Parameters { get; set; }
        public class UpdateDataQualityScanRequestParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>temp_237669.zip_byBwm_1734661241752</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>smtp.qiye.aliyun.com</para>
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
        public UpdateDataQualityScanRequestRuntimeResource RuntimeResource { get; set; }
        public class UpdateDataQualityScanRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public float? Cu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20315</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>i-xxxxxx</para>
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
        public UpdateDataQualityScanRequestTrigger Trigger { get; set; }
        public class UpdateDataQualityScanRequestTrigger : TeaModel {
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

}
