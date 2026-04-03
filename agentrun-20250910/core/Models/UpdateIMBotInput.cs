// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateIMBotInput : TeaModel {
        [NameInMap("botBizId")]
        [Validation(Required=false)]
        public string BotBizId { get; set; }

        /// <summary>
        /// <para>若提供则不可为空字符串</para>
        /// </summary>
        [NameInMap("botBizSecret")]
        [Validation(Required=false)]
        public string BotBizSecret { get; set; }

        [NameInMap("botBizType")]
        [Validation(Required=false)]
        public string BotBizType { get; set; }

        /// <summary>
        /// <para>不可与租户已固定的 deployment 模式冲突</para>
        /// </summary>
        [NameInMap("botMode")]
        [Validation(Required=false)]
        public string BotMode { get; set; }

        [NameInMap("botName")]
        [Validation(Required=false)]
        public string BotName { get; set; }

        /// <summary>
        /// <para>Bot 描述信息</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public IMBotMetadata Metadata { get; set; }

        /// <summary>
        /// <para>≥ 1，更新账号级 FC 最小实例</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public int? MinInstances { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
