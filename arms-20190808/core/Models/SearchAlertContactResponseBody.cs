// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertContactResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertContactResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertContactResponseBodyPageBean : TeaModel {
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<SearchAlertContactResponseBodyPageBeanContacts> Contacts { get; set; }
            public class SearchAlertContactResponseBodyPageBeanContacts : TeaModel {
                public long? UpdateTime { get; set; }
                public string DingRobot { get; set; }
                public string Webhook { get; set; }
                public string Email { get; set; }
                public long? ContactId { get; set; }
                public long? CreateTime { get; set; }
                public string UserId { get; set; }
                public string ContactName { get; set; }
                public bool? SystemNoc { get; set; }
                public string Phone { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
