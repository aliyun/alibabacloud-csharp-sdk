// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class DescirbeCombineTrademarkRequest : TeaModel {
        [NameInMap("AccurateMatch")]
        [Validation(Required=false)]
        public bool? AccurateMatch { get; set; }

        [NameInMap("Classification")]
        [Validation(Required=false)]
        public string Classification { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerName")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Products")]
        [Validation(Required=false)]
        public string Products { get; set; }

        [NameInMap("RegistrationNumber")]
        [Validation(Required=false)]
        public string RegistrationNumber { get; set; }

        [NameInMap("SimilarGroups")]
        [Validation(Required=false)]
        public string SimilarGroups { get; set; }

    }

}
