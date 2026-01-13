// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241121.Models
{
    public class ServiceConfigResult : TeaModel {
        [NameInMap("poiSearchTotalQuota")]
        [Validation(Required=false)]
        public string PoiSearchTotalQuota { get; set; }

        [NameInMap("poiSearchUsedQuota")]
        [Validation(Required=false)]
        public string PoiSearchUsedQuota { get; set; }

        [NameInMap("searchTotalQuota")]
        [Validation(Required=false)]
        public string SearchTotalQuota { get; set; }

        [NameInMap("searchUsedQuota")]
        [Validation(Required=false)]
        public string SearchUsedQuota { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
