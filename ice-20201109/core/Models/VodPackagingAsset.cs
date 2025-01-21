// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class VodPackagingAsset : TeaModel {
        [NameInMap("AssetName")]
        [Validation(Required=false)]
        public string AssetName { get; set; }

        [NameInMap("ContentId")]
        [Validation(Required=false)]
        public string ContentId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public VodPackagingAssetInput Input { get; set; }
        public class VodPackagingAssetInput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
