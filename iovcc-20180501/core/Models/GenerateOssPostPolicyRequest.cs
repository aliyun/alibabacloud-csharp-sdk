// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GenerateOssPostPolicyRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("AccessId")]
        [Validation(Required=false)]
        public string AccessId { get; set; }

        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

    }

}
