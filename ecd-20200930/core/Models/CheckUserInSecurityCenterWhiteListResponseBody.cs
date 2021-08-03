// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CheckUserInSecurityCenterWhiteListResponseBody : TeaModel {
        [NameInMap("InWhiteList")]
        [Validation(Required=false)]
        public bool? InWhiteList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
