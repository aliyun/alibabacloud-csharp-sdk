// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateServiceGroupRequest : TeaModel {
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
        /// 监控源模版列表
        /// </summary>
        [NameInMap("monitorSourceTemplates")]
        [Validation(Required=false)]
        public List<UpdateServiceGroupRequestMonitorSourceTemplates> MonitorSourceTemplates { get; set; }
        public class UpdateServiceGroupRequestMonitorSourceTemplates : TeaModel {
            /// <summary>
            /// 监控报警源Id
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            /// <summary>
            /// 监控报警源
            /// </summary>
            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            /// <summary>
            /// 消息模版内容
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
        /// 服务组ID
        /// </summary>
        [NameInMap("serviceGroupId")]
        [Validation(Required=false)]
        public long? ServiceGroupId { get; set; }

        /// <summary>
        /// 服务组名字
        /// </summary>
        [NameInMap("serviceGroupName")]
        [Validation(Required=false)]
        public string ServiceGroupName { get; set; }

        /// <summary>
        /// 用户ID列表修改后的
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<long?> UserIds { get; set; }

        /// <summary>
        /// webhook跳转地址
        /// </summary>
        [NameInMap("webhookLink")]
        [Validation(Required=false)]
        public string WebhookLink { get; set; }

        /// <summary>
        /// WEIXIN_GROUP微信DING_GROUP钉钉FEISHU_GROUP飞书
        /// </summary>
        [NameInMap("webhookType")]
        [Validation(Required=false)]
        public string WebhookType { get; set; }

    }

}
