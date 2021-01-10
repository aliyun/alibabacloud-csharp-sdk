// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeantcodeAntcodeRepositoryfilesRequest : TeaModel {
        [NameInMap("FilePathRepeatList")]
        [Validation(Required=false)]
        public List<string> FilePathRepeatList { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PerPage")]
        [Validation(Required=false)]
        public string PerPage { get; set; }

        [NameInMap("Ref")]
        [Validation(Required=false)]
        public string Ref { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
