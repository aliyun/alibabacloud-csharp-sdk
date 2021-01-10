// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeantcodeAntcodeSearchblobsRequest : TeaModel {
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

    }

}
