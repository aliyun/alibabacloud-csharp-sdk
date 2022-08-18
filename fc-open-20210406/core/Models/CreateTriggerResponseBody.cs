// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateTriggerResponseBody : TeaModel {
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("invocationRole")]
        [Validation(Required=false)]
        public string InvocationRole { get; set; }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("sourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

        [NameInMap("triggerConfig")]
        [Validation(Required=false)]
        public string TriggerConfig { get; set; }

        [NameInMap("triggerId")]
        [Validation(Required=false)]
        public string TriggerId { get; set; }

        [NameInMap("triggerName")]
        [Validation(Required=false)]
        public string TriggerName { get; set; }

        [NameInMap("triggerType")]
        [Validation(Required=false)]
        public string TriggerType { get; set; }

        [NameInMap("urlInternet")]
        [Validation(Required=false)]
        public string UrlInternet { get; set; }

        [NameInMap("urlIntranet")]
        [Validation(Required=false)]
        public string UrlIntranet { get; set; }

    }

}
