// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class FeedbackRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// good-点赞、bad-点踩
        /// </summary>
        [NameInMap("Feedback")]
        [Validation(Required=false)]
        public string Feedback { get; set; }

        /// <summary>
        /// 点赞、点踩的内容
        /// </summary>
        [NameInMap("FeedbackContent")]
        [Validation(Required=false)]
        public string FeedbackContent { get; set; }

        /// <summary>
        /// 机器人ID
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 会话窗单次会话标识
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// 会话Session标识，标识：IM唯一标识会话
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
