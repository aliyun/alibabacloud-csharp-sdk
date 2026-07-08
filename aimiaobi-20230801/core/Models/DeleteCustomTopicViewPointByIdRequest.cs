// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class DeleteCustomTopicViewPointByIdRequest : TeaModel {
        /// <summary>
        /// <para>Unique identifier of the workspace: <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>Custom viewpoint ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfd73894e6a94fd79fe7ffbe865796fb</para>
        /// </summary>
        [NameInMap("CustomViewPointId")]
        [Validation(Required=false)]
        public string CustomViewPointId { get; set; }

    }

}
