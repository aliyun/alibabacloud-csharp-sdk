// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class ListConsumerGroupsResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerGroupsResponseBodyData Data { get; set; }
        public class ListConsumerGroupsResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListConsumerGroupsResponseBodyDataList> List { get; set; }
            public class ListConsumerGroupsResponseBodyDataList : TeaModel {
                public string ConsumerGroupId { get; set; }
                public string CreateTime { get; set; }
                public string InstanceId { get; set; }
                public string RegionId { get; set; }
                public string Remark { get; set; }
                public string ResourceGroupId { get; set; }
                public string Status { get; set; }
                public string UpdateTime { get; set; }
            }
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("dynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("dynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
