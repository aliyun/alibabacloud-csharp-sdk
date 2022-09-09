// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListRabbitmqPublishersResponseBody : TeaModel {
        [NameInMap("authorizations")]
        [Validation(Required=false)]
        public List<ListRabbitmqPublishersResponseBodyAuthorizations> Authorizations { get; set; }
        public class ListRabbitmqPublishersResponseBodyAuthorizations : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("exchangeName")]
            [Validation(Required=false)]
            public string ExchangeName { get; set; }

            [NameInMap("exchangeType")]
            [Validation(Required=false)]
            public string ExchangeType { get; set; }

            [NameInMap("hostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            [NameInMap("publisherId")]
            [Validation(Required=false)]
            public string PublisherId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("virtualHost")]
            [Validation(Required=false)]
            public string VirtualHost { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
