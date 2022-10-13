// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListCurrentUsageForResourceGroupResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCurrentUsageForResourceGroupResponseBodyData Data { get; set; }
        public class ListCurrentUsageForResourceGroupResponseBodyData : TeaModel {
            [NameInMap("RecodeTime")]
            [Validation(Required=false)]
            public long? RecodeTime { get; set; }

            [NameInMap("Usage")]
            [Validation(Required=false)]
            public float? Usage { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
