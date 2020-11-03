// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class BindIntervenePackageAndModelResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public int? Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public string Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

    }

}
