// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CsiGetFileInfoResponseBody : TeaModel {
        [NameInMap("investigation_info")]
        [Validation(Required=false)]
        public InvestigationInfo InvestigationInfo { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
