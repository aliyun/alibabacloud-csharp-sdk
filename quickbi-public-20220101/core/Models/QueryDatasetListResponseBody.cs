// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetListResponseBodyResult Result { get; set; }
        public class QueryDatasetListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryDatasetListResponseBodyResultData> Data { get; set; }
            public class QueryDatasetListResponseBodyResultData : TeaModel {
                public string CreateTime { get; set; }
                public QueryDatasetListResponseBodyResultDataDataSource DataSource { get; set; }
                public class QueryDatasetListResponseBodyResultDataDataSource : TeaModel {
                    [NameInMap("DsId")]
                    [Validation(Required=false)]
                    public string DsId { get; set; }

                    [NameInMap("DsName")]
                    [Validation(Required=false)]
                    public string DsName { get; set; }

                    [NameInMap("DsType")]
                    [Validation(Required=false)]
                    public string DsType { get; set; }

                }
                public string DatasetId { get; set; }
                public string DatasetName { get; set; }
                public string Description { get; set; }
                public QueryDatasetListResponseBodyResultDataDirectory Directory { get; set; }
                public class QueryDatasetListResponseBodyResultDataDirectory : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("PathId")]
                    [Validation(Required=false)]
                    public string PathId { get; set; }

                    [NameInMap("PathName")]
                    [Validation(Required=false)]
                    public string PathName { get; set; }

                }
                public string ModifyTime { get; set; }
                public string OwnerId { get; set; }
                public string OwnerName { get; set; }
                public bool? RowLevel { get; set; }
                public string WorkspaceId { get; set; }
                public string WorkspaceName { get; set; }
            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public int? TotalNum { get; set; }
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
