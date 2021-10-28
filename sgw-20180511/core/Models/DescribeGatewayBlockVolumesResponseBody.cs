// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayBlockVolumesResponseBody : TeaModel {
        [NameInMap("BlockVolumes")]
        [Validation(Required=false)]
        public DescribeGatewayBlockVolumesResponseBodyBlockVolumes BlockVolumes { get; set; }
        public class DescribeGatewayBlockVolumesResponseBodyBlockVolumes : TeaModel {
            [NameInMap("BlockVolume")]
            [Validation(Required=false)]
            public List<DescribeGatewayBlockVolumesResponseBodyBlockVolumesBlockVolume> BlockVolume { get; set; }
            public class DescribeGatewayBlockVolumesResponseBodyBlockVolumesBlockVolume : TeaModel {
                public string Address { get; set; }
                public string CacheMode { get; set; }
                public bool? ChapEnabled { get; set; }
                public string ChapInUser { get; set; }
                public int? ChunkSize { get; set; }
                public string DiskId { get; set; }
                public string DiskType { get; set; }
                public bool? Enabled { get; set; }
                public string IndexId { get; set; }
                public string LocalPath { get; set; }
                public int? LunId { get; set; }
                public string Name { get; set; }
                public string OssBucketName { get; set; }
                public bool? OssBucketSsl { get; set; }
                public string OssEndpoint { get; set; }
                public int? Port { get; set; }
                public string Protocol { get; set; }
                public long? Size { get; set; }
                public string State { get; set; }
                public int? Status { get; set; }
                public string Target { get; set; }
                public long? TotalDownload { get; set; }
                public long? TotalUpload { get; set; }
                public int? VolumeState { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
