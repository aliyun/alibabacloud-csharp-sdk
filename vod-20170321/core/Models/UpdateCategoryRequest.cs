// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateCategoryRequest : TeaModel {
        [NameInMap("CateName")]
        [Validation(Required=false)]
        public string CateName { get; set; }

        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

    }

}
