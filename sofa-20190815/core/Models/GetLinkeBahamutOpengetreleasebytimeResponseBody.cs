// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutOpengetreleasebytimeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetLinkeBahamutOpengetreleasebytimeResponseBodyResult> Result { get; set; }
        public class GetLinkeBahamutOpengetreleasebytimeResponseBodyResult : TeaModel {
            [NameInMap("Attachable")]
            [Validation(Required=false)]
            public bool? Attachable { get; set; }

            [NameInMap("BetaRelease")]
            [Validation(Required=false)]
            public bool? BetaRelease { get; set; }

            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ReleaseDate")]
            [Validation(Required=false)]
            public long? ReleaseDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            [NameInMap("Ticket")]
            [Validation(Required=false)]
            public string Ticket { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Managers")]
            [Validation(Required=false)]
            public List<string> Managers { get; set; }

        }

    }

}
