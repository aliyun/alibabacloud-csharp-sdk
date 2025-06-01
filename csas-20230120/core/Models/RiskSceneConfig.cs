// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class RiskSceneConfig : TeaModel {
        [NameInMap("DetectChannel")]
        [Validation(Required=false)]
        public List<string> DetectChannel { get; set; }

        [NameInMap("OfficeChannel")]
        [Validation(Required=false)]
        public List<string> OfficeChannel { get; set; }

    }

}
