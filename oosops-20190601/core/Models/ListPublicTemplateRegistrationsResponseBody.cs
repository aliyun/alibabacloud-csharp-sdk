// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ListPublicTemplateRegistrationsResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Registrations")]
        [Validation(Required=false)]
        public List<ListPublicTemplateRegistrationsResponseBodyRegistrations> Registrations { get; set; }
        public class ListPublicTemplateRegistrationsResponseBodyRegistrations : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("RegistrationId")]
            [Validation(Required=false)]
            public string RegistrationId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
