// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class DestinationConfig : TeaModel {
        [NameInMap("onFailure")]
        [Validation(Required=false)]
        public Destination OnFailure { get; set; }

        [NameInMap("onSuccess")]
        [Validation(Required=false)]
        public Destination OnSuccess { get; set; }

    }

}
