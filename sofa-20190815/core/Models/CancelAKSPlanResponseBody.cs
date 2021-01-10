// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CancelAKSPlanResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CancelAKSPlanResponseBodyData Data { get; set; }
        public class CancelAKSPlanResponseBodyData : TeaModel {
            [NameInMap("ExecutorName")]
            [Validation(Required=false)]
            public string ExecutorName { get; set; }
            [NameInMap("ExecutorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }
            [NameInMap("TimeSeriesId")]
            [Validation(Required=false)]
            public string TimeSeriesId { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }
            [NameInMap("Context")]
            [Validation(Required=false)]
            public List<CancelAKSPlanResponseBodyDataContext> Context { get; set; }
            public class CancelAKSPlanResponseBodyDataContext : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("OpsType")]
            [Validation(Required=false)]
            public string OpsType { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("InitialByTag")]
            [Validation(Required=false)]
            public string InitialByTag { get; set; }
            [NameInMap("AppCount")]
            [Validation(Required=false)]
            public long? AppCount { get; set; }
            [NameInMap("LastOperatorId")]
            [Validation(Required=false)]
            public string LastOperatorId { get; set; }
            [NameInMap("AutoExecution")]
            [Validation(Required=false)]
            public bool? AutoExecution { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("BaseTransitableWithStateEntity")]
            [Validation(Required=false)]
            public CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntity BaseTransitableWithStateEntity { get; set; }
            public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntity : TeaModel {
                [NameInMap("EnvExecutableEntityWithResult")]
                [Validation(Required=false)]
                public CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResult EnvExecutableEntityWithResult { get; set; }
                public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResult : TeaModel {
                    [NameInMap("MessageDetails")]
                    [Validation(Required=false)]
                    public List<CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetails> MessageDetails { get; set; }
                    public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultMessageDetails : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                    [NameInMap("MessageParams")]
                    [Validation(Required=false)]
                    public List<CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams> MessageParams { get; set; }
                    public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultMessageParams : TeaModel {
                        public string Data { get; set; }
                    }
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode ErrorCode { get; set; }
                    public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultErrorCode : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("ExceptionCode")]
                        [Validation(Required=false)]
                        public string ExceptionCode { get; set; }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                        [NameInMap("Prefix")]
                        [Validation(Required=false)]
                        public string Prefix { get; set; }

                        [NameInMap("Level")]
                        [Validation(Required=false)]
                        public string Level { get; set; }

                        [NameInMap("Scene")]
                        [Validation(Required=false)]
                        public string Scene { get; set; }

                    }
                    [NameInMap("EnvExecutableEntity")]
                    [Validation(Required=false)]
                    public CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity EnvExecutableEntity { get; set; }
                    public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntity : TeaModel {
                        [NameInMap("StartedTime")]
                        [Validation(Required=false)]
                        public string StartedTime { get; set; }

                        [NameInMap("FinishedTime")]
                        [Validation(Required=false)]
                        public string FinishedTime { get; set; }

                        [NameInMap("EnvEntity")]
                        [Validation(Required=false)]
                        public CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity EnvEntity { get; set; }
                        public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntity : TeaModel {
                            [NameInMap("WorkspaceId")]
                            [Validation(Required=false)]
                            public string WorkspaceId { get; set; }
                            [NameInMap("Entity")]
                            [Validation(Required=false)]
                            public CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity Entity { get; set; }
                            public class CancelAKSPlanResponseBodyDataBaseTransitableWithStateEntityEnvExecutableEntityWithResultEnvExecutableEntityEnvEntityEntity : TeaModel {
                                [NameInMap("ModifiedTime")]
                                [Validation(Required=false)]
                                public string ModifiedTime { get; set; }

                                [NameInMap("CreatedTime")]
                                [Validation(Required=false)]
                                public string CreatedTime { get; set; }

                                [NameInMap("Id")]
                                [Validation(Required=false)]
                                public string Id { get; set; }

                            }
                            [NameInMap("RunEnv")]
                            [Validation(Required=false)]
                            public string RunEnv { get; set; }
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }
                            [NameInMap("TenantId")]
                            [Validation(Required=false)]
                            public string TenantId { get; set; }
                        };

                        [NameInMap("StandaloneExecutable")]
                        [Validation(Required=false)]
                        public bool? StandaloneExecutable { get; set; }

                    }
                };

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }
            [NameInMap("LastOperator")]
            [Validation(Required=false)]
            public string LastOperator { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
