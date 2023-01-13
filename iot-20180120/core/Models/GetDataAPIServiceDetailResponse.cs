// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDataAPIServiceDetailResponse : TeaModel {
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
        public GetDataAPIServiceDetailResponseData Data { get; set; }
        public class GetDataAPIServiceDetailResponseData : TeaModel {
            [NameInMap("ApiPath")]
            [Validation(Required=true)]
            public string ApiPath { get; set; }

            [NameInMap("ApiSrn")]
            [Validation(Required=true)]
            public string ApiSrn { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public long? CreateTime { get; set; }

            [NameInMap("DateFormat")]
            [Validation(Required=true)]
            public string DateFormat { get; set; }

            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=true)]
            public string DisplayName { get; set; }

            [NameInMap("LastUpdateTime")]
            [Validation(Required=true)]
            public long? LastUpdateTime { get; set; }

            [NameInMap("RequestMethod")]
            [Validation(Required=true)]
            public string RequestMethod { get; set; }

            [NameInMap("RequestProtocol")]
            [Validation(Required=true)]
            public string RequestProtocol { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }

            [NameInMap("SqlTemplateDTO")]
            [Validation(Required=true)]
            public GetDataAPIServiceDetailResponseDataSqlTemplateDTO SqlTemplateDTO { get; set; }
            public class GetDataAPIServiceDetailResponseDataSqlTemplateDTO : TeaModel {
                [NameInMap("OriginSql")]
                [Validation(Required=true)]
                public string OriginSql { get; set; }

                [NameInMap("TemplateSql")]
                [Validation(Required=true)]
                public string TemplateSql { get; set; }

                [NameInMap("RequestParams")]
                [Validation(Required=true)]
                public GetDataAPIServiceDetailResponseDataSqlTemplateDTORequestParams RequestParams { get; set; }
                public class GetDataAPIServiceDetailResponseDataSqlTemplateDTORequestParams : TeaModel {
                    [NameInMap("RequestParams")]
                    [Validation(Required=true)]
                    public List<GetDataAPIServiceDetailResponseDataSqlTemplateDTORequestParamsRequestParams> RequestParams { get; set; }
                    public class GetDataAPIServiceDetailResponseDataSqlTemplateDTORequestParamsRequestParams : TeaModel {
                        [NameInMap("Desc")]
                        [Validation(Required=true)]
                        public string Desc { get; set; }

                        [NameInMap("Example")]
                        [Validation(Required=true)]
                        public string Example { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=true)]
                        public string Name { get; set; }

                        [NameInMap("Required")]
                        [Validation(Required=true)]
                        public bool? Required { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=true)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("ResponseParams")]
                [Validation(Required=true)]
                public GetDataAPIServiceDetailResponseDataSqlTemplateDTOResponseParams ResponseParams { get; set; }
                public class GetDataAPIServiceDetailResponseDataSqlTemplateDTOResponseParams : TeaModel {
                    [NameInMap("ResponseParams")]
                    [Validation(Required=true)]
                    public List<GetDataAPIServiceDetailResponseDataSqlTemplateDTOResponseParamsResponseParams> ResponseParams { get; set; }
                    public class GetDataAPIServiceDetailResponseDataSqlTemplateDTOResponseParamsResponseParams : TeaModel {
                        [NameInMap("Desc")]
                        [Validation(Required=true)]
                        public string Desc { get; set; }

                        [NameInMap("Example")]
                        [Validation(Required=true)]
                        public string Example { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=true)]
                        public string Name { get; set; }

                        [NameInMap("Required")]
                        [Validation(Required=true)]
                        public bool? Required { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=true)]
                        public string Type { get; set; }

                    }

                }

            }

        }

    }

}
