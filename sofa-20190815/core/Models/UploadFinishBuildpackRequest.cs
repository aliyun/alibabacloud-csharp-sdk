// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UploadFinishBuildpackRequest : TeaModel {
        [NameInMap("BuildpackId")]
        [Validation(Required=false)]
        public string BuildpackId { get; set; }

        [NameInMap("BuildpackRegionRelationJsonStr")]
        [Validation(Required=false)]
        public string BuildpackRegionRelationJsonStr { get; set; }

    }

}
