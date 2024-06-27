// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryDataServiceListResponseBodyResult Result { get; set; }
        public class QueryDataServiceListResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryDataServiceListResponseBodyResultData> Data { get; set; }
            public class QueryDataServiceListResponseBodyResultData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public QueryDataServiceListResponseBodyResultDataContent Content { get; set; }
                public class QueryDataServiceListResponseBodyResultDataContent : TeaModel {
                    [NameInMap("CubeId")]
                    [Validation(Required=false)]
                    public string CubeId { get; set; }

                    [NameInMap("CubeName")]
                    [Validation(Required=false)]
                    public string CubeName { get; set; }

                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public bool? Detail { get; set; }

                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public QueryDataServiceListResponseBodyResultDataContentFilter Filter { get; set; }
                    public class QueryDataServiceListResponseBodyResultDataContentFilter : TeaModel {
                        [NameInMap("Filters")]
                        [Validation(Required=false)]
                        public List<Dictionary<string, object>> Filters { get; set; }

                        [NameInMap("LogicalOperator")]
                        [Validation(Required=false)]
                        public string LogicalOperator { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    [NameInMap("ReturnFields")]
                    [Validation(Required=false)]
                    public List<QueryDataServiceListResponseBodyResultDataContentReturnFields> ReturnFields { get; set; }
                    public class QueryDataServiceListResponseBodyResultDataContentReturnFields : TeaModel {
                        [NameInMap("Aggregator")]
                        [Validation(Required=false)]
                        public string Aggregator { get; set; }

                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        [NameInMap("Desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        [NameInMap("Field")]
                        [Validation(Required=false)]
                        public QueryDataServiceListResponseBodyResultDataContentReturnFieldsField Field { get; set; }
                        public class QueryDataServiceListResponseBodyResultDataContentReturnFieldsField : TeaModel {
                            [NameInMap("Caption")]
                            [Validation(Required=false)]
                            public string Caption { get; set; }

                            [NameInMap("Column")]
                            [Validation(Required=false)]
                            public string Column { get; set; }

                            [NameInMap("DataType")]
                            [Validation(Required=false)]
                            public string DataType { get; set; }

                            [NameInMap("Fid")]
                            [Validation(Required=false)]
                            public string Fid { get; set; }

                            [NameInMap("Granularity")]
                            [Validation(Required=false)]
                            public string Granularity { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("Orderby")]
                        [Validation(Required=false)]
                        public string Orderby { get; set; }

                    }

                }

                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("CreatorName")]
                [Validation(Required=false)]
                public string CreatorName { get; set; }

                [NameInMap("CubeId")]
                [Validation(Required=false)]
                public string CubeId { get; set; }

                [NameInMap("CubeName")]
                [Validation(Required=false)]
                public string CubeName { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public string ModifierId { get; set; }

                [NameInMap("ModifierName")]
                [Validation(Required=false)]
                public string ModifierName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                [NameInMap("OwnerName")]
                [Validation(Required=false)]
                public string OwnerName { get; set; }

                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
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

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
