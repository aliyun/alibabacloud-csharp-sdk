// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetSwimLaneDetailResponseBody : TeaModel {
        [NameInMap("IngressRule")]
        [Validation(Required=false)]
        public string IngressRule { get; set; }

        [NameInMap("IngressService")]
        [Validation(Required=false)]
        public string IngressService { get; set; }

        [NameInMap("LabelSelectorKey")]
        [Validation(Required=false)]
        public string LabelSelectorKey { get; set; }

        [NameInMap("LabelSelectorValue")]
        [Validation(Required=false)]
        public string LabelSelectorValue { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

    }

}
