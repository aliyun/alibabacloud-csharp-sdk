// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitPipelineAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public SubmitPipelineAsyncRequestContext Context { get; set; }
        public class SubmitPipelineAsyncRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operation environment. Valid values: DEV: development environment. PROD: production environment.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEV</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the integration pipeline task belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
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

        /// <summary>
        /// <para>The operator user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The ID used to query the pipeline task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public SubmitPipelineAsyncRequestQueryId QueryId { get; set; }
        public class SubmitPipelineAsyncRequestQueryId : TeaModel {
            /// <summary>
            /// <para>The ID of the integration task file. You can specify any one of pipelineId, fileId, or nodeId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The ID of the scheduling node for the integration task. You can specify any one of pipelineId, fileId, or nodeId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_123</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The primary key of the integration pipeline. You can specify any one of pipelineId, fileId, or nodeId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public long? PipelineId { get; set; }

        }

    }

}
