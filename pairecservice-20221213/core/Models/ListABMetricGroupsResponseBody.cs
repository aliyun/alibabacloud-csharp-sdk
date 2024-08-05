// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListABMetricGroupsResponseBody : TeaModel {
        [NameInMap("ABMetricGroups")]
        [Validation(Required=false)]
        public List<ListABMetricGroupsResponseBodyABMetricGroups> ABMetricGroups { get; set; }
        public class ListABMetricGroupsResponseBodyABMetricGroups : TeaModel {
            [NameInMap("ABMetricGroupId")]
            [Validation(Required=false)]
            public string ABMetricGroupId { get; set; }

            [NameInMap("ABMetricIds")]
            [Validation(Required=false)]
            public string ABMetricIds { get; set; }

            [NameInMap("ABMetricNames")]
            [Validation(Required=false)]
            public string ABMetricNames { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("Realtime")]
            [Validation(Required=false)]
            public bool? Realtime { get; set; }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
