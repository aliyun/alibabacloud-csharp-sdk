// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateAttributesInput : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("httpTriggerConfig")]
        [Validation(Required=false)]
        public HTTPTriggerConfig HttpTriggerConfig { get; set; }

        [NameInMap("versionID")]
        [Validation(Required=false)]
        public string VersionID { get; set; }

    }

}
