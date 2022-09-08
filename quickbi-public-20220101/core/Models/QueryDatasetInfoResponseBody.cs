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
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                [NameInMap("Customsql")]
                [Validation(Required=false)]
                public bool? Customsql { get; set; }

                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public string DatasourceId { get; set; }

                [NameInMap("DsType")]
                [Validation(Required=false)]
                public string DsType { get; set; }

                [NameInMap("FactTable")]
                [Validation(Required=false)]
                public bool? FactTable { get; set; }

                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("UniqueId")]
                [Validation(Required=false)]
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
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("DimensionType")]
                [Validation(Required=false)]
                public string DimensionType { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                [NameInMap("Granularity")]
                [Validation(Required=false)]
                public string Granularity { get; set; }

                [NameInMap("RefUid")]
                [Validation(Required=false)]
                public string RefUid { get; set; }

                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
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
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("FactColumn")]
                [Validation(Required=false)]
                public string FactColumn { get; set; }

                [NameInMap("MeasureType")]
                [Validation(Required=false)]
                public string MeasureType { get; set; }

                [NameInMap("TableUniqueId")]
                [Validation(Required=false)]
                public string TableUniqueId { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
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

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
