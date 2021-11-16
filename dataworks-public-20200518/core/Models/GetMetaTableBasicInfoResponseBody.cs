// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetMetaTableBasicInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMetaTableBasicInfoResponseBodyData Data { get; set; }
        public class GetMetaTableBasicInfoResponseBodyData : TeaModel {
            [NameInMap("Caption")]
            [Validation(Required=false)]
            public string Caption { get; set; }
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }
            [NameInMap("ColumnCount")]
            [Validation(Required=false)]
            public int? ColumnCount { get; set; }
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public int? EnvType { get; set; }
            [NameInMap("FavoriteCount")]
            [Validation(Required=false)]
            public long? FavoriteCount { get; set; }
            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }
            [NameInMap("IsView")]
            [Validation(Required=false)]
            public bool? IsView { get; set; }
            [NameInMap("IsVisible")]
            [Validation(Required=false)]
            public int? IsVisible { get; set; }
            [NameInMap("LastAccessTime")]
            [Validation(Required=false)]
            public long? LastAccessTime { get; set; }
            [NameInMap("LastDdlTime")]
            [Validation(Required=false)]
            public long? LastDdlTime { get; set; }
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public long? LastModifyTime { get; set; }
            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public int? LifeCycle { get; set; }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("PartitionKeys")]
            [Validation(Required=false)]
            public string PartitionKeys { get; set; }
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public long? ReadCount { get; set; }
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }
            [NameInMap("ViewCount")]
            [Validation(Required=false)]
            public long? ViewCount { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
