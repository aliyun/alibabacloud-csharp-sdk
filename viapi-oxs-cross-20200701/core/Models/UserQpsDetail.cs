// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_oxs_cross20200701.Models
{
    public class UserQpsDetail : TeaModel {
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("Day")]
        [Validation(Required=false)]
        public string Day { get; set; }

        [NameInMap("Qps")]
        [Validation(Required=false)]
        public int? Qps { get; set; }

        [NameInMap("QpsRule")]
        [Validation(Required=false)]
        public string QpsRule { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
