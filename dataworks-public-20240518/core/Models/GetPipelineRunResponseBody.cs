// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetPipelineRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the process.</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public GetPipelineRunResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineRunResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The time when the process was created. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724984066000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The creator of the process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137946317766XXXX</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The process ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a7ef0634-20ec-4a7c-a214-54020f91XXXX</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The error message returned when the process fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Error message</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The time when the process was modified. This value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724984066000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The DataWorks workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56160</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The information about stages in the process.</para>
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<GetPipelineRunResponseBodyPipelineStages> Stages { get; set; }
            public class GetPipelineRunResponseBodyPipelineStages : TeaModel {
                /// <summary>
                /// <para>The code of the stage.</para>
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
                /// <para>The details of the stage.</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public Dictionary<string, object> Detail { get; set; }

                /// <summary>
                /// <para>The error message returned for the stage.</para>
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
                /// <item><description>Init</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Success</description></item>
                /// <item><description>Fail</description></item>
                /// <item><description>Termination</description></item>
                /// <item><description>Cancel</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The step number of the stage.</para>
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
                /// <item><description>Deploy</description></item>
                /// <item><description>Check</description></item>
                /// <item><description>Offline</description></item>
                /// <item><description>Build</description></item>
                /// <item><description>Delete</description></item>
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
            /// <para>The status of the process.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Init</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Success</description></item>
            /// <item><description>Fail</description></item>
            /// <item><description>Termination</description></item>
            /// <item><description>Cancel</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>08468352-032C-5262-AEDC-68C9FA05XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
