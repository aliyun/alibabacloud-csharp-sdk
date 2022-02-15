// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateServiceGroupRequest : TeaModel {
        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// ENABLE 启用 DISABLE 禁用
        /// </summary>
        [NameInMap("enableWebhook")]
        [Validation(Required=false)]
        public string EnableWebhook { get; set; }

        /// <summary>
        /// 监控源消息模版
        /// </summary>
        [NameInMap("monitorSourceTemplates")]
        [Validation(Required=false)]
        public List<CreateServiceGroupRequestMonitorSourceTemplates> MonitorSourceTemplates { get; set; }
        public class CreateServiceGroupRequestMonitorSourceTemplates : TeaModel {
            /// <summary>
            /// 监控源ID
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            /// <summary>
            /// 监控源名字
            /// </summary>
            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            /// <summary>
            /// 模板内容
            /// </summary>
            [NameInMap("templateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            /// <summary>
            /// 消息模版ID
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        /// <summary>
        /// 服务描述
        /// </summary>
        [NameInMap("serviceGroupDescription")]
        [Validation(Required=false)]
        public string ServiceGroupDescription { get; set; }

        /// <summary>
        /// 服务小组名称
        /// </summary>
        [NameInMap("serviceGroupName")]
        [Validation(Required=false)]
        public string ServiceGroupName { get; set; }

        /// <summary>
        /// 小组人员用户ID
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<long?> UserIds { get; set; }

        /// <summary>
        /// webhookLink
        /// </summary>
        [NameInMap("webhookLink")]
        [Validation(Required=false)]
        public string WebhookLink { get; set; }

        /// <summary>
        /// WEIXIN_GROUP微信 DING_GROUP钉钉 FEISHU_GROUP飞书
        /// </summary>
        [NameInMap("webhookType")]
        [Validation(Required=false)]
        public string WebhookType { get; set; }

    }

}
