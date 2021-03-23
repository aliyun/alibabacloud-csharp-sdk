// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ModifyCostUnitResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ModifyCostUnitResponseBodyData> Data { get; set; }
        public class ModifyCostUnitResponseBodyData : TeaModel {
            [NameInMap("IsSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

            [NameInMap("UnitId")]
            [Validation(Required=false)]
            public long? UnitId { get; set; }

            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

        }

    }

}
