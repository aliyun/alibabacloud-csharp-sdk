// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20171030.Models
{
    public class TransferFxUserToResellerRequest : TeaModel {
        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        [NameInMap("QuotaAmount")]
        [Validation(Required=false)]
        public int? QuotaAmount { get; set; }

        [NameInMap("ShutdownStatus")]
        [Validation(Required=false)]
        public int? ShutdownStatus { get; set; }

        [NameInMap("TansferScene")]
        [Validation(Required=false)]
        public int? TansferScene { get; set; }

        [NameInMap("TransferUid")]
        [Validation(Required=false)]
        public string TransferUid { get; set; }

    }

}
