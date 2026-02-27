// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class QueryVideoAuditResultRequest : TeaModel {
        /// <summary>
        /// <para>视频审校任务的唯一标识，长度固定32位</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-xxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
