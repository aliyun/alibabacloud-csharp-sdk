// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class GetDataAPIServiceDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataAPIServiceDetailResponseBodyData Data { get; set; }
        public class GetDataAPIServiceDetailResponseBodyData : TeaModel {
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("ApiSrn")]
            [Validation(Required=false)]
            public string ApiSrn { get; set; }
            [NameInMap("SqlTemplateDTO")]
            [Validation(Required=false)]
            public GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTO SqlTemplateDTO { get; set; }
            public class GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTO : TeaModel {
                [NameInMap("RequestParams")]
                [Validation(Required=false)]
                public GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTORequestParams RequestParams { get; set; }
                public class GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTORequestParams : TeaModel {
                    [NameInMap("RequestParams")]
                    [Validation(Required=false)]
                    public List<GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTORequestParamsRequestParams> RequestParams { get; set; }
                    public class GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTORequestParamsRequestParams : TeaModel {
                        public string Type { get; set; }
                        public bool? Required { get; set; }
                        public string Example { get; set; }
                        public string Name { get; set; }
                        public string Desc { get; set; }
                    }
                };

                [NameInMap("OriginSql")]
                [Validation(Required=false)]
                public string OriginSql { get; set; }

                [NameInMap("ResponseParams")]
                [Validation(Required=false)]
                public GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTOResponseParams ResponseParams { get; set; }
                public class GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTOResponseParams : TeaModel {
                    [NameInMap("ResponseParams")]
                    [Validation(Required=false)]
                    public List<GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTOResponseParamsResponseParams> ResponseParams { get; set; }
                    public class GetDataAPIServiceDetailResponseBodyDataSqlTemplateDTOResponseParamsResponseParams : TeaModel {
                        public string Type { get; set; }
                        public bool? Required { get; set; }
                        public string Example { get; set; }
                        public string Name { get; set; }
                        public string Desc { get; set; }
                    }
                };

                [NameInMap("TemplateSql")]
                [Validation(Required=false)]
                public string TemplateSql { get; set; }

            }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("LastUpdateTime")]
            [Validation(Required=false)]
            public long? LastUpdateTime { get; set; }
            [NameInMap("RequestMethod")]
            [Validation(Required=false)]
            public string RequestMethod { get; set; }
            [NameInMap("DateFormat")]
            [Validation(Required=false)]
            public string DateFormat { get; set; }
            [NameInMap("RequestProtocol")]
            [Validation(Required=false)]
            public string RequestProtocol { get; set; }
            [NameInMap("ApiPath")]
            [Validation(Required=false)]
            public string ApiPath { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
