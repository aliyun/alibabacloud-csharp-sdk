// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryConsumerGroupListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=true)]
        public int? PageCount { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public QueryConsumerGroupListResponseData Data { get; set; }
        public class QueryConsumerGroupListResponseData : TeaModel {
            [NameInMap("ConsumerGroupDTO")]
            [Validation(Required=true)]
            public List<QueryConsumerGroupListResponseDataConsumerGroupDTO> ConsumerGroupDTO { get; set; }
            public class QueryConsumerGroupListResponseDataConsumerGroupDTO : TeaModel {
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string CreateTime { get; set; }
            }
        };

    }

}
