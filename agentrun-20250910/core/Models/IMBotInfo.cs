// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class IMBotInfo : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("agentRuntimeId")]
        [Validation(Required=false)]
        public string AgentRuntimeId { get; set; }

        [NameInMap("botBizId")]
        [Validation(Required=false)]
        public string BotBizId { get; set; }

        /// <summary>
        /// <para>dingtalk、wecom、feishu、custom</para>
        /// </summary>
        [NameInMap("botBizType")]
        [Validation(Required=false)]
        public string BotBizType { get; set; }

        /// <summary>
        /// <para>standard、custom</para>
        /// </summary>
        [NameInMap("botMode")]
        [Validation(Required=false)]
        public string BotMode { get; set; }

        [NameInMap("botName")]
        [Validation(Required=false)]
        public string BotName { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>可选；来自账号元数据 scaling.currentInstances，同一租户下各 Bot 响应中值相同</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("currentInstances")]
        [Validation(Required=false)]
        public long? CurrentInstances { get; set; }

        /// <summary>
        /// <para>Bot 描述信息</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("imChannelServerResourceName")]
        [Validation(Required=false)]
        public string ImChannelServerResourceName { get; set; }

        /// <summary>
        /// <para>可选</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("lastMessageTime")]
        [Validation(Required=false)]
        public string LastMessageTime { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public IMBotMetadata Metadata { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
