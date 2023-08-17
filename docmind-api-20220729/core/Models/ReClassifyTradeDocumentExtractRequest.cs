// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220729.Models
{
    public class ReClassifyTradeDocumentExtractRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("PageUpdateInfoModels")]
        [Validation(Required=false)]
        public List<ReClassifyTradeDocumentExtractRequestPageUpdateInfoModels> PageUpdateInfoModels { get; set; }
        public class ReClassifyTradeDocumentExtractRequestPageUpdateInfoModels : TeaModel {
            [NameInMap("AttTypeCode")]
            [Validation(Required=false)]
            public string AttTypeCode { get; set; }

            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

        }

    }

}
