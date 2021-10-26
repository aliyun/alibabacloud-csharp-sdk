// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SynchronizeGroupConfigRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("ConflictSyncPolicy")]
        [Validation(Required=false)]
        public string ConflictSyncPolicy { get; set; }

        [NameInMap("NewSyncPolicy")]
        [Validation(Required=false)]
        public string NewSyncPolicy { get; set; }

        [NameInMap("BackendSyncPolicy")]
        [Validation(Required=false)]
        public string BackendSyncPolicy { get; set; }

        [NameInMap("ConflictInclude")]
        [Validation(Required=false)]
        public List<string> ConflictInclude { get; set; }

        [NameInMap("ConflictExclude")]
        [Validation(Required=false)]
        public List<string> ConflictExclude { get; set; }

        [NameInMap("NewInclude")]
        [Validation(Required=false)]
        public List<string> NewInclude { get; set; }

        [NameInMap("NewExclude")]
        [Validation(Required=false)]
        public List<string> NewExclude { get; set; }

        [NameInMap("BackendInclude")]
        [Validation(Required=false)]
        public List<string> BackendInclude { get; set; }

        [NameInMap("BackendExclude")]
        [Validation(Required=false)]
        public List<string> BackendExclude { get; set; }

    }

}
