// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertContactRequest : TeaModel {
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public string ProxyUserId { get; set; }

        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

    }

}
