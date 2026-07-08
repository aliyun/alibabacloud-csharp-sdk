// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class DeleteDocsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Document ID array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DocIds")]
        [Validation(Required=false)]
        public string DocIdsShrink { get; set; }

        /// <summary>
        /// <para>Unique identifier for the Alibaba Cloud Model Studio workspace. Get the <a href="https://help.aliyun.com/document_detail/2782167.html">workspace ID</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-2setzb9x4ewsd</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
