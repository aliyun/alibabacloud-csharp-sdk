// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddShowIntoShowListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        [NameInMap("failedList")]
        [Validation(Required=false)]
        public string FailedList { get; set; }

        [NameInMap("successfulShowIds")]
        [Validation(Required=false)]
        public string SuccessfulShowIds { get; set; }

    }

}
