// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetWhatsappHealthStatusResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWhatsappHealthStatusResponseBodyData Data { get; set; }
        public class GetWhatsappHealthStatusResponseBodyData : TeaModel {
            [NameInMap("CanSendMessage")]
            [Validation(Required=false)]
            public string CanSendMessage { get; set; }

            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<GetWhatsappHealthStatusResponseBodyDataEntities> Entities { get; set; }
            public class GetWhatsappHealthStatusResponseBodyDataEntities : TeaModel {
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                [NameInMap("CanSendMessage")]
                [Validation(Required=false)]
                public string CanSendMessage { get; set; }

                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("Errors")]
                [Validation(Required=false)]
                public List<GetWhatsappHealthStatusResponseBodyDataEntitiesErrors> Errors { get; set; }
                public class GetWhatsappHealthStatusResponseBodyDataEntitiesErrors : TeaModel {
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorDescription")]
                    [Validation(Required=false)]
                    public string ErrorDescription { get; set; }

                    [NameInMap("PossibleSolution")]
                    [Validation(Required=false)]
                    public string PossibleSolution { get; set; }

                }

                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

                [NameInMap("WabaId")]
                [Validation(Required=false)]
                public string WabaId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
