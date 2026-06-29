// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPipelineByIdRequest : TeaModel {
        /// <summary>
        /// <para>The request context information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Context")]
        [Validation(Required=false)]
        public GetPipelineByIdRequestContext Context { get; set; }
        public class GetPipelineByIdRequestContext : TeaModel {
            /// <summary>
            /// <para>The current operating environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DEV: the development environment.</description></item>
            /// <item><description>PROD: the production environment.</description></item>
            /// </list>
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
        /// <para>The ID used to query the pipeline task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("QueryId")]
        [Validation(Required=false)]
        public GetPipelineByIdRequestQueryId QueryId { get; set; }
        public class GetPipelineByIdRequestQueryId : TeaModel {
            /// <summary>
            /// <para>Supports querying by the integration task file ID (fileId).</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>Supports querying by the integration task scheduling node ID (nodeId).</para>
            /// 
            /// <b>Example:</b>
            /// <para>n_123</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>Supports querying by the integration pipeline primary key (pipelineId).</para>
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
