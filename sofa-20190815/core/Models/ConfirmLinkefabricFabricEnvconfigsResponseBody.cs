// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ConfirmLinkefabricFabricEnvconfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ConfirmLinkefabricFabricEnvconfigsResponseBodyData Data { get; set; }
        public class ConfirmLinkefabricFabricEnvconfigsResponseBodyData : TeaModel {
            [NameInMap("AntxChangeJson")]
            [Validation(Required=false)]
            public string AntxChangeJson { get; set; }
            [NameInMap("AntxConflictInfo")]
            [Validation(Required=false)]
            public List<string> AntxConflictInfo { get; set; }
            [NameInMap("LinkeUrl")]
            [Validation(Required=false)]
            public string LinkeUrl { get; set; }
            [NameInMap("DelKeyList")]
            [Validation(Required=false)]
            public List<string> DelKeyList { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
