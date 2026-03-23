// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20200801.Models
{
    public class ListTicketsRequest : TeaModel {
        [NameInMap("CreatedAfterTime")]
        [Validation(Required=false)]
        public string CreatedAfterTime { get; set; }

        [NameInMap("CreatedBeforeTime")]
        [Validation(Required=false)]
        public string CreatedBeforeTime { get; set; }

        [NameInMap("ExtraConditionList")]
        [Validation(Required=false)]
        public List<ListTicketsRequestExtraConditionList> ExtraConditionList { get; set; }
        public class ListTicketsRequestExtraConditionList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageStart")]
        [Validation(Required=false)]
        public int? PageStart { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("TicketStatus")]
        [Validation(Required=false)]
        public string TicketStatus { get; set; }

    }

}
