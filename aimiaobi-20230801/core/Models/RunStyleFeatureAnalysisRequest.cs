// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class RunStyleFeatureAnalysisRequest : TeaModel {
        /// <summary>
        /// <para>A collection of custom content texts.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<string> Contents { get; set; }

        /// <summary>
        /// <para>A collection of Material Library IDs.</para>
        /// </summary>
        [NameInMap("MaterialIds")]
        [Validation(Required=false)]
        public List<long?> MaterialIds { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Alibaba Cloud Model Studio workspace. Get the <a href="https://help.aliyun.com/document_detail/2782167.html">workspace ID</a>.</para>
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
