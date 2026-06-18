// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class GetMemoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the long-term memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的大模型应用$APP_ID关于A用户的长期记忆体</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the long-term memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6bff4f317a14442fbc9f73d29dbdxxxx</para>
        /// </summary>
        [NameInMap("memoryId")]
        [Validation(Required=false)]
        public string MemoryId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a71f2d9-f1c9-913b-818b-11402910xxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the long-term memory belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-3z7uw7fwz0vexxxx</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
