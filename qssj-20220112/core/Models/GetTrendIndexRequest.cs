// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetTrendIndexRequest : TeaModel {
        [NameInMap("CateIds")]
        [Validation(Required=false)]
        public string CateIds { get; set; }

        [NameInMap("MonthNum")]
        [Validation(Required=false)]
        public int? MonthNum { get; set; }

    }

}
