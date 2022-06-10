// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 机器人实例ID。登录云小蜜控制台，机器人详情->会话接口，查看机器人实例信息，可获得该实例ID。
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 对话流中意图名称。 若指定此名称，机器人会直接进入此意图做问答
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// 知识库中知识标题的ID。若指定此ID，那么机器人会直接返回指定知识标题的答案
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        /// <summary>
        /// 视角编码，用于调用同一知识标题下不同视角的答案。如：Perspective=["FZJBY3raWr"]。使用SDK时以SDK中定义的参数为准
        /// </summary>
        [NameInMap("Perspective")]
        [Validation(Required=false)]
        public List<string> Perspective { get; set; }

        /// <summary>
        /// 访问者ID。用于识别当前会话中的用户
        /// </summary>
        [NameInMap("SenderId")]
        [Validation(Required=false)]
        public string SenderId { get; set; }

        /// <summary>
        /// 当前会话中访问的昵称
        /// </summary>
        [NameInMap("SenderNick")]
        [Validation(Required=false)]
        public string SenderNick { get; set; }

        /// <summary>
        /// 会话ID，用于标识一个访问者的会话和保持上下文信息。对于一个新的访问者，首次调用Chat接口时无需传递此字段，机器人会开启一个会话，并在Chat接口的响应中返回该会话的SessionId。对于该访问者的后续轮次的会话，调用Chat接口时传递当前会话的SessionId，机器人即可基于SessionId继续该轮次会话。长度限制是64个字符
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 机器人访问者的输入
        /// </summary>
        [NameInMap("Utterance")]
        [Validation(Required=false)]
        public string Utterance { get; set; }

        [NameInMap("VendorParam")]
        [Validation(Required=false)]
        public string VendorParam { get; set; }

    }

}
