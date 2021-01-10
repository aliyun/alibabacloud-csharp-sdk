// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ModifyAppServiceBuildpackRelationRequest : TeaModel {
        [NameInMap("NewAppServiceJsonStr")]
        [Validation(Required=false)]
        public string NewAppServiceJsonStr { get; set; }

        [NameInMap("OriginalAppServiceJsonStr")]
        [Validation(Required=false)]
        public string OriginalAppServiceJsonStr { get; set; }

    }

}
