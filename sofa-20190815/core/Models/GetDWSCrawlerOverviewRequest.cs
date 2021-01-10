// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDWSCrawlerOverviewRequest : TeaModel {
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("CrawlerDbtype")]
        [Validation(Required=false)]
        public string CrawlerDbtype { get; set; }

        [NameInMap("CrawlerNames")]
        [Validation(Required=false)]
        public string CrawlerNames { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("OrderByParam")]
        [Validation(Required=false)]
        public string OrderByParam { get; set; }

        [NameInMap("OrderByType")]
        [Validation(Required=false)]
        public string OrderByType { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
