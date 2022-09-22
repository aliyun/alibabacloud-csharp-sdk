// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class CreateMigrationPlanResponseBody : TeaModel {
        [NameInMap("InstancesFailModels")]
        [Validation(Required=false)]
        public CreateMigrationPlanResponseBodyInstancesFailModels InstancesFailModels { get; set; }
        public class CreateMigrationPlanResponseBodyInstancesFailModels : TeaModel {
            [NameInMap("InstancesFailModel")]
            [Validation(Required=false)]
            public List<CreateMigrationPlanResponseBodyInstancesFailModelsInstancesFailModel> InstancesFailModel { get; set; }
            public class CreateMigrationPlanResponseBodyInstancesFailModelsInstancesFailModel : TeaModel {
                [NameInMap("FailModels")]
                [Validation(Required=false)]
                public CreateMigrationPlanResponseBodyInstancesFailModelsInstancesFailModelFailModels FailModels { get; set; }
                public class CreateMigrationPlanResponseBodyInstancesFailModelsInstancesFailModelFailModels : TeaModel {
                    [NameInMap("FailModel")]
                    [Validation(Required=false)]
                    public List<CreateMigrationPlanResponseBodyInstancesFailModelsInstancesFailModelFailModelsFailModel> FailModel { get; set; }
                    public class CreateMigrationPlanResponseBodyInstancesFailModelsInstancesFailModelFailModelsFailModel : TeaModel {
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

        [NameInMap("MigrationPlanId")]
        [Validation(Required=false)]
        public string MigrationPlanId { get; set; }

        [NameInMap("PlanFailModels")]
        [Validation(Required=false)]
        public CreateMigrationPlanResponseBodyPlanFailModels PlanFailModels { get; set; }
        public class CreateMigrationPlanResponseBodyPlanFailModels : TeaModel {
            [NameInMap("PlanFailModel")]
            [Validation(Required=false)]
            public List<CreateMigrationPlanResponseBodyPlanFailModelsPlanFailModel> PlanFailModel { get; set; }
            public class CreateMigrationPlanResponseBodyPlanFailModelsPlanFailModel : TeaModel {
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

        [NameInMap("SgFailModels")]
        [Validation(Required=false)]
        public CreateMigrationPlanResponseBodySgFailModels SgFailModels { get; set; }
        public class CreateMigrationPlanResponseBodySgFailModels : TeaModel {
            [NameInMap("SgFailModel")]
            [Validation(Required=false)]
            public List<CreateMigrationPlanResponseBodySgFailModelsSgFailModel> SgFailModel { get; set; }
            public class CreateMigrationPlanResponseBodySgFailModelsSgFailModel : TeaModel {
                [NameInMap("FailModels")]
                [Validation(Required=false)]
                public CreateMigrationPlanResponseBodySgFailModelsSgFailModelFailModels FailModels { get; set; }
                public class CreateMigrationPlanResponseBodySgFailModelsSgFailModelFailModels : TeaModel {
                    [NameInMap("FailModel")]
                    [Validation(Required=false)]
                    public List<CreateMigrationPlanResponseBodySgFailModelsSgFailModelFailModelsFailModel> FailModel { get; set; }
                    public class CreateMigrationPlanResponseBodySgFailModelsSgFailModelFailModelsFailModel : TeaModel {
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorMessage")]
                        [Validation(Required=false)]
                        public string ErrorMessage { get; set; }

                    }

                }

                [NameInMap("GroupNo")]
                [Validation(Required=false)]
                public string GroupNo { get; set; }

            }

        }

    }

}
