// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateRabbitmqPublisherRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("virtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
