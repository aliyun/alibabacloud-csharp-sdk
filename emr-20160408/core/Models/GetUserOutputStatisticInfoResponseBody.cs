// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetUserOutputStatisticInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserOutputList")]
        [Validation(Required=false)]
        public GetUserOutputStatisticInfoResponseBodyUserOutputList UserOutputList { get; set; }
        public class GetUserOutputStatisticInfoResponseBodyUserOutputList : TeaModel {
            [NameInMap("ClusterStatUserOutput")]
            [Validation(Required=false)]
            public List<GetUserOutputStatisticInfoResponseBodyUserOutputListClusterStatUserOutput> ClusterStatUserOutput { get; set; }
            public class GetUserOutputStatisticInfoResponseBodyUserOutputListClusterStatUserOutput : TeaModel {
                public string User { get; set; }
                public long? BytesOutput { get; set; }
            }
        };

    }

}
