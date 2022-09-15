// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class RegisterDefaultPatchBaselineResponseBody : TeaModel {
        [NameInMap("PatchBaseline")]
        [Validation(Required=false)]
        public RegisterDefaultPatchBaselineResponseBodyPatchBaseline PatchBaseline { get; set; }
        public class RegisterDefaultPatchBaselineResponseBodyPatchBaseline : TeaModel {
            [NameInMap("ApprovalRules")]
            [Validation(Required=false)]
            public string ApprovalRules { get; set; }

            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OperationSystem")]
            [Validation(Required=false)]
            public string OperationSystem { get; set; }

            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
