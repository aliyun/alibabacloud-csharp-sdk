// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class UploadBookShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Folder ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>Documents</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Docs")]
        [Validation(Required=false)]
        public string DocsShrink { get; set; }

        /// <summary>
        /// <para>Unique identifier of your Alibaba Cloud Model Studio workspace. <a href="https://help.aliyun.com/document_detail/2782167.html">Get your workspace ID</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-ipe7d81yq4sl5jmk</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
