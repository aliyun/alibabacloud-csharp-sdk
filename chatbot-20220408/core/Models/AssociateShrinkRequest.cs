// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class AssociateShrinkRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 视角编码，用于调用同一知识标题下不同视角的答案。在拼装请求参数时，需要以Perspective={视角编码}的格式传递参数。如：&Perspective=["FZJBY3raWr"]。使用SDK时以SDK中定义的参数为准。目前仅支持一个视角答案的调用。       （公有云）
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public string PerspectiveShrink { get; set; }

        /// <summary>
        /// 推荐问题数量，1-10，当出推荐的时候才生效，返回不大于RecommendN
        /// </summary>
        [NameInMap("RecommendNum")]
        [Validation(Required=false)]
        public long? RecommendNum { get; set; }

        /// <summary>
        /// 会话ID，用于标识一个访问者的会话和保持上下文信息。对于一个新的访问者，首次调用Chat接口时无需传递此字段，机器人会开启一个会话，并在Chat接口的响应中返回该会话的SessionId。对于该访问者的后续轮次的会话，调用Chat接口时传递当前会话的SessionId，机器人即可基于SessionId继续该轮次会话。
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户表述
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

    }

}
