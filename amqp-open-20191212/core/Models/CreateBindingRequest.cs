/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateBindingRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

        [NameInMap("SourceExchange")]
        [Validation(Required=false)]
        public string SourceExchange { get; set; }

        [NameInMap("DestinationName")]
        [Validation(Required=false)]
        public string DestinationName { get; set; }

        [NameInMap("BindingKey")]
        [Validation(Required=false)]
        public string BindingKey { get; set; }

        [NameInMap("BindingType")]
        [Validation(Required=false)]
        public string BindingType { get; set; }

        [NameInMap("Argument")]
        [Validation(Required=false)]
        public string Argument { get; set; }

    }

}
