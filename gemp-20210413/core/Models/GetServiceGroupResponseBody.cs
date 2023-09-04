// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceGroupResponseBodyData Data { get; set; }
        public class GetServiceGroupResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("enableWebhook")]
            [Validation(Required=false)]
            public string EnableWebhook { get; set; }

            [NameInMap("serviceGroupDescription")]
            [Validation(Required=false)]
            public string ServiceGroupDescription { get; set; }

            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("users")]
            [Validation(Required=false)]
            public List<GetServiceGroupResponseBodyDataUsers> Users { get; set; }
            public class GetServiceGroupResponseBodyDataUsers : TeaModel {
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                [NameInMap("roleNameList")]
                [Validation(Required=false)]
                public List<string> RoleNameList { get; set; }

                [NameInMap("serviceGroupId")]
                [Validation(Required=false)]
                public long? ServiceGroupId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("webhookLink")]
            [Validation(Required=false)]
            public string WebhookLink { get; set; }

            [NameInMap("webhookType")]
            [Validation(Required=false)]
            public string WebhookType { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
