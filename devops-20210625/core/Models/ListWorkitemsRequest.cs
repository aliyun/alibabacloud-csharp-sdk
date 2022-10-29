// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkitemsRequest : TeaModel {
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        [NameInMap("extraConditions")]
        [Validation(Required=false)]
        public string ExtraConditions { get; set; }

        [NameInMap("groupCondition")]
        [Validation(Required=false)]
        public string GroupCondition { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        [NameInMap("spaceIdentifier")]
        [Validation(Required=false)]
        public string SpaceIdentifier { get; set; }

        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

    }

}
