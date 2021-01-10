// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinklogKnowledgepriorityRequest : TeaModel {
        [NameInMap("PriorityTypeRepeatList")]
        [Validation(Required=false)]
        public List<string> PriorityTypeRepeatList { get; set; }

        [NameInMap("SelectStoreId")]
        [Validation(Required=false)]
        public long? SelectStoreId { get; set; }

    }

}
