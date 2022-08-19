// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesRequest : TeaModel {
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<string> RuleIds { get; set; }

    }

}
