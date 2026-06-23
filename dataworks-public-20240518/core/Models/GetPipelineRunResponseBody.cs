// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the pipeline run.</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public GetPipelineRunResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineRunResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The time when the pipeline run was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724984066000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who created the pipeline run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137946317766XXXX</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the pipeline run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>发布流程描述信息</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the pipeline run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7ef0634-20ec-4a7c-a214-54020f91XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The error message returned if the pipeline run fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error message</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the pipeline run was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
            /// <para>The stages in the pipeline run.</para>
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<GetPipelineRunResponseBodyPipelineStages> Stages { get; set; }
            public class GetPipelineRunResponseBodyPipelineStages : TeaModel {
                /// <summary>
                /// <para>The code that identifies the stage.</para>
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
                /// <para>Detailed information about the stage.</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public Dictionary<string, object> Detail { get; set; }

                /// <summary>
                /// <para>The exception message returned if the stage fails.</para>
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
                /// <para>The status of the stage.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Init</c>: The stage is being initialized.</para>
                /// </description></item>
                /// <item><description><para><c>Running</c>: The stage is in progress.</para>
                /// </description></item>
                /// <item><description><para><c>Success</c>: The stage succeeded.</para>
                /// </description></item>
                /// <item><description><para><c>Fail</c>: The stage failed.</para>
                /// </description></item>
                /// <item><description><para><c>Terminated</c>: The stage was terminated.</para>
                /// </description></item>
                /// <item><description><para><c>Canceled</c>: The stage was canceled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The sequence number of the stage within the pipeline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public int? Step { get; set; }

                /// <summary>
                /// <para>The type of the stage.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Deploy</c>: A deployment operation.</para>
                /// </description></item>
                /// <item><description><para><c>Check</c>: A check operation.</para>
                /// </description></item>
                /// <item><description><para><c>Offline</c>: An offline operation.</para>
                /// </description></item>
                /// <item><description><para><c>Build</c>: A build operation.</para>
                /// </description></item>
                /// <item><description><para><c>Delete</c>: A delete operation.</para>
                /// </description></item>
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
            /// <para>The status of the pipeline run.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Init</c>: The pipeline run is being initialized.</para>
            /// </description></item>
            /// <item><description><para><c>Running</c>: The pipeline run is in progress.</para>
            /// </description></item>
            /// <item><description><para><c>Success</c>: The pipeline run succeeded.</para>
            /// </description></item>
            /// <item><description><para><c>Fail</c>: The pipeline run failed.</para>
            /// </description></item>
            /// <item><description><para><c>Terminated</c>: The pipeline run was terminated.</para>
            /// </description></item>
            /// <item><description><para><c>Canceled</c>: The pipeline run was canceled.</para>
            /// </description></item>
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
        /// <para>The ID of the request. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08468352-032C-5262-AEDC-68C9FA05XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
