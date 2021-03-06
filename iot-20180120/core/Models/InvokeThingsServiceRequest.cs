// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class InvokeThingsServiceRequest : TeaModel {
        [NameInMap("DeviceName")]
        [Validation(Required=true)]
        public List<string> DeviceName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("Identifier")]
        [Validation(Required=true)]
        public string Identifier { get; set; }

        [NameInMap("Args")]
        [Validation(Required=true)]
        public string Args { get; set; }

    }

}
