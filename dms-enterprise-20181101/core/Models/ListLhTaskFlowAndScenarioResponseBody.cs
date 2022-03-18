// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListLhTaskFlowAndScenarioResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RawDAGList")]
        [Validation(Required=false)]
        public ListLhTaskFlowAndScenarioResponseBodyRawDAGList RawDAGList { get; set; }
        public class ListLhTaskFlowAndScenarioResponseBodyRawDAGList : TeaModel {
            [NameInMap("dag")]
            [Validation(Required=false)]
            public List<ListLhTaskFlowAndScenarioResponseBodyRawDAGListDag> Dag { get; set; }
            public class ListLhTaskFlowAndScenarioResponseBodyRawDAGListDag : TeaModel {
                public bool? CanEdit { get; set; }
                public string CreatorId { get; set; }
                public string CreatorNickName { get; set; }
                public string DagOwnerNickName { get; set; }
                public long? DataFlowId { get; set; }
                public string DemoId { get; set; }
                public long? DeployId { get; set; }
                public long? Id { get; set; }
                public bool? IsDeleted { get; set; }
                public int? LatestInstanceStatus { get; set; }
                public int? LatestInstanceTime { get; set; }
                public long? ScenarioId { get; set; }
                public long? SpaceId { get; set; }
                public int? Status { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScenarioDAGList")]
        [Validation(Required=false)]
        public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGList ScenarioDAGList { get; set; }
        public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGList : TeaModel {
            [NameInMap("DagList")]
            [Validation(Required=false)]
            public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListDagList DagList { get; set; }
            public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListDagList : TeaModel {
                [NameInMap("dag")]
                [Validation(Required=false)]
                public List<ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListDagListDag> Dag { get; set; }
                public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListDagListDag : TeaModel {
                    [NameInMap("CanEdit")]
                    [Validation(Required=false)]
                    public bool? CanEdit { get; set; }

                    [NameInMap("CreatorId")]
                    [Validation(Required=false)]
                    public string CreatorId { get; set; }

                    [NameInMap("CreatorNickName")]
                    [Validation(Required=false)]
                    public string CreatorNickName { get; set; }

                    [NameInMap("DagOwnerNickName")]
                    [Validation(Required=false)]
                    public string DagOwnerNickName { get; set; }

                    [NameInMap("DataFlowId")]
                    [Validation(Required=false)]
                    public long? DataFlowId { get; set; }

                    [NameInMap("DemoId")]
                    [Validation(Required=false)]
                    public string DemoId { get; set; }

                    [NameInMap("DeployId")]
                    [Validation(Required=false)]
                    public long? DeployId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("IsDeleted")]
                    [Validation(Required=false)]
                    public bool? IsDeleted { get; set; }

                    [NameInMap("LatestInstanceStatus")]
                    [Validation(Required=false)]
                    public int? LatestInstanceStatus { get; set; }

                    [NameInMap("LatestInstanceTime")]
                    [Validation(Required=false)]
                    public int? LatestInstanceTime { get; set; }

                    [NameInMap("ScenarioId")]
                    [Validation(Required=false)]
                    public long? ScenarioId { get; set; }

                    [NameInMap("SpaceId")]
                    [Validation(Required=false)]
                    public long? SpaceId { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

            }
            [NameInMap("Scenario")]
            [Validation(Required=false)]
            public ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenario Scenario { get; set; }
            public class ListLhTaskFlowAndScenarioResponseBodyScenarioDAGListScenario : TeaModel {
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ScenarioName")]
                [Validation(Required=false)]
                public string ScenarioName { get; set; }

            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
