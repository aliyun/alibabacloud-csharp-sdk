// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ReinitAKSOpsContainerServiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReinitAKSOpsContainerServiceResponseBodyData Data { get; set; }
        public class ReinitAKSOpsContainerServiceResponseBodyData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("ArrangementId")]
            [Validation(Required=false)]
            public string ArrangementId { get; set; }
            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("ExecutorName")]
            [Validation(Required=false)]
            public string ExecutorName { get; set; }
            [NameInMap("GrayTraffic")]
            [Validation(Required=false)]
            public bool? GrayTraffic { get; set; }
            [NameInMap("IsRollbackType")]
            [Validation(Required=false)]
            public bool? IsRollbackType { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }
            [NameInMap("ResultContext")]
            [Validation(Required=false)]
            public string ResultContext { get; set; }
            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }
            [NameInMap("RollbackEntityId")]
            [Validation(Required=false)]
            public string RollbackEntityId { get; set; }
            [NameInMap("RollbackEntityType")]
            [Validation(Required=false)]
            public string RollbackEntityType { get; set; }
            [NameInMap("RollbackRevision")]
            [Validation(Required=false)]
            public string RollbackRevision { get; set; }
            [NameInMap("ServiceGroupCollectionId")]
            [Validation(Required=false)]
            public string ServiceGroupCollectionId { get; set; }
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }
            [NameInMap("EnvConfig")]
            [Validation(Required=false)]
            public List<ReinitAKSOpsContainerServiceResponseBodyDataEnvConfig> EnvConfig { get; set; }
            public class ReinitAKSOpsContainerServiceResponseBodyDataEnvConfig : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("PostDeploymentArrangements")]
            [Validation(Required=false)]
            public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangements> PostDeploymentArrangements { get; set; }
            public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangements : TeaModel {
                public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasks> Tasks { get; set; }
                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasks : TeaModel {
                    public string ActionHandlerCode { get; set; }
                    public string ArrangementId { get; set; }
                    public string ServiceGroupCollectionId { get; set; }
                    public string ServiceGroupId { get; set; }
                    public string ServiceId { get; set; }
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksContext> Context { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksContext : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelation EntityRelation { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelation : TeaModel {
                        [NameInMap("ParentEntityType")]
                        [Validation(Required=false)]
                        public string ParentEntityType { get; set; }

                        [NameInMap("ParentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }

                        [NameInMap("ProcessDefinitionId")]
                        [Validation(Required=false)]
                        public string ProcessDefinitionId { get; set; }

                        [NameInMap("TransitableWithStateEntity")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntity : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }
                            [NameInMap("EnvExecutableEntityWithResult")]
                            [Validation(Required=false)]
                            public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                            public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                                [NameInMap("MessageDetail")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                                    [NameInMap("Key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                [NameInMap("MessageParams")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                                    [NameInMap("Data")]
                                    [Validation(Required=false)]
                                    public string Data { get; set; }

                                }

                                [NameInMap("EnvExecutableEntity")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                                    [NameInMap("FinishedTime")]
                                    [Validation(Required=false)]
                                    public string FinishedTime { get; set; }
                                    [NameInMap("StandaloneExecutable")]
                                    [Validation(Required=false)]
                                    public bool? StandaloneExecutable { get; set; }
                                    [NameInMap("StartedTime")]
                                    [Validation(Required=false)]
                                    public string StartedTime { get; set; }
                                    [NameInMap("EnvEntity")]
                                    [Validation(Required=false)]
                                    public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                                    public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                                        [NameInMap("RegionId")]
                                        [Validation(Required=false)]
                                        public string RegionId { get; set; }

                                        [NameInMap("RunEnv")]
                                        [Validation(Required=false)]
                                        public string RunEnv { get; set; }

                                        [NameInMap("TenantId")]
                                        [Validation(Required=false)]
                                        public string TenantId { get; set; }

                                        [NameInMap("WorkspaceId")]
                                        [Validation(Required=false)]
                                        public string WorkspaceId { get; set; }

                                        [NameInMap("Entity")]
                                        [Validation(Required=false)]
                                        public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                        public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                            [NameInMap("CreatedTime")]
                                            [Validation(Required=false)]
                                            public string CreatedTime { get; set; }
                                            [NameInMap("Id")]
                                            [Validation(Required=false)]
                                            public string Id { get; set; }
                                            [NameInMap("ModifiedTime")]
                                            [Validation(Required=false)]
                                            public string ModifiedTime { get; set; }
                                        };

                                    }
                                };

                                [NameInMap("ErrorCode")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                                    [NameInMap("ExceptionCode")]
                                    [Validation(Required=false)]
                                    public string ExceptionCode { get; set; }
                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }
                                    [NameInMap("Prefix")]
                                    [Validation(Required=false)]
                                    public string Prefix { get; set; }
                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }
                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }
                                    [NameInMap("Version")]
                                    [Validation(Required=false)]
                                    public string Version { get; set; }
                                };

                            }
                        };

                    }
                }
                public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangement OpsGenericArrangement { get; set; }
                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangement : TeaModel {
                    [NameInMap("ArrangementType")]
                    [Validation(Required=false)]
                    public string ArrangementType { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ServiceGroupCollectionId")]
                    [Validation(Required=false)]
                    public string ServiceGroupCollectionId { get; set; }

                    [NameInMap("ActionTypes")]
                    [Validation(Required=false)]
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementActionTypes> ActionTypes { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementActionTypes : TeaModel {
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                    }

                    [NameInMap("OpsGenericEnvConfig")]
                    [Validation(Required=false)]
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEnvConfig> OpsGenericEnvConfig { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEnvConfig : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("OpsGenericEntityRelation")]
                    [Validation(Required=false)]
                    public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelation OpsGenericEntityRelation { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelation : TeaModel {
                        [NameInMap("ParentEntityType")]
                        [Validation(Required=false)]
                        public string ParentEntityType { get; set; }
                        [NameInMap("ParentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }
                        [NameInMap("ProcessDefinitionId")]
                        [Validation(Required=false)]
                        public string ProcessDefinitionId { get; set; }
                        [NameInMap("TransitableWithStateEntity")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntity : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            [NameInMap("EnvExecutableEntityWithResult")]
                            [Validation(Required=false)]
                            public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                            public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                                [NameInMap("MessageDetail")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                                    public string Key { get; set; }
                                    public string Value { get; set; }
                                }
                                [NameInMap("MessageParams")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                                    public string Data { get; set; }
                                }
                                [NameInMap("EnvExecutableEntity")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                                    [NameInMap("FinishedTime")]
                                    [Validation(Required=false)]
                                    public string FinishedTime { get; set; }

                                    [NameInMap("StandaloneExecutable")]
                                    [Validation(Required=false)]
                                    public bool? StandaloneExecutable { get; set; }

                                    [NameInMap("StartedTime")]
                                    [Validation(Required=false)]
                                    public string StartedTime { get; set; }

                                    [NameInMap("EnvEntity")]
                                    [Validation(Required=false)]
                                    public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                                    public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                                        [NameInMap("RegionId")]
                                        [Validation(Required=false)]
                                        public string RegionId { get; set; }
                                        [NameInMap("RunEnv")]
                                        [Validation(Required=false)]
                                        public string RunEnv { get; set; }
                                        [NameInMap("TenantId")]
                                        [Validation(Required=false)]
                                        public string TenantId { get; set; }
                                        [NameInMap("WorkspaceId")]
                                        [Validation(Required=false)]
                                        public string WorkspaceId { get; set; }
                                        [NameInMap("Entity")]
                                        [Validation(Required=false)]
                                        public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                        public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                            [NameInMap("CreatedTime")]
                                            [Validation(Required=false)]
                                            public string CreatedTime { get; set; }

                                            [NameInMap("Id")]
                                            [Validation(Required=false)]
                                            public string Id { get; set; }

                                            [NameInMap("ModifiedTime")]
                                            [Validation(Required=false)]
                                            public string ModifiedTime { get; set; }

                                        }
                                    };

                                }
                                [NameInMap("ErrorCode")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPostDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                                    [NameInMap("ExceptionCode")]
                                    [Validation(Required=false)]
                                    public string ExceptionCode { get; set; }

                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                    [NameInMap("Prefix")]
                                    [Validation(Required=false)]
                                    public string Prefix { get; set; }

                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }

                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                    [NameInMap("Version")]
                                    [Validation(Required=false)]
                                    public string Version { get; set; }

                                }
                            };

                        }
                    };

                }
            }
            [NameInMap("PreDeploymentArrangements")]
            [Validation(Required=false)]
            public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangements> PreDeploymentArrangements { get; set; }
            public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangements : TeaModel {
                public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasks> Tasks { get; set; }
                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasks : TeaModel {
                    public string ActionHandlerCode { get; set; }
                    public string ArrangementId { get; set; }
                    public string ServiceGroupCollectionId { get; set; }
                    public string ServiceGroupId { get; set; }
                    public string ServiceId { get; set; }
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksContext> Context { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksContext : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelation EntityRelation { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelation : TeaModel {
                        [NameInMap("ParentEntityType")]
                        [Validation(Required=false)]
                        public string ParentEntityType { get; set; }

                        [NameInMap("ParentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }

                        [NameInMap("ProcessDefinitionId")]
                        [Validation(Required=false)]
                        public string ProcessDefinitionId { get; set; }

                        [NameInMap("TransitableWithStateEntity")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntity : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }
                            [NameInMap("EnvExecutableEntityWithResult")]
                            [Validation(Required=false)]
                            public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                            public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                                [NameInMap("MessageDetail")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                                    [NameInMap("Key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                [NameInMap("MessageParams")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                                    [NameInMap("Data")]
                                    [Validation(Required=false)]
                                    public string Data { get; set; }

                                }

                                [NameInMap("EnvExecutableEntity")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                                    [NameInMap("FinishedTime")]
                                    [Validation(Required=false)]
                                    public string FinishedTime { get; set; }
                                    [NameInMap("StandaloneExecutable")]
                                    [Validation(Required=false)]
                                    public bool? StandaloneExecutable { get; set; }
                                    [NameInMap("StartedTime")]
                                    [Validation(Required=false)]
                                    public string StartedTime { get; set; }
                                    [NameInMap("EnvEntity")]
                                    [Validation(Required=false)]
                                    public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                                    public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                                        [NameInMap("RegionId")]
                                        [Validation(Required=false)]
                                        public string RegionId { get; set; }

                                        [NameInMap("RunEnv")]
                                        [Validation(Required=false)]
                                        public string RunEnv { get; set; }

                                        [NameInMap("TenantId")]
                                        [Validation(Required=false)]
                                        public string TenantId { get; set; }

                                        [NameInMap("WorkspaceId")]
                                        [Validation(Required=false)]
                                        public string WorkspaceId { get; set; }

                                        [NameInMap("Entity")]
                                        [Validation(Required=false)]
                                        public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                        public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                            [NameInMap("CreatedTime")]
                                            [Validation(Required=false)]
                                            public string CreatedTime { get; set; }
                                            [NameInMap("Id")]
                                            [Validation(Required=false)]
                                            public string Id { get; set; }
                                            [NameInMap("ModifiedTime")]
                                            [Validation(Required=false)]
                                            public string ModifiedTime { get; set; }
                                        };

                                    }
                                };

                                [NameInMap("ErrorCode")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                                    [NameInMap("ExceptionCode")]
                                    [Validation(Required=false)]
                                    public string ExceptionCode { get; set; }
                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }
                                    [NameInMap("Prefix")]
                                    [Validation(Required=false)]
                                    public string Prefix { get; set; }
                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }
                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }
                                    [NameInMap("Version")]
                                    [Validation(Required=false)]
                                    public string Version { get; set; }
                                };

                            }
                        };

                    }
                }
                public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangement OpsGenericArrangement { get; set; }
                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangement : TeaModel {
                    [NameInMap("ArrangementType")]
                    [Validation(Required=false)]
                    public string ArrangementType { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ServiceGroupCollectionId")]
                    [Validation(Required=false)]
                    public string ServiceGroupCollectionId { get; set; }

                    [NameInMap("ActionTypes")]
                    [Validation(Required=false)]
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementActionTypes> ActionTypes { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementActionTypes : TeaModel {
                        [NameInMap("Data")]
                        [Validation(Required=false)]
                        public string Data { get; set; }

                    }

                    [NameInMap("OpsGenericEnvConfig")]
                    [Validation(Required=false)]
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEnvConfig> OpsGenericEnvConfig { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEnvConfig : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("OpsGenericEntityRelation")]
                    [Validation(Required=false)]
                    public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelation OpsGenericEntityRelation { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelation : TeaModel {
                        [NameInMap("ParentEntityType")]
                        [Validation(Required=false)]
                        public string ParentEntityType { get; set; }
                        [NameInMap("ParentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }
                        [NameInMap("ProcessDefinitionId")]
                        [Validation(Required=false)]
                        public string ProcessDefinitionId { get; set; }
                        [NameInMap("TransitableWithStateEntity")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntity : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            [NameInMap("EnvExecutableEntityWithResult")]
                            [Validation(Required=false)]
                            public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                            public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                                [NameInMap("MessageDetail")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                                    public string Key { get; set; }
                                    public string Value { get; set; }
                                }
                                [NameInMap("MessageParams")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                                    public string Data { get; set; }
                                }
                                [NameInMap("EnvExecutableEntity")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                                    [NameInMap("FinishedTime")]
                                    [Validation(Required=false)]
                                    public string FinishedTime { get; set; }

                                    [NameInMap("StandaloneExecutable")]
                                    [Validation(Required=false)]
                                    public bool? StandaloneExecutable { get; set; }

                                    [NameInMap("StartedTime")]
                                    [Validation(Required=false)]
                                    public string StartedTime { get; set; }

                                    [NameInMap("EnvEntity")]
                                    [Validation(Required=false)]
                                    public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                                    public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                                        [NameInMap("RegionId")]
                                        [Validation(Required=false)]
                                        public string RegionId { get; set; }
                                        [NameInMap("RunEnv")]
                                        [Validation(Required=false)]
                                        public string RunEnv { get; set; }
                                        [NameInMap("TenantId")]
                                        [Validation(Required=false)]
                                        public string TenantId { get; set; }
                                        [NameInMap("WorkspaceId")]
                                        [Validation(Required=false)]
                                        public string WorkspaceId { get; set; }
                                        [NameInMap("Entity")]
                                        [Validation(Required=false)]
                                        public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                        public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                            [NameInMap("CreatedTime")]
                                            [Validation(Required=false)]
                                            public string CreatedTime { get; set; }

                                            [NameInMap("Id")]
                                            [Validation(Required=false)]
                                            public string Id { get; set; }

                                            [NameInMap("ModifiedTime")]
                                            [Validation(Required=false)]
                                            public string ModifiedTime { get; set; }

                                        }
                                    };

                                }
                                [NameInMap("ErrorCode")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataPreDeploymentArrangementsOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                                    [NameInMap("ExceptionCode")]
                                    [Validation(Required=false)]
                                    public string ExceptionCode { get; set; }

                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                    [NameInMap("Prefix")]
                                    [Validation(Required=false)]
                                    public string Prefix { get; set; }

                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }

                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                    [NameInMap("Version")]
                                    [Validation(Required=false)]
                                    public string Version { get; set; }

                                }
                            };

                        }
                    };

                }
            }
            [NameInMap("BaseEntityRelation")]
            [Validation(Required=false)]
            public ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelation BaseEntityRelation { get; set; }
            public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelation : TeaModel {
                [NameInMap("ParentEntityType")]
                [Validation(Required=false)]
                public string ParentEntityType { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("ProcessDefinitionId")]
                [Validation(Required=false)]
                public string ProcessDefinitionId { get; set; }

                [NameInMap("TransitableWithStateEntity")]
                [Validation(Required=false)]
                public ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntity : TeaModel {
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }
                    [NameInMap("EnvExecutableEntityWithResult")]
                    [Validation(Required=false)]
                    public ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                        [NameInMap("MessageDetail")]
                        [Validation(Required=false)]
                        public List<ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("MessageParams")]
                        [Validation(Required=false)]
                        public List<ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                            [NameInMap("Data")]
                            [Validation(Required=false)]
                            public string Data { get; set; }

                        }

                        [NameInMap("EnvExecutableEntity")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                            [NameInMap("FinishedTime")]
                            [Validation(Required=false)]
                            public string FinishedTime { get; set; }
                            [NameInMap("StandaloneExecutable")]
                            [Validation(Required=false)]
                            public bool? StandaloneExecutable { get; set; }
                            [NameInMap("StartedTime")]
                            [Validation(Required=false)]
                            public string StartedTime { get; set; }
                            [NameInMap("EnvEntity")]
                            [Validation(Required=false)]
                            public ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                            public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                                [NameInMap("RegionId")]
                                [Validation(Required=false)]
                                public string RegionId { get; set; }

                                [NameInMap("RunEnv")]
                                [Validation(Required=false)]
                                public string RunEnv { get; set; }

                                [NameInMap("TenantId")]
                                [Validation(Required=false)]
                                public string TenantId { get; set; }

                                [NameInMap("WorkspaceId")]
                                [Validation(Required=false)]
                                public string WorkspaceId { get; set; }

                                [NameInMap("Entity")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                    [NameInMap("CreatedTime")]
                                    [Validation(Required=false)]
                                    public string CreatedTime { get; set; }
                                    [NameInMap("Id")]
                                    [Validation(Required=false)]
                                    public string Id { get; set; }
                                    [NameInMap("ModifiedTime")]
                                    [Validation(Required=false)]
                                    public string ModifiedTime { get; set; }
                                };

                            }
                        };

                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataBaseEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                            [NameInMap("ExceptionCode")]
                            [Validation(Required=false)]
                            public string ExceptionCode { get; set; }
                            [NameInMap("Level")]
                            [Validation(Required=false)]
                            public string Level { get; set; }
                            [NameInMap("Prefix")]
                            [Validation(Required=false)]
                            public string Prefix { get; set; }
                            [NameInMap("Scene")]
                            [Validation(Required=false)]
                            public string Scene { get; set; }
                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }
                            [NameInMap("Version")]
                            [Validation(Required=false)]
                            public string Version { get; set; }
                        };

                    }
                };

            }
            [NameInMap("DeploymentArrangement")]
            [Validation(Required=false)]
            public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangement DeploymentArrangement { get; set; }
            public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangement : TeaModel {
                [NameInMap("Tasks")]
                [Validation(Required=false)]
                public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasks> Tasks { get; set; }
                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasks : TeaModel {
                    [NameInMap("ActionHandlerCode")]
                    [Validation(Required=false)]
                    public string ActionHandlerCode { get; set; }

                    [NameInMap("ArrangementId")]
                    [Validation(Required=false)]
                    public string ArrangementId { get; set; }

                    [NameInMap("ServiceGroupCollectionId")]
                    [Validation(Required=false)]
                    public string ServiceGroupCollectionId { get; set; }

                    [NameInMap("ServiceGroupId")]
                    [Validation(Required=false)]
                    public string ServiceGroupId { get; set; }

                    [NameInMap("ServiceId")]
                    [Validation(Required=false)]
                    public string ServiceId { get; set; }

                    [NameInMap("Context")]
                    [Validation(Required=false)]
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksContext> Context { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksContext : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("EntityRelation")]
                    [Validation(Required=false)]
                    public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelation EntityRelation { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelation : TeaModel {
                        [NameInMap("ParentEntityType")]
                        [Validation(Required=false)]
                        public string ParentEntityType { get; set; }
                        [NameInMap("ParentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }
                        [NameInMap("ProcessDefinitionId")]
                        [Validation(Required=false)]
                        public string ProcessDefinitionId { get; set; }
                        [NameInMap("TransitableWithStateEntity")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntity : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }

                            [NameInMap("EnvExecutableEntityWithResult")]
                            [Validation(Required=false)]
                            public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                            public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                                [NameInMap("MessageDetail")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                                    public string Key { get; set; }
                                    public string Value { get; set; }
                                }
                                [NameInMap("MessageParams")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                                    public string Data { get; set; }
                                }
                                [NameInMap("EnvExecutableEntity")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                                    [NameInMap("FinishedTime")]
                                    [Validation(Required=false)]
                                    public string FinishedTime { get; set; }

                                    [NameInMap("StandaloneExecutable")]
                                    [Validation(Required=false)]
                                    public bool? StandaloneExecutable { get; set; }

                                    [NameInMap("StartedTime")]
                                    [Validation(Required=false)]
                                    public string StartedTime { get; set; }

                                    [NameInMap("EnvEntity")]
                                    [Validation(Required=false)]
                                    public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                                    public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                                        [NameInMap("RegionId")]
                                        [Validation(Required=false)]
                                        public string RegionId { get; set; }
                                        [NameInMap("RunEnv")]
                                        [Validation(Required=false)]
                                        public string RunEnv { get; set; }
                                        [NameInMap("TenantId")]
                                        [Validation(Required=false)]
                                        public string TenantId { get; set; }
                                        [NameInMap("WorkspaceId")]
                                        [Validation(Required=false)]
                                        public string WorkspaceId { get; set; }
                                        [NameInMap("Entity")]
                                        [Validation(Required=false)]
                                        public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                        public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                            [NameInMap("CreatedTime")]
                                            [Validation(Required=false)]
                                            public string CreatedTime { get; set; }

                                            [NameInMap("Id")]
                                            [Validation(Required=false)]
                                            public string Id { get; set; }

                                            [NameInMap("ModifiedTime")]
                                            [Validation(Required=false)]
                                            public string ModifiedTime { get; set; }

                                        }
                                    };

                                }
                                [NameInMap("ErrorCode")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementTasksEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                                    [NameInMap("ExceptionCode")]
                                    [Validation(Required=false)]
                                    public string ExceptionCode { get; set; }

                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }

                                    [NameInMap("Prefix")]
                                    [Validation(Required=false)]
                                    public string Prefix { get; set; }

                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }

                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }

                                    [NameInMap("Version")]
                                    [Validation(Required=false)]
                                    public string Version { get; set; }

                                }
                            };

                        }
                    };

                }

                [NameInMap("OpsGenericArrangement")]
                [Validation(Required=false)]
                public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangement OpsGenericArrangement { get; set; }
                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangement : TeaModel {
                    [NameInMap("ArrangementType")]
                    [Validation(Required=false)]
                    public string ArrangementType { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                    [NameInMap("ServiceGroupCollectionId")]
                    [Validation(Required=false)]
                    public string ServiceGroupCollectionId { get; set; }
                    [NameInMap("ActionTypes")]
                    [Validation(Required=false)]
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementActionTypes> ActionTypes { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementActionTypes : TeaModel {
                        public string Data { get; set; }
                    }
                    [NameInMap("OpsGenericEnvConfig")]
                    [Validation(Required=false)]
                    public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEnvConfig> OpsGenericEnvConfig { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEnvConfig : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    [NameInMap("OpsGenericEntityRelation")]
                    [Validation(Required=false)]
                    public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelation OpsGenericEntityRelation { get; set; }
                    public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelation : TeaModel {
                        [NameInMap("ParentEntityType")]
                        [Validation(Required=false)]
                        public string ParentEntityType { get; set; }

                        [NameInMap("ParentId")]
                        [Validation(Required=false)]
                        public string ParentId { get; set; }

                        [NameInMap("ProcessDefinitionId")]
                        [Validation(Required=false)]
                        public string ProcessDefinitionId { get; set; }

                        [NameInMap("TransitableWithStateEntity")]
                        [Validation(Required=false)]
                        public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                        public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntity : TeaModel {
                            [NameInMap("State")]
                            [Validation(Required=false)]
                            public string State { get; set; }
                            [NameInMap("EnvExecutableEntityWithResult")]
                            [Validation(Required=false)]
                            public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                            public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                                [NameInMap("MessageDetail")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                                    [NameInMap("Key")]
                                    [Validation(Required=false)]
                                    public string Key { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                                [NameInMap("MessageParams")]
                                [Validation(Required=false)]
                                public List<ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                                    [NameInMap("Data")]
                                    [Validation(Required=false)]
                                    public string Data { get; set; }

                                }

                                [NameInMap("EnvExecutableEntity")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                                    [NameInMap("FinishedTime")]
                                    [Validation(Required=false)]
                                    public string FinishedTime { get; set; }
                                    [NameInMap("StandaloneExecutable")]
                                    [Validation(Required=false)]
                                    public bool? StandaloneExecutable { get; set; }
                                    [NameInMap("StartedTime")]
                                    [Validation(Required=false)]
                                    public string StartedTime { get; set; }
                                    [NameInMap("EnvEntity")]
                                    [Validation(Required=false)]
                                    public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                                    public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                                        [NameInMap("RegionId")]
                                        [Validation(Required=false)]
                                        public string RegionId { get; set; }

                                        [NameInMap("RunEnv")]
                                        [Validation(Required=false)]
                                        public string RunEnv { get; set; }

                                        [NameInMap("TenantId")]
                                        [Validation(Required=false)]
                                        public string TenantId { get; set; }

                                        [NameInMap("WorkspaceId")]
                                        [Validation(Required=false)]
                                        public string WorkspaceId { get; set; }

                                        [NameInMap("Entity")]
                                        [Validation(Required=false)]
                                        public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                        public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                            [NameInMap("CreatedTime")]
                                            [Validation(Required=false)]
                                            public string CreatedTime { get; set; }
                                            [NameInMap("Id")]
                                            [Validation(Required=false)]
                                            public string Id { get; set; }
                                            [NameInMap("ModifiedTime")]
                                            [Validation(Required=false)]
                                            public string ModifiedTime { get; set; }
                                        };

                                    }
                                };

                                [NameInMap("ErrorCode")]
                                [Validation(Required=false)]
                                public ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                                public class ReinitAKSOpsContainerServiceResponseBodyDataDeploymentArrangementOpsGenericArrangementOpsGenericEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                                    [NameInMap("ExceptionCode")]
                                    [Validation(Required=false)]
                                    public string ExceptionCode { get; set; }
                                    [NameInMap("Level")]
                                    [Validation(Required=false)]
                                    public string Level { get; set; }
                                    [NameInMap("Prefix")]
                                    [Validation(Required=false)]
                                    public string Prefix { get; set; }
                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }
                                    [NameInMap("Type")]
                                    [Validation(Required=false)]
                                    public string Type { get; set; }
                                    [NameInMap("Version")]
                                    [Validation(Required=false)]
                                    public string Version { get; set; }
                                };

                            }
                        };

                    }
                };

            }
        };

    }

}
