// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeBackupDataListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupDataListResponseBodyData Data { get; set; }
        public class DescribeBackupDataListResponseBodyData : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeBackupDataListResponseBodyDataContent> Content { get; set; }
            public class DescribeBackupDataListResponseBodyDataContent : TeaModel {
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                [NameInMap("BackupLocation")]
                [Validation(Required=false)]
                public string BackupLocation { get; set; }

                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                [NameInMap("BackupScale")]
                [Validation(Required=false)]
                public string BackupScale { get; set; }

                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("Checksum")]
                [Validation(Required=false)]
                public string Checksum { get; set; }

                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public long? ConsistentTime { get; set; }

                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ExpectExpireTime")]
                [Validation(Required=false)]
                public string ExpectExpireTime { get; set; }

                [NameInMap("ExpectExpireType")]
                [Validation(Required=false)]
                public string ExpectExpireType { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public int? IsAvail { get; set; }

                [NameInMap("PolarSnapshot")]
                [Validation(Required=false)]
                public DescribeBackupDataListResponseBodyDataContentPolarSnapshot PolarSnapshot { get; set; }
                public class DescribeBackupDataListResponseBodyDataContentPolarSnapshot : TeaModel {
                    [NameInMap("DumpId")]
                    [Validation(Required=false)]
                    public long? DumpId { get; set; }

                    [NameInMap("DumpSize")]
                    [Validation(Required=false)]
                    public long? DumpSize { get; set; }

                    [NameInMap("ExpectExpireTime")]
                    [Validation(Required=false)]
                    public string ExpectExpireTime { get; set; }

                    [NameInMap("expectExpireType")]
                    [Validation(Required=false)]
                    public string ExpectExpireType { get; set; }

                }

                [NameInMap("SupportDeletion")]
                [Validation(Required=false)]
                public int? SupportDeletion { get; set; }

            }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
