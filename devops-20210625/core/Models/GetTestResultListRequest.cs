// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetTestResultListRequest : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        [NameInMap("directoryIdentifier")]
        [Validation(Required=false)]
        public string DirectoryIdentifier { get; set; }

    }

}
