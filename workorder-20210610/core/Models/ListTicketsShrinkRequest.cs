// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class ListTicketsShrinkRequest : TeaModel {
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        [NameInMap("TicketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        [NameInMap("TicketIdList")]
        [Validation(Required=false)]
        public string TicketIdListShrink { get; set; }

    }

}
