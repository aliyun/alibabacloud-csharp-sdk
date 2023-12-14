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
                [NameInMap("AccessBasedEnumeration")]
                [Validation(Required=false)]
                public bool? AccessBasedEnumeration { get; set; }

                [NameInMap("ActiveMessages")]
                [Validation(Required=false)]
                public long? ActiveMessages { get; set; }

                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("BeLimit")]
                [Validation(Required=false)]
                public int? BeLimit { get; set; }

                [NameInMap("Browsable")]
                [Validation(Required=false)]
                public bool? Browsable { get; set; }

                [NameInMap("BucketInfos")]
                [Validation(Required=false)]
                public string BucketInfos { get; set; }

                [NameInMap("BucketsStub")]
                [Validation(Required=false)]
                public bool? BucketsStub { get; set; }

                [NameInMap("BypassCacheRead")]
                [Validation(Required=false)]
                public bool? BypassCacheRead { get; set; }

                [NameInMap("CacheMode")]
                [Validation(Required=false)]
                public string CacheMode { get; set; }

                [NameInMap("ClientSideCmk")]
                [Validation(Required=false)]
                public string ClientSideCmk { get; set; }

                [NameInMap("ClientSideEncryption")]
                [Validation(Required=false)]
                public bool? ClientSideEncryption { get; set; }

                [NameInMap("DirectIO")]
                [Validation(Required=false)]
                public bool? DirectIO { get; set; }

                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                [NameInMap("DownloadLimit")]
                [Validation(Required=false)]
                public int? DownloadLimit { get; set; }

                [NameInMap("DownloadQueue")]
                [Validation(Required=false)]
                public long? DownloadQueue { get; set; }

                [NameInMap("DownloadRate")]
                [Validation(Required=false)]
                public long? DownloadRate { get; set; }

                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("ExpressSyncId")]
                [Validation(Required=false)]
                public string ExpressSyncId { get; set; }

                [NameInMap("FastReclaim")]
                [Validation(Required=false)]
                public bool? FastReclaim { get; set; }

                [NameInMap("FeLimit")]
                [Validation(Required=false)]
                public int? FeLimit { get; set; }

                [NameInMap("FileNumLimit")]
                [Validation(Required=false)]
                public long? FileNumLimit { get; set; }

                [NameInMap("FsSizeLimit")]
                [Validation(Required=false)]
                public long? FsSizeLimit { get; set; }

                [NameInMap("HighWatermark")]
                [Validation(Required=false)]
                public int? HighWatermark { get; set; }

                [NameInMap("IgnoreDelete")]
                [Validation(Required=false)]
                public bool? IgnoreDelete { get; set; }

                [NameInMap("InPlace")]
                [Validation(Required=false)]
                public bool? InPlace { get; set; }

                [NameInMap("InRate")]
                [Validation(Required=false)]
                public long? InRate { get; set; }

                [NameInMap("IndexId")]
                [Validation(Required=false)]
                public string IndexId { get; set; }

                [NameInMap("KmsRotatePeriod")]
                [Validation(Required=false)]
                public string KmsRotatePeriod { get; set; }

                [NameInMap("LagPeriod")]
                [Validation(Required=false)]
                public long? LagPeriod { get; set; }

                [NameInMap("LocalPath")]
                [Validation(Required=false)]
                public string LocalPath { get; set; }

                [NameInMap("LowWatermark")]
                [Validation(Required=false)]
                public int? LowWatermark { get; set; }

                [NameInMap("MnsHealth")]
                [Validation(Required=false)]
                public string MnsHealth { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NfsV4Optimization")]
                [Validation(Required=false)]
                public bool? NfsV4Optimization { get; set; }

                [NameInMap("NoPartition")]
                [Validation(Required=false)]
                public bool? NoPartition { get; set; }

                [NameInMap("ObsoleteBuckets")]
                [Validation(Required=false)]
                public string ObsoleteBuckets { get; set; }

                [NameInMap("OssBucketName")]
                [Validation(Required=false)]
                public string OssBucketName { get; set; }

                [NameInMap("OssBucketSsl")]
                [Validation(Required=false)]
                public bool? OssBucketSsl { get; set; }

                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                [NameInMap("OssHealth")]
                [Validation(Required=false)]
                public string OssHealth { get; set; }

                [NameInMap("OssUsed")]
                [Validation(Required=false)]
                public long? OssUsed { get; set; }

                [NameInMap("OutRate")]
                [Validation(Required=false)]
                public long? OutRate { get; set; }

                [NameInMap("PartialSyncPaths")]
                [Validation(Required=false)]
                public string PartialSyncPaths { get; set; }

                /// <summary>
                /// OSS Prefix。
                /// </summary>
                [NameInMap("PathPrefix")]
                [Validation(Required=false)]
                public string PathPrefix { get; set; }

                [NameInMap("PollingInterval")]
                [Validation(Required=false)]
                public int? PollingInterval { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("RemainingMetaSpace")]
                [Validation(Required=false)]
                public long? RemainingMetaSpace { get; set; }

                [NameInMap("RemoteSync")]
                [Validation(Required=false)]
                public bool? RemoteSync { get; set; }

                [NameInMap("RemoteSyncDownload")]
                [Validation(Required=false)]
                public bool? RemoteSyncDownload { get; set; }

                [NameInMap("RoClientList")]
                [Validation(Required=false)]
                public string RoClientList { get; set; }

                [NameInMap("RoUserList")]
                [Validation(Required=false)]
                public string RoUserList { get; set; }

                [NameInMap("RwClientList")]
                [Validation(Required=false)]
                public string RwClientList { get; set; }

                [NameInMap("RwUserList")]
                [Validation(Required=false)]
                public string RwUserList { get; set; }

                [NameInMap("ServerSideAlgorithm")]
                [Validation(Required=false)]
                public string ServerSideAlgorithm { get; set; }

                [NameInMap("ServerSideCmk")]
                [Validation(Required=false)]
                public string ServerSideCmk { get; set; }

                [NameInMap("ServerSideEncryption")]
                [Validation(Required=false)]
                public bool? ServerSideEncryption { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("Squash")]
                [Validation(Required=false)]
                public string Squash { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SupportArchive")]
                [Validation(Required=false)]
                public bool? SupportArchive { get; set; }

                [NameInMap("SyncProgress")]
                [Validation(Required=false)]
                public int? SyncProgress { get; set; }

                [NameInMap("Throttling")]
                [Validation(Required=false)]
                public bool? Throttling { get; set; }

                [NameInMap("TotalDownload")]
                [Validation(Required=false)]
                public long? TotalDownload { get; set; }

                [NameInMap("TotalUpload")]
                [Validation(Required=false)]
                public long? TotalUpload { get; set; }

                [NameInMap("TransferAcceleration")]
                [Validation(Required=false)]
                public bool? TransferAcceleration { get; set; }

                [NameInMap("UploadQueue")]
                [Validation(Required=false)]
                public long? UploadQueue { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

                [NameInMap("WindowsAcl")]
                [Validation(Required=false)]
                public bool? WindowsAcl { get; set; }

            }

        }

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
