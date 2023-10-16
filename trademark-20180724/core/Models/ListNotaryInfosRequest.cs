// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class ListNotaryInfosRequest : TeaModel {
        [NameInMap("BizOrderNo")]
        [Validation(Required=false)]
        public string BizOrderNo { get; set; }

        [NameInMap("NotaryType")]
        [Validation(Required=false)]
        public int? NotaryType { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
