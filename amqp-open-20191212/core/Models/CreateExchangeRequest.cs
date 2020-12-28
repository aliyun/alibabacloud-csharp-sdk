// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateExchangeRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

        [NameInMap("ExchangeName")]
        [Validation(Required=false)]
        public string ExchangeName { get; set; }

        [NameInMap("ExchangeType")]
        [Validation(Required=false)]
        public string ExchangeType { get; set; }

        [NameInMap("AutoDeleteState")]
        [Validation(Required=false)]
        public bool? AutoDeleteState { get; set; }

        [NameInMap("Internal")]
        [Validation(Required=false)]
        public bool? Internal { get; set; }

        [NameInMap("AlternateExchange")]
        [Validation(Required=false)]
        public string AlternateExchange { get; set; }

    }

}
