// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateSQLReviewOrderRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateSQLReviewOrderRequestParam Param { get; set; }
        public class CreateSQLReviewOrderRequestParam : TeaModel {
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }
            [NameInMap("AttachmentKeyList")]
            [Validation(Required=false)]
            public List<string> AttachmentKeyList { get; set; }
        };

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
