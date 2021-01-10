// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeUpdatesanexistinglabelwithnewnameornowcolorRequest : TeaModel {
        [NameInMap("Color")]
        [Validation(Required=false)]
        public string Color { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IdOrName")]
        [Validation(Required=false)]
        public string IdOrName { get; set; }

        [NameInMap("NewName")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
