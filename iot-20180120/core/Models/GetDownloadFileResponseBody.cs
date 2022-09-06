// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDownloadFileResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDownloadFileResponseBodyData Data { get; set; }
        public class GetDownloadFileResponseBodyData : TeaModel {
            [NameInMap("AsyncExecute")]
            [Validation(Required=false)]
            public bool? AsyncExecute { get; set; }

            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            [NameInMap("CsvFileName")]
            [Validation(Required=false)]
            public string CsvFileName { get; set; }

            [NameInMap("CsvUrl")]
            [Validation(Required=false)]
            public string CsvUrl { get; set; }

            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("Header")]
            [Validation(Required=false)]
            public List<GetDownloadFileResponseBodyDataHeader> Header { get; set; }
            public class GetDownloadFileResponseBodyDataHeader : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("DimDateClass")]
                [Validation(Required=false)]
                public string DimDateClass { get; set; }

                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("FieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("GeoClass")]
                [Validation(Required=false)]
                public string GeoClass { get; set; }

                [NameInMap("TimeClass")]
                [Validation(Required=false)]
                public string TimeClass { get; set; }

                [NameInMap("TypeClass")]
                [Validation(Required=false)]
                public string TypeClass { get; set; }

            }

            [NameInMap("LongJobId")]
            [Validation(Required=false)]
            public string LongJobId { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("PreviewSize")]
            [Validation(Required=false)]
            public int? PreviewSize { get; set; }

            [NameInMap("QuerySetting")]
            [Validation(Required=false)]
            public GetDownloadFileResponseBodyDataQuerySetting QuerySetting { get; set; }
            public class GetDownloadFileResponseBodyDataQuerySetting : TeaModel {
                [NameInMap("AstExpr")]
                [Validation(Required=false)]
                public List<GetDownloadFileResponseBodyDataQuerySettingAstExpr> AstExpr { get; set; }
                public class GetDownloadFileResponseBodyDataQuerySettingAstExpr : TeaModel {
                    [NameInMap("Expr")]
                    [Validation(Required=false)]
                    public string Expr { get; set; }

                    [NameInMap("ExprType")]
                    [Validation(Required=false)]
                    public string ExprType { get; set; }

                }

                [NameInMap("SelectedHeaders")]
                [Validation(Required=false)]
                public List<GetDownloadFileResponseBodyDataQuerySettingSelectedHeaders> SelectedHeaders { get; set; }
                public class GetDownloadFileResponseBodyDataQuerySettingSelectedHeaders : TeaModel {
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    [NameInMap("DimDateClass")]
                    [Validation(Required=false)]
                    public string DimDateClass { get; set; }

                    [NameInMap("FieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    [NameInMap("FieldType")]
                    [Validation(Required=false)]
                    public string FieldType { get; set; }

                    [NameInMap("GeoClass")]
                    [Validation(Required=false)]
                    public string GeoClass { get; set; }

                    [NameInMap("TimeClass")]
                    [Validation(Required=false)]
                    public string TimeClass { get; set; }

                }

            }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Result { get; set; }

            [NameInMap("ResultDataInString")]
            [Validation(Required=false)]
            public string ResultDataInString { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
