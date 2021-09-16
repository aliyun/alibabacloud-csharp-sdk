// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CheckWebhookRequest : TeaModel {
        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// webook地址
        /// </summary>
        [NameInMap("webhook")]
        [Validation(Required=false)]
        public string Webhook { get; set; }

        /// <summary>
        /// webhook地址类型 企业微信WEIXIN_GROUP 钉钉群 DING_GROUP 飞书 FEISHU_GROUP
        /// </summary>
        [NameInMap("webhookType")]
        [Validation(Required=false)]
        public string WebhookType { get; set; }

    }

}
