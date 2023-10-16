// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkUploadAuditResultRequest : TeaModel {
        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegisterCode")]
        [Validation(Required=false)]
        public string RegisterCode { get; set; }

        [NameInMap("RegisterNumber")]
        [Validation(Required=false)]
        public string RegisterNumber { get; set; }

        [NameInMap("TmType")]
        [Validation(Required=false)]
        public string TmType { get; set; }

    }

}
