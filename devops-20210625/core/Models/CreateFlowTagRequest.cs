/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateFlowTagRequest : TeaModel {
        [NameInMap("color")]
        [Validation(Required=false)]
        public string Color { get; set; }

        [NameInMap("flowTagGroupId")]
        [Validation(Required=false)]
        public long? FlowTagGroupId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
