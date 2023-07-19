// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAllWhitelistTemplateRequest : TeaModel {
        [NameInMap("FuzzySearch")]
        [Validation(Required=false)]
        public bool? FuzzySearch { get; set; }

        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
