// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class GetMonitoringTemplateResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public GetMonitoringTemplateResponseBodyResource Resource { get; set; }
        public class GetMonitoringTemplateResponseBodyResource : TeaModel {
            [NameInMap("AlertTemplatesJson")]
            [Validation(Required=false)]
            public string AlertTemplatesJson { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("HostAvailabilityTemplate")]
            [Validation(Required=false)]
            public string HostAvailabilityTemplate { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("ProcessMonitorTemplates")]
            [Validation(Required=false)]
            public string ProcessMonitorTemplates { get; set; }

            [NameInMap("RestVersion")]
            [Validation(Required=false)]
            public string RestVersion { get; set; }

            [NameInMap("SystemEventTemplates")]
            [Validation(Required=false)]
            public string SystemEventTemplates { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
