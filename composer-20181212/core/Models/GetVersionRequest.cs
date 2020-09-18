// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GetVersionRequest : TeaModel {
        [NameInMap("FlowId")]
        [Validation(Required=true)]
        public string FlowId { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=true)]
        public int? VersionId { get; set; }

    }

}
