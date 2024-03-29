// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateProcCorrectOrderRequest : TeaModel {
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateProcCorrectOrderRequestParam Param { get; set; }
        public class CreateProcCorrectOrderRequestParam : TeaModel {
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateProcCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateProcCorrectOrderRequestParamDbItemList : TeaModel {
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

            }

            [NameInMap("ExecMode")]
            [Validation(Required=false)]
            public string ExecMode { get; set; }

            [NameInMap("ExecSQL")]
            [Validation(Required=false)]
            public string ExecSQL { get; set; }

            [NameInMap("RollbackAttachmentName")]
            [Validation(Required=false)]
            public string RollbackAttachmentName { get; set; }

            [NameInMap("RollbackSQL")]
            [Validation(Required=false)]
            public string RollbackSQL { get; set; }

            [NameInMap("RollbackSqlType")]
            [Validation(Required=false)]
            public string RollbackSqlType { get; set; }

        }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
