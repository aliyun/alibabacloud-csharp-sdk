// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceGroupResponseBodyData Data { get; set; }
        public class GetServiceGroupResponseBodyData : TeaModel {
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("users")]
            [Validation(Required=false)]
            public List<GetServiceGroupResponseBodyDataUsers> Users { get; set; }
            public class GetServiceGroupResponseBodyDataUsers : TeaModel {
                public long? UserId { get; set; }
                public string UserName { get; set; }
                public string Phone { get; set; }
                public long? ServiceGroupId { get; set; }
            }
            [NameInMap("serviceGroupDescription")]
            [Validation(Required=false)]
            public string ServiceGroupDescription { get; set; }
            [NameInMap("webhookLink")]
            [Validation(Required=false)]
            public string WebhookLink { get; set; }
            [NameInMap("webhookType")]
            [Validation(Required=false)]
            public string WebhookType { get; set; }
            [NameInMap("enableWebhook")]
            [Validation(Required=false)]
            public string EnableWebhook { get; set; }
            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }
            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
        };

    }

}
