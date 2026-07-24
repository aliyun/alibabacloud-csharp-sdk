// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DqlResult : TeaModel {
        [NameInMap("statementIndex")]
        [Validation(Required=false)]
        public int? StatementIndex { get; set; }

        [NameInMap("submitPreviewResult")]
        [Validation(Required=false)]
        public SubmitPreviewResult SubmitPreviewResult { get; set; }

        [NameInMap("tableResults")]
        [Validation(Required=false)]
        public List<TableResult> TableResults { get; set; }

    }

}
