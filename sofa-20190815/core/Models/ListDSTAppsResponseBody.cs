// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Apps")]
        [Validation(Required=false)]
        public List<ListDSTAppsResponseBodyApps> Apps { get; set; }
        public class ListDSTAppsResponseBodyApps : TeaModel {
            [NameInMap("BizLogAppCreator")]
            [Validation(Required=false)]
            public string BizLogAppCreator { get; set; }

            [NameInMap("BizLogConfigCount")]
            [Validation(Required=false)]
            public long? BizLogConfigCount { get; set; }

            [NameInMap("BizLogEnabled")]
            [Validation(Required=false)]
            public bool? BizLogEnabled { get; set; }

            [NameInMap("Collected")]
            [Validation(Required=false)]
            public bool? Collected { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
