// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeBahamutReleasedependencyRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("DependencyRepeatList")]
        [Validation(Required=false)]
        public List<string> DependencyRepeatList { get; set; }

        [NameInMap("ReleaseExternalId")]
        [Validation(Required=false)]
        public string ReleaseExternalId { get; set; }

    }

}
