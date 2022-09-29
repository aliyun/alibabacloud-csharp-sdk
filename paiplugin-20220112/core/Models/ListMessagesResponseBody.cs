// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListMessagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMessagesResponseBodyData Data { get; set; }
        public class ListMessagesResponseBodyData : TeaModel {
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ListMessagesResponseBodyDataMessages> Messages { get; set; }
            public class ListMessagesResponseBodyDataMessages : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("OutId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("ScheduleId")]
                [Validation(Required=false)]
                public string ScheduleId { get; set; }

                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TemplateCode")]
                [Validation(Required=false)]
                public string TemplateCode { get; set; }

                [NameInMap("TemplateParams")]
                [Validation(Required=false)]
                public string TemplateParams { get; set; }

                [NameInMap("TemplateType")]
                [Validation(Required=false)]
                public int? TemplateType { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
