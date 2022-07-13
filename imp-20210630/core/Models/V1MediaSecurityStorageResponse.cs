// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class V1MediaSecurityStorageResponse : TeaModel {
        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public CommonMediaResource Image { get; set; }

        [NameInMap("ImageStorage")]
        [Validation(Required=false)]
        public CommonStorage ImageStorage { get; set; }

        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public CommonMediaResource Video { get; set; }

        [NameInMap("VideoStorage")]
        [Validation(Required=false)]
        public CommonStorage VideoStorage { get; set; }

    }

}
