// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCASUserRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("CustomerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IsLocaleEnabled")]
        [Validation(Required=false)]
        public bool? IsLocaleEnabled { get; set; }

        [NameInMap("Local")]
        [Validation(Required=false)]
        public string Local { get; set; }

        [NameInMap("LoginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("OrdersRepeatList")]
        [Validation(Required=false)]
        public List<string> OrdersRepeatList { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Paging")]
        [Validation(Required=false)]
        public bool? Paging { get; set; }

        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("RealName")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        [NameInMap("Search")]
        [Validation(Required=false)]
        public bool? Search { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("TypesRepeatList")]
        [Validation(Required=false)]
        public List<string> TypesRepeatList { get; set; }

    }

}
