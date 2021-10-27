// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class GetDrdsDbRdsRelationInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDrdsDbRdsRelationInfoResponseBodyData> Data { get; set; }
        public class GetDrdsDbRdsRelationInfoResponseBodyData : TeaModel {
            [NameInMap("RdsInstanceId")]
            [Validation(Required=false)]
            public string RdsInstanceId { get; set; }

            [NameInMap("ReadOnlyInstanceInfo")]
            [Validation(Required=false)]
            public List<string> ReadOnlyInstanceInfo { get; set; }

            [NameInMap("UsedInstanceId")]
            [Validation(Required=false)]
            public string UsedInstanceId { get; set; }

            [NameInMap("UsedInstanceType")]
            [Validation(Required=false)]
            public string UsedInstanceType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
