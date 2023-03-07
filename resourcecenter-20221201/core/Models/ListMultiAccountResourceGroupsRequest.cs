// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListMultiAccountResourceGroupsRequest : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

    }

}
