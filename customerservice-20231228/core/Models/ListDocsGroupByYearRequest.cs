// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class ListDocsGroupByYearRequest : TeaModel {
        [NameInMap("applyCodes")]
        [Validation(Required=false)]
        public List<string> ApplyCodes { get; set; }

        [NameInMap("fileNameKeyword")]
        [Validation(Required=false)]
        public string FileNameKeyword { get; set; }

        [NameInMap("orderIds")]
        [Validation(Required=false)]
        public List<long?> OrderIds { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
