// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class GetFunctionOnDemandConfigResponseBody : TeaModel {
        [NameInMap("maximumInstanceCount")]
        [Validation(Required=false)]
        public long? MaximumInstanceCount { get; set; }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

    }

}
