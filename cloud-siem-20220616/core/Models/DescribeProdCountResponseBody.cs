// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeProdCountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProdCountResponseBodyData Data { get; set; }
        public class DescribeProdCountResponseBodyData : TeaModel {
            [NameInMap("AliyunProdCount")]
            [Validation(Required=false)]
            public int? AliyunProdCount { get; set; }

            [NameInMap("HcloudProdCount")]
            [Validation(Required=false)]
            public int? HcloudProdCount { get; set; }

            [NameInMap("QcloudProdCount")]
            [Validation(Required=false)]
            public int? QcloudProdCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
