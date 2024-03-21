// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class DescribeFingerPrintTemplatesResponseBody : TeaModel {
        [NameInMap("FingerPrintTemplates")]
        [Validation(Required=false)]
        public List<DescribeFingerPrintTemplatesResponseBodyFingerPrintTemplates> FingerPrintTemplates { get; set; }
        public class DescribeFingerPrintTemplatesResponseBodyFingerPrintTemplates : TeaModel {
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("LoginTime")]
            [Validation(Required=false)]
            public string LoginTime { get; set; }

            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
