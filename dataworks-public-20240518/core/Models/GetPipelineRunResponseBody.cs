// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the deployment process.</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public GetPipelineRunResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineRunResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The timestamp when the deployment package was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724984066000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the deployment process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137946317766XXXX</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the deployment process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Deployment process description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the deployment process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7ef0634-20ec-4a7c-a214-54020f91XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The error message returned when the deployment fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error message</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// <para>The value is a 13-digit number, such as <c>1724984066000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724984066000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56160</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The stage details.</para>
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<GetPipelineRunResponseBodyPipelineStages> Stages { get; set; }
            public class GetPipelineRunResponseBodyPipelineStages : TeaModel {
                /// <summary>
                /// <para>The code of the deployment stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV_CHECK</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The description of the stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Phase description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The detailed information about the stage.</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public Dictionary<string, object> Detail { get; set; }

                /// <summary>
                /// <para>The exception message of the deployment stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exception information XXX</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The name of the stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Publish package build</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The status of the deployment stage.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Init: Initialization.</description></item>
                /// <item><description>Running: Running.</description></item>
                /// <item><description>Success: Succeeded.</description></item>
                /// <item><description>Fail: Failed.</description></item>
                /// <item><description>Termination: Terminated.</description></item>
                /// <item><description>Cancel: Canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The step number of the deployment stage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

                /// <summary>
                /// <para>The type of the deployment stage.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Deploy: deploy operation</description></item>
                /// <item><description>Check: check operation</description></item>
                /// <item><description>Offline: offline operation</description></item>
                /// <item><description>Build: build operation</description></item>
                /// <item><description>Delete: delete operation</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Check</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The status of the deployment process.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Init: Initialization.</description></item>
            /// <item><description>Running: Running.</description></item>
            /// <item><description>Success: Succeeded.</description></item>
            /// <item><description>Fail: Failed.</description></item>
            /// <item><description>Termination: Terminated.</description></item>
            /// <item><description>Cancel: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08468352-032C-5262-AEDC-68C9FA05XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
