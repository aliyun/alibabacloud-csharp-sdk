// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyCustomizedListHeadersRequest : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public List<ModifyCustomizedListHeadersRequestHeaders> Headers { get; set; }
        public class ModifyCustomizedListHeadersRequestHeaders : TeaModel {
            [NameInMap("DisplayType")]
            [Validation(Required=false)]
            public string DisplayType { get; set; }

            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

        }

        [NameInMap("ListType")]
        [Validation(Required=false)]
        public string ListType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
