// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateIMBotInput : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("botBizId")]
        [Validation(Required=false)]
        public string BotBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("botBizSecret")]
        [Validation(Required=false)]
        public string BotBizSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("botBizType")]
        [Validation(Required=false)]
        public string BotBizType { get; set; }

        /// <summary>
        /// <para>standard、custom；不传时可能继承租户已有部署模式</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("botMode")]
        [Validation(Required=false)]
        public string BotMode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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
        /// <para>botMode 为 standard 时条件必填；custom 模式不进行标准运行时绑定校验</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public IMBotMetadata Metadata { get; set; }

        /// <summary>
        /// <para>FC 最小实例数，≥ 1；与租户账号级配置相关</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public int? MinInstances { get; set; }

    }

}
