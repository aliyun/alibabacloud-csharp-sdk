// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListPasskeysResponseBody : TeaModel {
        [NameInMap("Passkeys")]
        [Validation(Required=false)]
        public List<ListPasskeysResponseBodyPasskeys> Passkeys { get; set; }
        public class ListPasskeysResponseBodyPasskeys : TeaModel {
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("LastUseDate")]
            [Validation(Required=false)]
            public string LastUseDate { get; set; }

            [NameInMap("PasskeyId")]
            [Validation(Required=false)]
            public string PasskeyId { get; set; }

            [NameInMap("PasskeyName")]
            [Validation(Required=false)]
            public string PasskeyName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
