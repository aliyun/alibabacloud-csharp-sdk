// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class UpdateAgentStatusRequest : TeaModel {
        /// <summary>
        /// <para>坐席ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <para>坐席状态 1:在线；2:忙碌；3:小休；4:离线</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AgentStatus")]
        [Validation(Required=false)]
        public long? AgentStatus { get; set; }

        /// <summary>
        /// <para>坐席标签</para>
        /// 
        /// <b>Example:</b>
        /// <para>abac</para>
        /// </summary>
        [NameInMap("AgentTag")]
        [Validation(Required=false)]
        public string AgentTag { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
