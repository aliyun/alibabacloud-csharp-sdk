// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class FilterUnavailableCodesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public FilterUnavailableCodesResponseBodyData Data { get; set; }
        public class FilterUnavailableCodesResponseBodyData : TeaModel {
            [NameInMap("Codes")]
            [Validation(Required=false)]
            public List<string> Codes { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
