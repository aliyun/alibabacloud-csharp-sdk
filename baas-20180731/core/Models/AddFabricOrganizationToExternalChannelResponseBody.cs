// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class AddFabricOrganizationToExternalChannelResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<AddFabricOrganizationToExternalChannelResponseBodyResult> Result { get; set; }
        public class AddFabricOrganizationToExternalChannelResponseBodyResult : TeaModel {
            [NameInMap("M")]
            [Validation(Required=false)]
            public int? M { get; set; }

            [NameInMap("N")]
            [Validation(Required=false)]
            public int? N { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
