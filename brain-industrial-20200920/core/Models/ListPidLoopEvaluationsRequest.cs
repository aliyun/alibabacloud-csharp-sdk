// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListPidLoopEvaluationsRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PidProjectId")]
        [Validation(Required=true)]
        public string PidProjectId { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OrderByProperty")]
        [Validation(Required=false)]
        public string OrderByProperty { get; set; }

        [NameInMap("PidLoopName")]
        [Validation(Required=false)]
        public string PidLoopName { get; set; }

        [NameInMap("Grade")]
        [Validation(Required=false)]
        public string Grade { get; set; }

        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

    }

}
