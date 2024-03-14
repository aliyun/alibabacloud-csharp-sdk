// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210519.Models
{
    public class SearchAlertContactGroupRequest : TeaModel {
        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public string ContactGroupIds { get; set; }

        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("IsDetail")]
        [Validation(Required=false)]
        public bool? IsDetail { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
