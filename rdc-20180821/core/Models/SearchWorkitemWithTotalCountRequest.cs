// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class SearchWorkitemWithTotalCountRequest : TeaModel {
        [NameInMap("Stamp")]
        [Validation(Required=false)]
        public string Stamp { get; set; }

        [NameInMap("AKProjectId")]
        [Validation(Required=false)]
        public int? AKProjectId { get; set; }

        [NameInMap("ToPage")]
        [Validation(Required=false)]
        public int? ToPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

        [NameInMap("SprintId")]
        [Validation(Required=false)]
        public int? SprintId { get; set; }

    }

}
