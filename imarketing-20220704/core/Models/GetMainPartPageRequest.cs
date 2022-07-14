// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetMainPartPageRequest : TeaModel {
        [NameInMap("MainId")]
        [Validation(Required=false)]
        public long? MainId { get; set; }

        [NameInMap("MainName")]
        [Validation(Required=false)]
        public string MainName { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
