// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class FetchResult : TeaModel {
        [NameInMap("resultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("resultType")]
        [Validation(Required=false)]
        public string ResultType { get; set; }

        [NameInMap("tableResults")]
        [Validation(Required=false)]
        public List<TableResult> TableResults { get; set; }

    }

}
