// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSkillDetailRequest : TeaModel {
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SkillId")]
        [Validation(Required=false)]
        public string SkillId { get; set; }

        [NameInMap("SourceIdOfAssistantId")]
        [Validation(Required=false)]
        public string SourceIdOfAssistantId { get; set; }

    }

}
