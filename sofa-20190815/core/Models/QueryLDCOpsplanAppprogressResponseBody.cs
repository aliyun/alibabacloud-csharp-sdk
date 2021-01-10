// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLDCOpsplanAppprogressResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AppDeployProgress")]
        [Validation(Required=false)]
        public QueryLDCOpsplanAppprogressResponseBodyAppDeployProgress AppDeployProgress { get; set; }
        public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgress : TeaModel {
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("IsRollBack")]
            [Validation(Required=false)]
            public bool? IsRollBack { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("RollBackServiceId")]
            [Validation(Required=false)]
            public string RollBackServiceId { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("ComponentList")]
            [Validation(Required=false)]
            public List<string> ComponentList { get; set; }
            [NameInMap("ExecuteGroups")]
            [Validation(Required=false)]
            public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroups> ExecuteGroups { get; set; }
            public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroups : TeaModel {
                public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPostTasks> PostTasks { get; set; }
                public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPostTasks : TeaModel {
                    public string ActionCode { get; set; }
                    public bool? ConfirmSupported { get; set; }
                    public string Data { get; set; }
                    public string FinishedTime { get; set; }
                    public string Id { get; set; }
                    public bool? IgnoreSupported { get; set; }
                    public bool? RetrySupported { get; set; }
                    public string StartedTime { get; set; }
                    public string State { get; set; }
                    public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPostTasksAppDeployCells> AppDeployCells { get; set; }
                    public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPostTasksAppDeployCells : TeaModel {
                        public string CellName { get; set; }
                        public long? Partition { get; set; }
                        public long? ReleaseCount { get; set; }
                        public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPostTasksAppDeployCellsPodList> PodList { get; set; }
                        public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPostTasksAppDeployCellsPodList : TeaModel {
                            public string Cluster { get; set; }
                            public string CreatedTime { get; set; }
                            public string LifecycleStage { get; set; }
                            public string Message { get; set; }
                            public string Name { get; set; }
                            public string Namespace { get; set; }
                            public string PodIp { get; set; }
                            public string Revision { get; set; }
                            public string Status { get; set; }
                            public string Uid { get; set; }
                            public List<string> Finalizers { get; set; }
                        }
                    }
                }
                public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPreTasks> PreTasks { get; set; }
                public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPreTasks : TeaModel {
                    public string ActionCode { get; set; }
                    public bool? ConfirmSupported { get; set; }
                    public string Data { get; set; }
                    public string FinishedTime { get; set; }
                    public string Id { get; set; }
                    public bool? IgnoreSupported { get; set; }
                    public bool? RetrySupported { get; set; }
                    public string StartedTime { get; set; }
                    public string State { get; set; }
                    public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPreTasksAppDeployCells> AppDeployCells { get; set; }
                    public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPreTasksAppDeployCells : TeaModel {
                        public string CellName { get; set; }
                        public long? Partition { get; set; }
                        public long? ReleaseCount { get; set; }
                        public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPreTasksAppDeployCellsPodList> PodList { get; set; }
                        public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsPreTasksAppDeployCellsPodList : TeaModel {
                            public string Cluster { get; set; }
                            public string CreatedTime { get; set; }
                            public string LifecycleStage { get; set; }
                            public string Message { get; set; }
                            public string Name { get; set; }
                            public string Namespace { get; set; }
                            public string PodIp { get; set; }
                            public string Revision { get; set; }
                            public string Status { get; set; }
                            public string Uid { get; set; }
                            public List<string> Finalizers { get; set; }
                        }
                    }
                }
                public QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsDeployTask DeployTask { get; set; }
                public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsDeployTask : TeaModel {
                    [NameInMap("ActionCode")]
                    [Validation(Required=false)]
                    public string ActionCode { get; set; }

                    [NameInMap("ConfirmSupported")]
                    [Validation(Required=false)]
                    public bool? ConfirmSupported { get; set; }

                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                    [NameInMap("FinishedTime")]
                    [Validation(Required=false)]
                    public string FinishedTime { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("IgnoreSupported")]
                    [Validation(Required=false)]
                    public bool? IgnoreSupported { get; set; }

                    [NameInMap("RetrySupported")]
                    [Validation(Required=false)]
                    public bool? RetrySupported { get; set; }

                    [NameInMap("StartedTime")]
                    [Validation(Required=false)]
                    public string StartedTime { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("AppDeployCells")]
                    [Validation(Required=false)]
                    public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsDeployTaskAppDeployCells> AppDeployCells { get; set; }
                    public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsDeployTaskAppDeployCells : TeaModel {
                        [NameInMap("CellName")]
                        [Validation(Required=false)]
                        public string CellName { get; set; }

                        [NameInMap("Partition")]
                        [Validation(Required=false)]
                        public long? Partition { get; set; }

                        [NameInMap("ReleaseCount")]
                        [Validation(Required=false)]
                        public long? ReleaseCount { get; set; }

                        [NameInMap("PodList")]
                        [Validation(Required=false)]
                        public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsDeployTaskAppDeployCellsPodList> PodList { get; set; }
                        public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressExecuteGroupsDeployTaskAppDeployCellsPodList : TeaModel {
                            [NameInMap("Cluster")]
                            [Validation(Required=false)]
                            public string Cluster { get; set; }

                            [NameInMap("CreatedTime")]
                            [Validation(Required=false)]
                            public string CreatedTime { get; set; }

                            [NameInMap("LifecycleStage")]
                            [Validation(Required=false)]
                            public string LifecycleStage { get; set; }

                            [NameInMap("Message")]
                            [Validation(Required=false)]
                            public string Message { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Namespace")]
                            [Validation(Required=false)]
                            public string Namespace { get; set; }

                            [NameInMap("PodIp")]
                            [Validation(Required=false)]
                            public string PodIp { get; set; }

                            [NameInMap("Revision")]
                            [Validation(Required=false)]
                            public string Revision { get; set; }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                            [NameInMap("Uid")]
                            [Validation(Required=false)]
                            public string Uid { get; set; }

                            [NameInMap("Finalizers")]
                            [Validation(Required=false)]
                            public List<string> Finalizers { get; set; }

                        }

                    }

                }
            }
            [NameInMap("PostTasks")]
            [Validation(Required=false)]
            public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPostTasks> PostTasks { get; set; }
            public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPostTasks : TeaModel {
                public string ActionCode { get; set; }
                public bool? ConfirmSupported { get; set; }
                public string Data { get; set; }
                public string FinishedTime { get; set; }
                public string Id { get; set; }
                public bool? IgnoreSupported { get; set; }
                public bool? RetrySupported { get; set; }
                public string StartedTime { get; set; }
                public string State { get; set; }
                public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPostTasksAppDeployCells> AppDeployCells { get; set; }
                public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPostTasksAppDeployCells : TeaModel {
                    public string CellName { get; set; }
                    public long? Partition { get; set; }
                    public long? ReleaseCount { get; set; }
                    public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPostTasksAppDeployCellsPodList> PodList { get; set; }
                    public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPostTasksAppDeployCellsPodList : TeaModel {
                        public string Cluster { get; set; }
                        public string CreatedTime { get; set; }
                        public string LifecycleStage { get; set; }
                        public string Message { get; set; }
                        public string Name { get; set; }
                        public string Namespace { get; set; }
                        public string PodIp { get; set; }
                        public string Revision { get; set; }
                        public string Status { get; set; }
                        public string Uid { get; set; }
                        public List<string> Finalizers { get; set; }
                    }
                }
            }
            [NameInMap("PreTasks")]
            [Validation(Required=false)]
            public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPreTasks> PreTasks { get; set; }
            public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPreTasks : TeaModel {
                public string ActionCode { get; set; }
                public bool? ConfirmSupported { get; set; }
                public string Data { get; set; }
                public string FinishedTime { get; set; }
                public string Id { get; set; }
                public bool? IgnoreSupported { get; set; }
                public bool? RetrySupported { get; set; }
                public string StartedTime { get; set; }
                public string State { get; set; }
                public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPreTasksAppDeployCells> AppDeployCells { get; set; }
                public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPreTasksAppDeployCells : TeaModel {
                    public string CellName { get; set; }
                    public long? Partition { get; set; }
                    public long? ReleaseCount { get; set; }
                    public List<QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPreTasksAppDeployCellsPodList> PodList { get; set; }
                    public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPreTasksAppDeployCellsPodList : TeaModel {
                        public string Cluster { get; set; }
                        public string CreatedTime { get; set; }
                        public string LifecycleStage { get; set; }
                        public string Message { get; set; }
                        public string Name { get; set; }
                        public string Namespace { get; set; }
                        public string PodIp { get; set; }
                        public string Revision { get; set; }
                        public string Status { get; set; }
                        public string Uid { get; set; }
                        public List<string> Finalizers { get; set; }
                    }
                }
            }
            [NameInMap("PodStateSummary")]
            [Validation(Required=false)]
            public QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPodStateSummary PodStateSummary { get; set; }
            public class QueryLDCOpsplanAppprogressResponseBodyAppDeployProgressPodStateSummary : TeaModel {
                [NameInMap("Blocked")]
                [Validation(Required=false)]
                public long? Blocked { get; set; }

                [NameInMap("Executing")]
                [Validation(Required=false)]
                public long? Executing { get; set; }

                [NameInMap("Failed")]
                [Validation(Required=false)]
                public long? Failed { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Inited")]
                [Validation(Required=false)]
                public long? Inited { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("Succeeded")]
                [Validation(Required=false)]
                public long? Succeeded { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("Waiting")]
                [Validation(Required=false)]
                public long? Waiting { get; set; }

            }
        };

    }

}
