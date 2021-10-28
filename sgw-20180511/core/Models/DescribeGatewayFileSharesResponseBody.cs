// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayFileSharesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FileShares")]
        [Validation(Required=false)]
        public DescribeGatewayFileSharesResponseBodyFileShares FileShares { get; set; }
        public class DescribeGatewayFileSharesResponseBodyFileShares : TeaModel {
            [NameInMap("FileShare")]
            [Validation(Required=false)]
            public List<DescribeGatewayFileSharesResponseBodyFileSharesFileShare> FileShare { get; set; }
            public class DescribeGatewayFileSharesResponseBodyFileSharesFileShare : TeaModel {
                public bool? AccessBasedEnumeration { get; set; }
                public long? ActiveMessages { get; set; }
                public string Address { get; set; }
                public int? BeLimit { get; set; }
                public bool? Browsable { get; set; }
                public string BucketInfos { get; set; }
                public bool? BucketsStub { get; set; }
                public bool? BypassCacheRead { get; set; }
                public string CacheMode { get; set; }
                public string ClientSideCmk { get; set; }
                public bool? ClientSideEncryption { get; set; }
                public bool? DirectIO { get; set; }
                public string DiskId { get; set; }
                public string DiskType { get; set; }
                public int? DownloadLimit { get; set; }
                public long? DownloadQueue { get; set; }
                public long? DownloadRate { get; set; }
                public bool? Enabled { get; set; }
                public string ExpressSyncId { get; set; }
                public bool? FastReclaim { get; set; }
                public int? FeLimit { get; set; }
                public long? FileNumLimit { get; set; }
                public long? FsSizeLimit { get; set; }
                public int? HighWatermark { get; set; }
                public bool? IgnoreDelete { get; set; }
                public bool? InPlace { get; set; }
                public long? InRate { get; set; }
                public string IndexId { get; set; }
                public string KmsRotatePeriod { get; set; }
                public long? LagPeriod { get; set; }
                public string LocalPath { get; set; }
                public int? LowWatermark { get; set; }
                public string MnsHealth { get; set; }
                public string Name { get; set; }
                public bool? NfsV4Optimization { get; set; }
                public string ObsoleteBuckets { get; set; }
                public string OssBucketName { get; set; }
                public bool? OssBucketSsl { get; set; }
                public string OssEndpoint { get; set; }
                public string OssHealth { get; set; }
                public long? OssUsed { get; set; }
                public long? OutRate { get; set; }
                public string PartialSyncPaths { get; set; }
                public string PathPrefix { get; set; }
                public int? PollingInterval { get; set; }
                public string Protocol { get; set; }
                public long? RemainingMetaSpace { get; set; }
                public bool? RemoteSync { get; set; }
                public bool? RemoteSyncDownload { get; set; }
                public string RoClientList { get; set; }
                public string RoUserList { get; set; }
                public string RwClientList { get; set; }
                public string RwUserList { get; set; }
                public string ServerSideAlgorithm { get; set; }
                public string ServerSideCmk { get; set; }
                public bool? ServerSideEncryption { get; set; }
                public long? Size { get; set; }
                public string Squash { get; set; }
                public string State { get; set; }
                public bool? SupportArchive { get; set; }
                public int? SyncProgress { get; set; }
                public bool? Throttling { get; set; }
                public long? TotalDownload { get; set; }
                public long? TotalUpload { get; set; }
                public bool? TransferAcceleration { get; set; }
                public long? UploadQueue { get; set; }
                public long? Used { get; set; }
                public bool? WindowsAcl { get; set; }
            }
        };

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
