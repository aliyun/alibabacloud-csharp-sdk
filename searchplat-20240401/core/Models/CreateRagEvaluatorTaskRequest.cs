// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class CreateRagEvaluatorTaskRequest : TeaModel {
        /// <summary>
        /// <para>app_name</para>
        /// 
        /// <b>Example:</b>
        /// <para>空</para>
        /// </summary>
        [NameInMap("app_name")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The list of evaluation data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<CreateRagEvaluatorTaskRequestData> Data { get; set; }
        public class CreateRagEvaluatorTaskRequestData : TeaModel {
            /// <summary>
            /// <para>model_answer</para>
            /// 
            /// <b>Example:</b>
            /// <para>空</para>
            /// </summary>
            [NameInMap("model_answer")]
            [Validation(Required=false)]
            public string ModelAnswer { get; set; }

            /// <summary>
            /// <para>question</para>
            /// 
            /// <b>Example:</b>
            /// <para>空</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            /// <summary>
            /// <para>recall_docs</para>
            /// </summary>
            [NameInMap("recall_docs")]
            [Validation(Required=false)]
            public List<string> RecallDocs { get; set; }

            /// <summary>
            /// <para>standard_answer</para>
            /// 
            /// <b>Example:</b>
            /// <para>空</para>
            /// </summary>
            [NameInMap("standard_answer")]
            [Validation(Required=false)]
            public string StandardAnswer { get; set; }

        }

        /// <summary>
        /// <para>The datasource config.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;data_source_type&quot;: &quot;oss&quot;,
        /// &quot;file_path&quot;: &quot;oss://xxx.&quot;,
        /// &quot;file_name&quot;: &quot;04837719-default-zz.xlsx&quot;
        /// }</para>
        /// </summary>
        [NameInMap("data_source_config")]
        [Validation(Required=false)]
        public object DataSourceConfig { get; set; }

        /// <summary>
        /// <para>emails</para>
        /// </summary>
        [NameInMap("emails")]
        [Validation(Required=false)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// <para>The evaluation configuration.</para>
        /// </summary>
        [NameInMap("evaluate_config")]
        [Validation(Required=false)]
        public CreateRagEvaluatorTaskRequestEvaluateConfig EvaluateConfig { get; set; }
        public class CreateRagEvaluatorTaskRequestEvaluateConfig : TeaModel {
            /// <summary>
            /// <para>The model to use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-72b</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>prompt</para>
            /// 
            /// <b>Example:</b>
            /// <para>空</para>
            /// </summary>
            [NameInMap("prompt")]
            [Validation(Required=false)]
            public string Prompt { get; set; }

            /// <summary>
            /// <para>run_all_step</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("run_all_step")]
            [Validation(Required=false)]
            public bool? RunAllStep { get; set; }

        }

        /// <summary>
        /// <para>has_data_source</para>
        /// 
        /// <b>Example:</b>
        /// <para>空</para>
        /// </summary>
        [NameInMap("has_data_source")]
        [Validation(Required=false)]
        public bool? HasDataSource { get; set; }

        /// <summary>
        /// <para>The metric values. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>context_recall</description></item>
        /// <item><description>context_precision</description></item>
        /// <item><description>faithfulness</description></item>
        /// <item><description>satisfaction</description></item>
        /// <item><description>comprehensive_score.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("metrics")]
        [Validation(Required=false)]
        public List<object> Metrics { get; set; }

        /// <summary>
        /// <para>The evaluation task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taskName</para>
        /// </summary>
        [NameInMap("task_name")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
