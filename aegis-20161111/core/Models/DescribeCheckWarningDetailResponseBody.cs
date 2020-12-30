// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aegis20161111.Models
{
    public class DescribeCheckWarningDetailResponseBody : TeaModel {
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        [NameInMap("Advice")]
        [Validation(Required=false)]
        public string Advice { get; set; }

    }

}
