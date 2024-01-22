// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ApplicationWithStatus : TeaModel {
        [NameInMap("application")]
        [Validation(Required=false)]
        public Application Application { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public ApplicationStatus Status { get; set; }

    }

}
