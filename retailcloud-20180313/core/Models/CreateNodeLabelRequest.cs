// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateNodeLabelRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("LabelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        [NameInMap("LabelValue")]
        [Validation(Required=false)]
        public string LabelValue { get; set; }

    }

}
