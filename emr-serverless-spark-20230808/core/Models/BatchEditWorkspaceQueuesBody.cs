// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class BatchEditWorkspaceQueuesBody : TeaModel {
        /// <summary>
        /// <para>The list of queues to update. Each entry independently specifies the absolute target state of a queue. Queue names must be unique within the same request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("queues")]
        [Validation(Required=false)]
        public List<BatchEditQueueSpec> Queues { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-1234abcd</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
