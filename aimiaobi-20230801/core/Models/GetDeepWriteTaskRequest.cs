// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetDeepWriteTaskRequest : TeaModel {
        /// <summary>
        /// <para>Task ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6d3c0bc9-7561-41a4-be4c-d906abdb40a9</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para><a href="https://help.aliyun.com/document_detail/2782167.html">workspace ID</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-odl2p61i4vfbph4g</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
