// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetJobResponseBody : TeaModel {
        [NameInMap("job")]
        [Validation(Required=false)]
        public GetJobResponseBodyJob Job { get; set; }
        public class GetJobResponseBodyJob : TeaModel {
            [NameInMap("assertCheckDetail")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobAssertCheckDetail> AssertCheckDetail { get; set; }
            public class GetJobResponseBodyJobAssertCheckDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("comparison")]
                [Validation(Required=false)]
                public string Comparison { get; set; }

                [NameInMap("expectedValue")]
                [Validation(Required=false)]
                public string ExpectedValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isPass")]
                [Validation(Required=false)]
                public bool? IsPass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>result</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("config")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobConfig Config { get; set; }
            public class GetJobResponseBodyJobConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("autoApply")]
                [Validation(Required=false)]
                public bool? AutoApply { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fales</para>
                /// </summary>
                [NameInMap("isDestroy")]
                [Validation(Required=false)]
                public bool? IsDestroy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("moduleVersion")]
                [Validation(Required=false)]
                public string ModuleVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("resourcesChanged")]
                [Validation(Required=false)]
                public string ResourcesChanged { get; set; }

                [NameInMap("subCommand")]
                [Validation(Required=false)]
                public string SubCommand { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-31T03:38:40Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public Dictionary<string, object> DownloadUrl { get; set; }

            [NameInMap("elapsedTime")]
            [Validation(Required=false)]
            public long? ElapsedTime { get; set; }

            [NameInMap("executeType")]
            [Validation(Required=false)]
            public string ExecuteType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isPassAssertCheck")]
            [Validation(Required=false)]
            public bool? IsPassAssertCheck { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-518855d9a058cfff0dc933e6b5767</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public Dictionary<string, string> Parameters { get; set; }

            [NameInMap("runtimeType")]
            [Validation(Required=false)]
            public string RuntimeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Errored</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusDetail")]
            [Validation(Required=false)]
            public Dictionary<string, JobStatusDetailValue> StatusDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task-3b6cb9fa4751a1b9b5f22cbcf4e</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("terraformProviderVersion")]
            [Validation(Required=false)]
            public string TerraformProviderVersion { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1435C78A-AED9-53D6-B7A6-E2661D29B1FA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
