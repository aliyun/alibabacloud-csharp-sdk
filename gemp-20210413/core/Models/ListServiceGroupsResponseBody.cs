// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListServiceGroupsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListServiceGroupsResponseBodyData> Data { get; set; }
        public class ListServiceGroupsResponseBodyData : TeaModel {
            [NameInMap("enableWebhook")]
            [Validation(Required=false)]
            public string EnableWebhook { get; set; }

            [NameInMap("isScheduled")]
            [Validation(Required=false)]
            public bool? IsScheduled { get; set; }

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
            public List<ListServiceGroupsResponseBodyDataUsers> Users { get; set; }
            public class ListServiceGroupsResponseBodyDataUsers : TeaModel {
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("isRelated")]
                [Validation(Required=false)]
                public int? IsRelated { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

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

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
