// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDataQualityScanRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a-customized-uuid</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public CreateDataQualityScanRequestComputeResource ComputeResource { get; set; }
        public class CreateDataQualityScanRequestComputeResource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Dev</para>
            /// </summary>
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>emr_first</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Runtime")]
            [Validation(Required=false)]
            public CreateDataQualityScanRequestComputeResourceRuntime Runtime { get; set; }
            public class CreateDataQualityScanRequestComputeResourceRuntime : TeaModel {
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
        public List<CreateDataQualityScanRequestHooks> Hooks { get; set; }
        public class CreateDataQualityScanRequestHooks : TeaModel {
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
        /// <para>data_quality_scan_001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95279527****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateDataQualityScanRequestParameters> Parameters { get; set; }
        public class CreateDataQualityScanRequestParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>triggerTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>$[yyyymmdd-1]</para>
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
        public CreateDataQualityScanRequestRuntimeResource RuntimeResource { get; set; }
        public class CreateDataQualityScanRequestRuntimeResource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>0.25</para>
            /// </summary>
            [NameInMap("Cu")]
            [Validation(Required=false)]
            public float? Cu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0525242e-d0ee-4bda-bc73-765d82f6a34a</para>
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
        public CreateDataQualityScanRequestTrigger Trigger { get; set; }
        public class CreateDataQualityScanRequestTrigger : TeaModel {
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
