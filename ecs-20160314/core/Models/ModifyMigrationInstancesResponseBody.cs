// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class ModifyMigrationInstancesResponseBody : TeaModel {
        [NameInMap("InstancesFailModels")]
        [Validation(Required=false)]
        public ModifyMigrationInstancesResponseBodyInstancesFailModels InstancesFailModels { get; set; }
        public class ModifyMigrationInstancesResponseBodyInstancesFailModels : TeaModel {
            [NameInMap("InstancesFailModel")]
            [Validation(Required=false)]
            public List<ModifyMigrationInstancesResponseBodyInstancesFailModelsInstancesFailModel> InstancesFailModel { get; set; }
            public class ModifyMigrationInstancesResponseBodyInstancesFailModelsInstancesFailModel : TeaModel {
                [NameInMap("FailModels")]
                [Validation(Required=false)]
                public ModifyMigrationInstancesResponseBodyInstancesFailModelsInstancesFailModelFailModels FailModels { get; set; }
                public class ModifyMigrationInstancesResponseBodyInstancesFailModelsInstancesFailModelFailModels : TeaModel {
                    [NameInMap("FailModel")]
                    [Validation(Required=false)]
                    public List<ModifyMigrationInstancesResponseBodyInstancesFailModelsInstancesFailModelFailModelsFailModel> FailModel { get; set; }
                    public class ModifyMigrationInstancesResponseBodyInstancesFailModelsInstancesFailModelFailModelsFailModel : TeaModel {
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                    }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
