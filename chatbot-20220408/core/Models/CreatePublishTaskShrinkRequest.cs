// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreatePublishTaskShrinkRequest : TeaModel {
        /// <summary>
        /// 业务空间key,不设置则访问默认业务空间，key值在主账号业务管理页面获取
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// 发布单元类型，机器人发布请使用 CreateInstancePublishTask API
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// 附加发布信息，当前支持：如果BizType是faq，此字段填写类目Id，表示只发布这些类目下面的知识
        /// </summary>
        [NameInMap("DataIdList")]
        [Validation(Required=false)]
        public string DataIdListShrink { get; set; }

    }

}
