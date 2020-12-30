// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rdc20180821.Models
{
    public class SearchTestCaseRequest : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CorpIdentifier")]
        [Validation(Required=false)]
        public string CorpIdentifier { get; set; }

        [NameInMap("AkProjectId")]
        [Validation(Required=false)]
        public string AkProjectId { get; set; }

        [NameInMap("CaseTag")]
        [Validation(Required=false)]
        public string CaseTag { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        [NameInMap("CreateDateStart")]
        [Validation(Required=false)]
        public string CreateDateStart { get; set; }

        [NameInMap("CreateDateEnd")]
        [Validation(Required=false)]
        public string CreateDateEnd { get; set; }

        [NameInMap("UpdateDateStart")]
        [Validation(Required=false)]
        public string UpdateDateStart { get; set; }

        [NameInMap("UpdateDateEnd")]
        [Validation(Required=false)]
        public string UpdateDateEnd { get; set; }

    }

}
