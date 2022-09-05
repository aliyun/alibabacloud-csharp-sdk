// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class QueryAuditResultRequest : TeaModel {
        [NameInMap("DspId")]
        [Validation(Required=false)]
        public string DspId { get; set; }

        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<string> Ids { get; set; }

    }

}
