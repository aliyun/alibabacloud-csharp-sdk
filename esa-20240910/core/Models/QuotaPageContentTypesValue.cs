// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class QuotaPageContentTypesValue : TeaModel {
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("ContentLength")]
        [Validation(Required=false)]
        public WafQuotaInteger ContentLength { get; set; }

    }

}
