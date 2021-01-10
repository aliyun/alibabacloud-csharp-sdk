// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeantcodeAntcodeProjectrepositorysearchRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("RefName")]
        [Validation(Required=false)]
        public string RefName { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
