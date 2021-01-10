// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class RetryAKSOpsTaskResponseBody : TeaModel {
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
        public RetryAKSOpsTaskResponseBodyData Data { get; set; }
        public class RetryAKSOpsTaskResponseBodyData : TeaModel {
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
            public List<RetryAKSOpsTaskResponseBodyDataContext> Context { get; set; }
            public class RetryAKSOpsTaskResponseBodyDataContext : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("EntityRelation")]
            [Validation(Required=false)]
            public RetryAKSOpsTaskResponseBodyDataEntityRelation EntityRelation { get; set; }
            public class RetryAKSOpsTaskResponseBodyDataEntityRelation : TeaModel {
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
                public RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntity TransitableWithStateEntity { get; set; }
                public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntity : TeaModel {
                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }
                    [NameInMap("EnvExecutableEntityWithResult")]
                    [Validation(Required=false)]
                    public RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                    public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                        [NameInMap("MessageDetail")]
                        [Validation(Required=false)]
                        public List<RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail> MessageDetail { get; set; }
                        public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetail : TeaModel {
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        [NameInMap("MessageParams")]
                        [Validation(Required=false)]
                        public List<RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                        public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                            [NameInMap("Data")]
                            [Validation(Required=false)]
                            public string Data { get; set; }

                        }

                        [NameInMap("EnvExecutableEntity")]
                        [Validation(Required=false)]
                        public RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                        public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
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
                            public RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                            public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
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
                                public RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                                public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
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
                        public RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                        public class RetryAKSOpsTaskResponseBodyDataEntityRelationTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
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

}
