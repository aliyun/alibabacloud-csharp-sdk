// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutIterationgetunitsbyexternalldRequest : TeaModel {
        [NameInMap("Current")]
        [Validation(Required=false)]
        public string Current { get; set; }

        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("WithDeleted")]
        [Validation(Required=false)]
        public string WithDeleted { get; set; }

    }

}
