// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class CreateGatewayBlockVolumeRequest : TeaModel {
        [NameInMap("CacheMode")]
        [Validation(Required=false)]
        public string CacheMode { get; set; }

        [NameInMap("ChapEnabled")]
        [Validation(Required=false)]
        public bool? ChapEnabled { get; set; }

        [NameInMap("ChapInPassword")]
        [Validation(Required=false)]
        public string ChapInPassword { get; set; }

        [NameInMap("ChapInUser")]
        [Validation(Required=false)]
        public string ChapInUser { get; set; }

        [NameInMap("ChunkSize")]
        [Validation(Required=false)]
        public int? ChunkSize { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("LocalFilePath")]
        [Validation(Required=false)]
        public string LocalFilePath { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("OssBucketSsl")]
        [Validation(Required=false)]
        public bool? OssBucketSsl { get; set; }

        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        [NameInMap("Recovery")]
        [Validation(Required=false)]
        public bool? Recovery { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("VolumeProtocol")]
        [Validation(Required=false)]
        public string VolumeProtocol { get; set; }

    }

}
