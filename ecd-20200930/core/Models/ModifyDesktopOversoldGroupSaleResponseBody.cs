// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDesktopOversoldGroupSaleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyDesktopOversoldGroupSaleResponseBodyData Data { get; set; }
        public class ModifyDesktopOversoldGroupSaleResponseBodyData : TeaModel {
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("OversoldGroupId")]
            [Validation(Required=false)]
            public string OversoldGroupId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
