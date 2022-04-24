// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class SyncRobotMessageShrinkRequest : TeaModel {
        /// <summary>
        /// 答案正文
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// 回复给买家的答案ID
        /// </summary>
        [NameInMap("AnswerId")]
        [Validation(Required=false)]
        public string AnswerId { get; set; }

        /// <summary>
        /// 答案类型
        /// </summary>
        [NameInMap("AnswerType")]
        [Validation(Required=false)]
        public string AnswerType { get; set; }

        /// <summary>
        /// 单句的唯一ID
        /// </summary>
        [NameInMap("ChatId")]
        [Validation(Required=false)]
        public string ChatId { get; set; }

        /// <summary>
        /// 不采纳店小蜜的原因
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// 机器人code
        /// </summary>
        [NameInMap("RobotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// 采纳的场景key
        /// </summary>
        [NameInMap("SceneKey")]
        [Validation(Required=false)]
        public string SceneKey { get; set; }

        /// <summary>
        /// 买卖家之间的会话ID
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 回复到千牛的答案
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public string SolutionsShrink { get; set; }

        /// <summary>
        /// 是否使用店小蜜的结果
        /// </summary>
        [NameInMap("UseDxm")]
        [Validation(Required=false)]
        public string UseDxm { get; set; }

    }

}
