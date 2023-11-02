// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class GetCapacityResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCapacityResponseBodyData Data { get; set; }
        public class GetCapacityResponseBodyData : TeaModel {
            [NameInMap("ExistLogStore")]
            [Validation(Required=false)]
            public bool? ExistLogStore { get; set; }

            [NameInMap("PreservedCapacity")]
            [Validation(Required=false)]
            public long? PreservedCapacity { get; set; }

            [NameInMap("UsedCapacity")]
            [Validation(Required=false)]
            public double? UsedCapacity { get; set; }

        }

        [NameInMap("DyCode")]
        [Validation(Required=false)]
        public string DyCode { get; set; }

        [NameInMap("DyMessage")]
        [Validation(Required=false)]
        public string DyMessage { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
