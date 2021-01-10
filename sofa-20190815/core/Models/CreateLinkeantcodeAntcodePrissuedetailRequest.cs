// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeantcodeAntcodePrissuedetailRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IssuesJsonStr")]
        [Validation(Required=false)]
        public string IssuesJsonStr { get; set; }

        [NameInMap("PrId")]
        [Validation(Required=false)]
        public string PrId { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
