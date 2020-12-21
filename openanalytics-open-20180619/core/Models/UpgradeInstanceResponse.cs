// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class UpgradeInstanceResponse : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=true)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorInfo")]
        [Validation(Required=true)]
        public string ErrorInfo { get; set; }

        [NameInMap("Result")]
        [Validation(Required=true)]
        public string Result { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

    }

}
