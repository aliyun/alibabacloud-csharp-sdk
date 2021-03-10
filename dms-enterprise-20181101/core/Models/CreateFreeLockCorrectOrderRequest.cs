// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateFreeLockCorrectOrderRequest : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateFreeLockCorrectOrderRequestParam Param { get; set; }
        public class CreateFreeLockCorrectOrderRequestParam : TeaModel {
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }
            [NameInMap("ExecSQL")]
            [Validation(Required=false)]
            public string ExecSQL { get; set; }
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }
            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }
            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }
            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateFreeLockCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateFreeLockCorrectOrderRequestParamDbItemList : TeaModel {
                public long? DbId { get; set; }
                public bool? Logic { get; set; }
            }
        };

        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
