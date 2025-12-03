// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class ListQosPoliciesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("QosPolicies")]
        [Validation(Required=false)]
        public List<ListQosPoliciesResponseBodyQosPolicies> QosPolicies { get; set; }
        public class ListQosPoliciesResponseBodyQosPolicies : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FederationId")]
            [Validation(Required=false)]
            public string FederationId { get; set; }

            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            [NameInMap("FlowIds")]
            [Validation(Required=false)]
            public string FlowIds { get; set; }

            [NameInMap("MaxIOBandWidth")]
            [Validation(Required=false)]
            public long? MaxIOBandWidth { get; set; }

            [NameInMap("MaxIOps")]
            [Validation(Required=false)]
            public long? MaxIOps { get; set; }

            [NameInMap("MaxMetaQps")]
            [Validation(Required=false)]
            public long? MaxMetaQps { get; set; }

            [NameInMap("QosPolicyId")]
            [Validation(Required=false)]
            public string QosPolicyId { get; set; }

            [NameInMap("ReqTags")]
            [Validation(Required=false)]
            public string ReqTags { get; set; }

            [NameInMap("ZoneIds")]
            [Validation(Required=false)]
            public string ZoneIds { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
