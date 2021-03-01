// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("StructSyncOrderDetail")]
        [Validation(Required=false)]
        public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetail StructSyncOrderDetail { get; set; }
        public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetail : TeaModel {
            [NameInMap("SourceDatabaseInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceDatabaseInfo SourceDatabaseInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceDatabaseInfo : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }
            [NameInMap("TargetDatabaseInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetDatabaseInfo TargetDatabaseInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetDatabaseInfo : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }
            [NameInMap("SourceVersionInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceVersionInfo SourceVersionInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailSourceVersionInfo : TeaModel {
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }
            [NameInMap("TargetVersionInfo")]
            [Validation(Required=false)]
            public GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetVersionInfo TargetVersionInfo { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTargetVersionInfo : TeaModel {
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

            }
            [NameInMap("TableInfoList")]
            [Validation(Required=false)]
            public List<GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTableInfoList> TableInfoList { get; set; }
            public class GetStructSyncOrderDetailResponseBodyStructSyncOrderDetailTableInfoList : TeaModel {
                public string SourceTableName { get; set; }
                public string TargetTableName { get; set; }
            }
            [NameInMap("IgnoreError")]
            [Validation(Required=false)]
            public bool? IgnoreError { get; set; }
        };

    }

}
