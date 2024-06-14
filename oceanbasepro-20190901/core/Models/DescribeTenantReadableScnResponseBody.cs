// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantReadableScnResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeTenantReadableScnResponseBodyData Data { get; set; }
        public class DescribeTenantReadableScnResponseBodyData : TeaModel {
            [NameInMap("ReadableScn")]
            [Validation(Required=false)]
            public long? ReadableScn { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
