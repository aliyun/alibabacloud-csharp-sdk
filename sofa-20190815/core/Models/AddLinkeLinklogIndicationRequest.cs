// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeLinklogIndicationRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        [NameInMap("ConditionsRepeatList")]
        [Validation(Required=false)]
        public List<string> ConditionsRepeatList { get; set; }

    }

}
