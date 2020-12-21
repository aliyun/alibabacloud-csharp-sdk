// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class ValidateVirtualClusterNameResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ValidateVirtualClusterNameResponseData Data { get; set; }
        public class ValidateVirtualClusterNameResponseData : TeaModel {
            [NameInMap("Legal")]
            [Validation(Required=true)]
            public string Legal { get; set; }
            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }
        };

    }

}
