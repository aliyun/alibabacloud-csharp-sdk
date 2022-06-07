// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class GetWsCustomizedChEcomTitleRequest : TeaModel {
        [NameInMap("OutType")]
        [Validation(Required=false)]
        public string OutType { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("TokenizerId")]
        [Validation(Required=false)]
        public string TokenizerId { get; set; }

    }

}
