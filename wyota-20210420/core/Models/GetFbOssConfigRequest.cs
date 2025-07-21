// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetFbOssConfigRequest : TeaModel {
        [NameInMap("AreaSite")]
        [Validation(Required=false)]
        public string AreaSite { get; set; }

        [NameInMap("DirPrefix")]
        [Validation(Required=false)]
        public string DirPrefix { get; set; }

        [NameInMap("IsDedicatedLine")]
        [Validation(Required=false)]
        public int? IsDedicatedLine { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
