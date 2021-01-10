// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ExecLinkeLinklogKnowledgefeedbackRequest : TeaModel {
        [NameInMap("KnowledgeFeedbackVOJsonStr")]
        [Validation(Required=false)]
        public string KnowledgeFeedbackVOJsonStr { get; set; }

        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        [NameInMap("LogId")]
        [Validation(Required=false)]
        public string LogId { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
