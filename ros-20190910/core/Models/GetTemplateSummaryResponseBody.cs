// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateSummaryResponseBody : TeaModel {
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Parameters { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        [NameInMap("ResourceIdentifierSummaries")]
        [Validation(Required=false)]
        public List<GetTemplateSummaryResponseBodyResourceIdentifierSummaries> ResourceIdentifierSummaries { get; set; }
        public class GetTemplateSummaryResponseBodyResourceIdentifierSummaries : TeaModel {
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("LogicalResourceIds")]
            [Validation(Required=false)]
            public List<string> LogicalResourceIds { get; set; }

            [NameInMap("ResourceIdentifiers")]
            [Validation(Required=false)]
            public List<string> ResourceIdentifiers { get; set; }

        }

    }

}
