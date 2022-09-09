// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRabbitmqPublisherResponseBody : TeaModel {
        [NameInMap("publisher")]
        [Validation(Required=false)]
        public GetRabbitmqPublisherResponseBodyPublisher Publisher { get; set; }
        public class GetRabbitmqPublisherResponseBodyPublisher : TeaModel {
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

            [NameInMap("taskIds")]
            [Validation(Required=false)]
            public List<string> TaskIds { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("virtualHost")]
            [Validation(Required=false)]
            public string VirtualHost { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
