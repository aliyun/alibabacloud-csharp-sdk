// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListMultiAccountTagValuesRequest : TeaModel {
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
