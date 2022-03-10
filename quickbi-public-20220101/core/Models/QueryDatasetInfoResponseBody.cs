// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDatasetInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDatasetInfoResponseBodyResult Result { get; set; }
        public class QueryDatasetInfoResponseBodyResult : TeaModel {
            [NameInMap("CubeTableList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultCubeTableList> CubeTableList { get; set; }
            public class QueryDatasetInfoResponseBodyResultCubeTableList : TeaModel {
                public string Caption { get; set; }
                public bool? Customsql { get; set; }
                public string DatasourceId { get; set; }
                public string DsType { get; set; }
                public bool? FactTable { get; set; }
                public string Sql { get; set; }
                public string TableName { get; set; }
                public string UniqueId { get; set; }
            }
            [NameInMap("CustimzeSql")]
            [Validation(Required=false)]
            public bool? CustimzeSql { get; set; }
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }
            [NameInMap("DatasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }
            [NameInMap("DimensionList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultDimensionList> DimensionList { get; set; }
            public class QueryDatasetInfoResponseBodyResultDimensionList : TeaModel {
                public string Caption { get; set; }
                public string DataType { get; set; }
                public string DimensionType { get; set; }
                public string Expression { get; set; }
                public string FactColumn { get; set; }
                public string Granularity { get; set; }
                public string RefUid { get; set; }
                public string TableUniqueId { get; set; }
                public string Uid { get; set; }
            }
            [NameInMap("Directory")]
            [Validation(Required=false)]
            public QueryDatasetInfoResponseBodyResultDirectory Directory { get; set; }
            public class QueryDatasetInfoResponseBodyResultDirectory : TeaModel {
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
            [NameInMap("DsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }
            [NameInMap("DsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }
            [NameInMap("DsType")]
            [Validation(Required=false)]
            public string DsType { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public string GmtModify { get; set; }
            [NameInMap("MeasureList")]
            [Validation(Required=false)]
            public List<QueryDatasetInfoResponseBodyResultMeasureList> MeasureList { get; set; }
            public class QueryDatasetInfoResponseBodyResultMeasureList : TeaModel {
                public string Caption { get; set; }
                public string DataType { get; set; }
                public string Expression { get; set; }
                public string FactColumn { get; set; }
                public string MeasureType { get; set; }
                public string TableUniqueId { get; set; }
                public string Uid { get; set; }
            }
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }
            [NameInMap("RowLevel")]
            [Validation(Required=false)]
            public bool? RowLevel { get; set; }
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
