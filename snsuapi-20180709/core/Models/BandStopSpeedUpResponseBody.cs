// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Snsuapi20180709.Models
{
    public class BandStopSpeedUpResponseBody : TeaModel {
        [NameInMap("ResultModule")]
        [Validation(Required=false)]
        public bool? ResultModule { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
