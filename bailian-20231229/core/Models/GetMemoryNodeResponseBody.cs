// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetMemoryNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the memory fragment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户喜欢吃西红柿炒鸡蛋</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The long-term memory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6bff4f317a14442fbc9f73d29dbd5fc3</para>
        /// </summary>
        [NameInMap("memoryId")]
        [Validation(Required=false)]
        public string MemoryId { get; set; }

        /// <summary>
        /// <para>The memory fragment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68de06c95368463a8be4a84efc872cc5</para>
        /// </summary>
        [NameInMap("memoryNodeId")]
        [Validation(Required=false)]
        public string MemoryNodeId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8C56C7AF-6573-19CE-B018-E05E1EDCF4C5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-us9hjmt32nysdm5v</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
