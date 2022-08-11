// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DeleteClusterRequest : TeaModel {
        [NameInMap("keep_slb")]
        [Validation(Required=false)]
        public bool? KeepSlb { get; set; }

        [NameInMap("retain_all_resources")]
        [Validation(Required=false)]
        public bool? RetainAllResources { get; set; }

        [NameInMap("retain_resources")]
        [Validation(Required=false)]
        public List<string> RetainResources { get; set; }

    }

}
