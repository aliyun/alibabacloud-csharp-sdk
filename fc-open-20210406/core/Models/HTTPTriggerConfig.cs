// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class HTTPTriggerConfig : TeaModel {
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("methods")]
        [Validation(Required=false)]
        public List<string> Methods { get; set; }

    }

}
