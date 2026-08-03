// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class OperateAvatarProjectRequest : TeaModel {
        [NameInMap("operateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("resChannelNumber")]
        [Validation(Required=false)]
        public int? ResChannelNumber { get; set; }

        [NameInMap("resType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

    }

}
