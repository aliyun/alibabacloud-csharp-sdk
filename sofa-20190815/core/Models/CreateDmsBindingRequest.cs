// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDmsBindingRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Eventcode")]
        [Validation(Required=false)]
        public string Eventcode { get; set; }

        [NameInMap("ExchangeType")]
        [Validation(Required=false)]
        public string ExchangeType { get; set; }

        [NameInMap("Expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Persistence")]
        [Validation(Required=false)]
        public bool? Persistence { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
