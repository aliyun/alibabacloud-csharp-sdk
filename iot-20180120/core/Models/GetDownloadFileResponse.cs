// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDownloadFileResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDownloadFileResponseData Data { get; set; }
        public class GetDownloadFileResponseData : TeaModel {
            [NameInMap("AsyncExecute")]
            [Validation(Required=true)]
            public bool? AsyncExecute { get; set; }

            [NameInMap("BeginTime")]
            [Validation(Required=true)]
            public long? BeginTime { get; set; }

            [NameInMap("CsvFileName")]
            [Validation(Required=true)]
            public string CsvFileName { get; set; }

            [NameInMap("CsvUrl")]
            [Validation(Required=true)]
            public string CsvUrl { get; set; }

            [NameInMap("DatasetId")]
            [Validation(Required=true)]
            public string DatasetId { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=true)]
            public long? EndTime { get; set; }

            [NameInMap("LongJobId")]
            [Validation(Required=true)]
            public string LongJobId { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=true)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("PreviewSize")]
            [Validation(Required=true)]
            public int? PreviewSize { get; set; }

            [NameInMap("ResultDataInString")]
            [Validation(Required=true)]
            public string ResultDataInString { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long? TotalCount { get; set; }

            [NameInMap("Header")]
            [Validation(Required=true)]
            public List<GetDownloadFileResponseDataHeader> Header { get; set; }
            public class GetDownloadFileResponseDataHeader : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=true)]
                public string Alias { get; set; }

                [NameInMap("DimDateClass")]
                [Validation(Required=true)]
                public string DimDateClass { get; set; }

                [NameInMap("FieldName")]
                [Validation(Required=true)]
                public string FieldName { get; set; }

                [NameInMap("FieldType")]
                [Validation(Required=true)]
                public string FieldType { get; set; }

                [NameInMap("GeoClass")]
                [Validation(Required=true)]
                public string GeoClass { get; set; }

                [NameInMap("TimeClass")]
                [Validation(Required=true)]
                public string TimeClass { get; set; }

                [NameInMap("TypeClass")]
                [Validation(Required=true)]
                public string TypeClass { get; set; }

            }

            [NameInMap("QuerySetting")]
            [Validation(Required=true)]
            public GetDownloadFileResponseDataQuerySetting QuerySetting { get; set; }
            public class GetDownloadFileResponseDataQuerySetting : TeaModel {
                [NameInMap("AstExpr")]
                [Validation(Required=true)]
                public List<GetDownloadFileResponseDataQuerySettingAstExpr> AstExpr { get; set; }
                public class GetDownloadFileResponseDataQuerySettingAstExpr : TeaModel {
                    [NameInMap("Expr")]
                    [Validation(Required=true)]
                    public string Expr { get; set; }

                    [NameInMap("ExprType")]
                    [Validation(Required=true)]
                    public string ExprType { get; set; }

                }

                [NameInMap("SelectedHeaders")]
                [Validation(Required=true)]
                public List<GetDownloadFileResponseDataQuerySettingSelectedHeaders> SelectedHeaders { get; set; }
                public class GetDownloadFileResponseDataQuerySettingSelectedHeaders : TeaModel {
                    [NameInMap("Alias")]
                    [Validation(Required=true)]
                    public string Alias { get; set; }

                    [NameInMap("DimDateClass")]
                    [Validation(Required=true)]
                    public string DimDateClass { get; set; }

                    [NameInMap("FieldName")]
                    [Validation(Required=true)]
                    public string FieldName { get; set; }

                    [NameInMap("FieldType")]
                    [Validation(Required=true)]
                    public string FieldType { get; set; }

                    [NameInMap("GeoClass")]
                    [Validation(Required=true)]
                    public string GeoClass { get; set; }

                    [NameInMap("TimeClass")]
                    [Validation(Required=true)]
                    public string TimeClass { get; set; }

                }

            }

            [NameInMap("Result")]
            [Validation(Required=true)]
            public List<Dictionary<string, object>> Result { get; set; }

        }

    }

}
