// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class SetClusterNameRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=true)]
        public string ClusterId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=true)]
        public string Name { get; set; }

    }

}
