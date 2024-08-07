// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetMediaInfoRequest : TeaModel {
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        [NameInMap("ReturnDetailedInfo")]
        [Validation(Required=false)]
        public string ReturnDetailedInfo { get; set; }

    }

}
