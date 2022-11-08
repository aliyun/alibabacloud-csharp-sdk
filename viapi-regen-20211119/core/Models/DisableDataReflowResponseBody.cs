// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class DisableDataReflowResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DisableDataReflowResponseBodyData Data { get; set; }
        public class DisableDataReflowResponseBodyData : TeaModel {
            [NameInMap("EnableDataReflowFlag")]
            [Validation(Required=false)]
            public bool? EnableDataReflowFlag { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
