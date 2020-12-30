// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetUserInputStatisticInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserInputList")]
        [Validation(Required=false)]
        public GetUserInputStatisticInfoResponseBodyUserInputList UserInputList { get; set; }
        public class GetUserInputStatisticInfoResponseBodyUserInputList : TeaModel {
            [NameInMap("ClusterStatUserInput")]
            [Validation(Required=false)]
            public List<GetUserInputStatisticInfoResponseBodyUserInputListClusterStatUserInput> ClusterStatUserInput { get; set; }
            public class GetUserInputStatisticInfoResponseBodyUserInputListClusterStatUserInput : TeaModel {
                public long? BytesInput { get; set; }
                public string User { get; set; }
            }
        };

    }

}
