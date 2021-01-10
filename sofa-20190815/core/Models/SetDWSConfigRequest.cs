// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SetDWSConfigRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
