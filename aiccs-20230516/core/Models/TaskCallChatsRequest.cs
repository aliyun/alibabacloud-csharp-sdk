// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskCallChatsRequest : TeaModel {
        /// <summary>
        /// <para>坐席ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>72</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>坐席标签</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA</para>
        /// </summary>
        [NameInMap("AgentTag")]
        [Validation(Required=false)]
        public string AgentTag { get; set; }

        /// <summary>
        /// <para>外呼ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9b2eb6b8-7a27-4357-b5ec-104450086e24</para>
        /// </summary>
        [NameInMap("CallId")]
        [Validation(Required=false)]
        public string CallId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>任务ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
