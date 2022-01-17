// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class UploadCommodityFileResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadCommodityFileResponseBodyData Data { get; set; }
        public class UploadCommodityFileResponseBodyData : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
