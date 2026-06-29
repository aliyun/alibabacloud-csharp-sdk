// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreatePipelineNodeRequest : TeaModel {
        /// <summary>
        /// <para>The command to create a pipeline. Both offline and real-time pipelines are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreatePipelineNodeCommand")]
        [Validation(Required=false)]
        public CreatePipelineNodeRequestCreatePipelineNodeCommand CreatePipelineNodeCommand { get; set; }
        public class CreatePipelineNodeRequestCreatePipelineNodeCommand : TeaModel {
            /// <summary>
            /// <para>The task file information.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("FileInfo")]
            [Validation(Required=false)]
            public CreatePipelineNodeRequestCreatePipelineNodeCommandFileInfo FileInfo { get; set; }
            public class CreatePipelineNodeRequestCreatePipelineNodeCommandFileInfo : TeaModel {
                /// <summary>
                /// <para>The file description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The full path of the parent directory of the file. If this parameter is left empty, the root path (/) is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_pipeline</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

            }

            /// <summary>
            /// <para>The node type. Valid values: NORMAL, MANUAL, and REAL_TIME.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REAL_TIME</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The pipeline name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_pipeline</para>
            /// </summary>
            [NameInMap("PipelineName")]
            [Validation(Required=false)]
            public string PipelineName { get; set; }

            /// <summary>
            /// <para>The pipeline type. Valid values: OFFLINE_PIPELINE and REAL_TIME_PIPELINE.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REAL_TIME_PIPELINE</para>
            /// </summary>
            [NameInMap("PipelineType")]
            [Validation(Required=false)]
            public string PipelineType { get; set; }

            /// <summary>
            /// <para>The project ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7091124176569088</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
