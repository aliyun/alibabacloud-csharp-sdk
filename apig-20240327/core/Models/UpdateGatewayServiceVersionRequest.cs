// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayServiceVersionRequest : TeaModel {
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<UpdateGatewayServiceVersionRequestLabels> Labels { get; set; }
        public class UpdateGatewayServiceVersionRequestLabels : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
