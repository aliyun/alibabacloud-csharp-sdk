// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterInterceptionConfigResponseBody : TeaModel {
        [NameInMap("ClusterConfigList")]
        [Validation(Required=false)]
        public List<ListClusterInterceptionConfigResponseBodyClusterConfigList> ClusterConfigList { get; set; }
        public class ListClusterInterceptionConfigResponseBodyClusterConfigList : TeaModel {
            [NameInMap("ClusterCNNFStatus")]
            [Validation(Required=false)]
            public int? ClusterCNNFStatus { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            [NameInMap("InterceptionSwitch")]
            [Validation(Required=false)]
            public int? InterceptionSwitch { get; set; }

            [NameInMap("OpenRuleCount")]
            [Validation(Required=false)]
            public long? OpenRuleCount { get; set; }

            [NameInMap("SupportCNNF")]
            [Validation(Required=false)]
            public bool? SupportCNNF { get; set; }

            [NameInMap("TotalRuleCount")]
            [Validation(Required=false)]
            public long? TotalRuleCount { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClusterInterceptionConfigResponseBodyPageInfo PageInfo { get; set; }
        public class ListClusterInterceptionConfigResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrrentPage")]
            [Validation(Required=false)]
            public int? CurrrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
