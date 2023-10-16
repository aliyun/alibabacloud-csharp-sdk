// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryTrademarkMonitorResultsRequest : TeaModel {
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        [NameInMap("ApplyYear")]
        [Validation(Required=false)]
        public string ApplyYear { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProcedureStatus")]
        [Validation(Required=false)]
        public int? ProcedureStatus { get; set; }

        [NameInMap("RegistrationNumber")]
        [Validation(Required=false)]
        public string RegistrationNumber { get; set; }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

    }

}
