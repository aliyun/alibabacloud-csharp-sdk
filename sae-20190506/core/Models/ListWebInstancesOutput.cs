// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListWebInstancesOutput : TeaModel {
        [NameInMap("CurrentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        [NameInMap("WebInstances")]
        [Validation(Required=false)]
        public List<WebInstanceInfo> WebInstances { get; set; }

        [NameInMap("WebVersionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, WebVersionStatus> WebVersionStatus { get; set; }

    }

}
