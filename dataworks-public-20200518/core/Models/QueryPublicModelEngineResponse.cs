// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryPublicModelEngineResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ReturnValue")]
        [Validation(Required=true)]
        public List<Dictionary<string, object>> ReturnValue { get; set; }

    }

}
