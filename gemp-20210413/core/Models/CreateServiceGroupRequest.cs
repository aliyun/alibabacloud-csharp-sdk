// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateServiceGroupRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("enableWebhook")]
        [Validation(Required=false)]
        public string EnableWebhook { get; set; }

        [NameInMap("monitorSourceTemplates")]
        [Validation(Required=false)]
        public List<CreateServiceGroupRequestMonitorSourceTemplates> MonitorSourceTemplates { get; set; }
        public class CreateServiceGroupRequestMonitorSourceTemplates : TeaModel {
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            [NameInMap("templateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        [NameInMap("serviceGroupDescription")]
        [Validation(Required=false)]
        public string ServiceGroupDescription { get; set; }

        [NameInMap("serviceGroupName")]
        [Validation(Required=false)]
        public string ServiceGroupName { get; set; }

        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<long?> UserIds { get; set; }

        /// <summary>
        /// webhooklink
        /// </summary>
        [NameInMap("webhookLink")]
        [Validation(Required=false)]
        public string WebhookLink { get; set; }

        [NameInMap("webhookType")]
        [Validation(Required=false)]
        public string WebhookType { get; set; }

    }

}
