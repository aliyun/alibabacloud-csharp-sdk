// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateRabbitmqPublisherAttributeRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("exchangeName")]
        [Validation(Required=false)]
        public string ExchangeName { get; set; }

        [NameInMap("exchangeType")]
        [Validation(Required=false)]
        public string ExchangeType { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
