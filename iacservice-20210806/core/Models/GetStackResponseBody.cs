// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetStackResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>C7070EC3-DF66-58BA-A1DD-A8574FF53143</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("stack")]
        [Validation(Required=false)]
        public GetStackResponseBodyStack Stack { get; set; }
        public class GetStackResponseBodyStack : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public GetStackResponseBodyStackConfig Config { get; set; }
            public class GetStackResponseBodyStackConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB\nupstream_input:\n  - name: stack_network\n ...</para>
                /// </summary>
                [NameInMap("componentContent")]
                [Validation(Required=false)]
                public string ComponentContent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>format_version: IaCService/2021-08-06\ndescription: create ALB \nvariable:\n  - name: region\n    type: string\n ...</para>
                /// </summary>
                [NameInMap("deploymentContent")]
                [Validation(Required=false)]
                public string DeploymentContent { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-24T02:58:53Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("currentConfigVersion")]
            [Validation(Required=false)]
            public string CurrentConfigVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>the description of stack</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestIacRole</para>
            /// </summary>
            [NameInMap("ramRole")]
            [Validation(Required=false)]
            public string RamRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss::<a href="https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip">https://terraform-pipeline.oss-eu-central-1.aliyuncs.com/code.zip</a></para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>stack-as1d4vld898ppnqxxxxxx</para>
            /// </summary>
            [NameInMap("stackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SetUpdated</para>
            /// </summary>
            [NameInMap("triggerStrategy")]
            [Validation(Required=false)]
            public string TriggerStrategy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("workingDirectory")]
            [Validation(Required=false)]
            public string WorkingDirectory { get; set; }

        }

    }

}
