// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class V1MediaSecurityStorageRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppSettings")]
        [Validation(Required=false)]
        public AppsSettings AppSettings { get; set; }

        [NameInMap("AssetId")]
        [Validation(Required=false)]
        public string AssetId { get; set; }

        [NameInMap("Customer")]
        [Validation(Required=false)]
        public CommonCustomer Customer { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public CommonMediaResource Image { get; set; }

        [NameInMap("ImageStorage")]
        [Validation(Required=false)]
        public CommonStorage ImageStorage { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public CommonMediaResource Video { get; set; }

        [NameInMap("VideoStorage")]
        [Validation(Required=false)]
        public CommonStorage VideoStorage { get; set; }

    }

}
