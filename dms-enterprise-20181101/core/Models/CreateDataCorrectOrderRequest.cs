// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCorrectOrderRequest : TeaModel {
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataCorrectOrderRequestParam Param { get; set; }
        public class CreateDataCorrectOrderRequestParam : TeaModel {
            [NameInMap("AttachmentName")]
            [Validation(Required=false)]
            public string AttachmentName { get; set; }
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }
            [NameInMap("DbItemList")]
            [Validation(Required=false)]
            public List<CreateDataCorrectOrderRequestParamDbItemList> DbItemList { get; set; }
            public class CreateDataCorrectOrderRequestParamDbItemList : TeaModel {
                public long? DbId { get; set; }
                public bool? Logic { get; set; }
            }
            [NameInMap("EstimateAffectRows")]
            [Validation(Required=false)]
            public long? EstimateAffectRows { get; set; }
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
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
