// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class MoveKnowledgeBaseResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>目标知识库 ID（echo 回入参）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleKnowledgeId</para>
        /// </summary>
        [NameInMap("knowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>源目录 ID（echo 回入参）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceDirectoryId</para>
        /// </summary>
        [NameInMap("sourceDirectoryId")]
        [Validation(Required=false)]
        public string SourceDirectoryId { get; set; }

        /// <summary>
        /// <para>资源 ID（echo 回入参）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleSourceId</para>
        /// </summary>
        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>目标目录 ID（echo 回入参）</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleTargetDirectoryId</para>
        /// </summary>
        [NameInMap("targetDirectoryId")]
        [Validation(Required=false)]
        public string TargetDirectoryId { get; set; }

    }

}
