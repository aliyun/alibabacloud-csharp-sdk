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
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("CacheMode")]
                [Validation(Required=false)]
                public string CacheMode { get; set; }

                [NameInMap("ChapEnabled")]
                [Validation(Required=false)]
                public bool? ChapEnabled { get; set; }

                [NameInMap("ChapInUser")]
                [Validation(Required=false)]
                public string ChapInUser { get; set; }

                [NameInMap("ChunkSize")]
                [Validation(Required=false)]
                public int? ChunkSize { get; set; }

                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("IndexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                [NameInMap("LocalPath")]
                [Validation(Required=false)]
                public string LocalPath { get; set; }

                /// <summary>
                /// LUN ID。
                /// </summary>
                [NameInMap("LunId")]
                [Validation(Required=false)]
                public int? LunId { get; set; }

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

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("TotalDownload")]
                [Validation(Required=false)]
                public long? TotalDownload { get; set; }

                [NameInMap("TotalUpload")]
                [Validation(Required=false)]
                public long? TotalUpload { get; set; }

                [NameInMap("VolumeState")]
                [Validation(Required=false)]
                public int? VolumeState { get; set; }

            }

        }

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
