// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class ReAddMigrationTaskInPlanResponseBody : TeaModel {
        [NameInMap("FailModels")]
        [Validation(Required=false)]
        public ReAddMigrationTaskInPlanResponseBodyFailModels FailModels { get; set; }
        public class ReAddMigrationTaskInPlanResponseBodyFailModels : TeaModel {
            [NameInMap("FailModels")]
            [Validation(Required=false)]
            public List<ReAddMigrationTaskInPlanResponseBodyFailModelsFailModels> FailModels { get; set; }
            public class ReAddMigrationTaskInPlanResponseBodyFailModelsFailModels : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
