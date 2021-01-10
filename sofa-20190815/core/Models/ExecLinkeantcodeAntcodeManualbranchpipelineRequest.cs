// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeantcodeAntcodeManualbranchpipelineRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ManualPipelineRequestJsonStr")]
        [Validation(Required=false)]
        public string ManualPipelineRequestJsonStr { get; set; }

        [NameInMap("Ref")]
        [Validation(Required=false)]
        public string Ref { get; set; }

        [NameInMap("RequestGitOperate")]
        [Validation(Required=false)]
        public string RequestGitOperate { get; set; }

    }

}
