// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetOpaClusterBaseLineListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOpaClusterBaseLineListResponseBodyData> Data { get; set; }
        public class GetOpaClusterBaseLineListResponseBodyData : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("ClassKey")]
            [Validation(Required=false)]
            public string ClassKey { get; set; }

            [NameInMap("ItemKey")]
            [Validation(Required=false)]
            public string ItemKey { get; set; }

            [NameInMap("NameKey")]
            [Validation(Required=false)]
            public string NameKey { get; set; }

        }

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
