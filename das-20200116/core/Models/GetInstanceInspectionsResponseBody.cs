// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceInspectionsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The inspection and scoring results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceInspectionsResponseBodyData Data { get; set; }
        public class GetInstanceInspectionsResponseBodyData : TeaModel {
            /// <summary>
            /// The mode in which the inspection and scoring task was initiated. Valid values:
            /// 
            /// *   **0**: automatic mode
            /// *   **1**: manual mode
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetInstanceInspectionsResponseBodyDataList> List { get; set; }
            public class GetInstanceInspectionsResponseBodyDataList : TeaModel {
                /// <summary>
                /// Indicates whether the autonomy service is enabled.
                /// </summary>
                [NameInMap("AutoFunction")]
                [Validation(Required=false)]
                public GetInstanceInspectionsResponseBodyDataListAutoFunction AutoFunction { get; set; }
                public class GetInstanceInspectionsResponseBodyDataListAutoFunction : TeaModel {
                    /// <summary>
                    /// Indicates whether the feature of automatically creating and deleting indexes is enabled. Valid values:
                    /// 
                    /// * **0**: disabled.
                    /// * **1**: enabled.
                    /// * **2**: not supported.
                    /// </summary>
                    [NameInMap("AutoIndex")]
                    [Validation(Required=false)]
                    public int? AutoIndex { get; set; }

                    /// <summary>
                    /// Indicates whether the automatic throttling feature is enabled. Valid values:
                    /// 
                    /// * **0**: disabled.
                    /// * **1**: enabled.
                    /// * **2**: not supported.
                    /// </summary>
                    [NameInMap("AutoLimitedSql")]
                    [Validation(Required=false)]
                    public int? AutoLimitedSql { get; set; }

                    /// <summary>
                    /// Indicates whether automatic reclamation of fragments is enabled. Valid values:
                    /// 
                    /// * **0**: disabled.
                    /// * **1**: enabled.
                    /// * **2**: not supported.
                    /// </summary>
                    [NameInMap("AutoResourceOptimize")]
                    [Validation(Required=false)]
                    public int? AutoResourceOptimize { get; set; }

                    /// <summary>
                    /// Indicates whether the auto scaling feature is enabled. Valid values:
                    /// 
                    /// * **0**: disabled.
                    /// * **1**: enabled.
                    /// * **2**: not supported.
                    /// </summary>
                    [NameInMap("AutoScale")]
                    [Validation(Required=false)]
                    public int? AutoScale { get; set; }

                    /// <summary>
                    /// Indicates whether the event subscription feature is enabled. Valid values:
                    /// 
                    /// * **0**: disabled.
                    /// * **1**: enabled.
                    /// * **2**: not supported.
                    /// </summary>
                    [NameInMap("EventSubscription")]
                    [Validation(Required=false)]
                    public int? EventSubscription { get; set; }

                }

                /// <summary>
                /// The returned data.
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public Dictionary<string, object> Data { get; set; }

                /// <summary>
                /// Indicates whether DAS Professional Edition is enabled. Valid values:
                /// 
                /// * **0**: disabled.
                /// * **1**: enabled.
                /// * **2**: not supported.
                /// </summary>
                [NameInMap("EnableDasPro")]
                [Validation(Required=false)]
                public int? EnableDasPro { get; set; }

                /// <summary>
                /// The end time of the inspection and scoring task. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// 
                /// > The end time must be later than the start time.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// The time when the task was created. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The details of the instance.
                /// </summary>
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public GetInstanceInspectionsResponseBodyDataListInstance Instance { get; set; }
                public class GetInstanceInspectionsResponseBodyDataListInstance : TeaModel {
                    /// <summary>
                    /// The account ID. You can obtain the account ID on the **Security Settings** page in the Alibaba Cloud **account management center**.
                    /// </summary>
                    [NameInMap("AccountId")]
                    [Validation(Required=false)]
                    public string AccountId { get; set; }

                    /// <summary>
                    /// The connection mode of the instance. Valid values:
                    /// 
                    /// * **standard**: standard mode.
                    /// * **safe**: database proxy mode.
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// The CPU specification of the instance. For example, if a value of 8 is returned, the instance has eight CPU cores.
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public string Cpu { get; set; }

                    /// <summary>
                    /// The database engine. Valid values:
                    /// 
                    /// * **MySQL**
                    /// * **Redis**
                    /// * **PolarDBMySQL**
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// The version number of the database engine.
                    /// </summary>
                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    /// <summary>
                    /// The name of the instance.
                    /// </summary>
                    [NameInMap("InstanceAlias")]
                    [Validation(Required=false)]
                    public string InstanceAlias { get; set; }

                    /// <summary>
                    /// The type of the instance on which the database is deployed. Valid values:
                    /// 
                    /// * **RDS**: an Alibaba Cloud database instance.
                    /// * **ECS**: an ECS instance on which a self-managed database is deployed.
                    /// * **IDC**: a self-managed database instance that is not deployed on Alibaba Cloud.
                    /// 
                    /// > The value IDC indicates that the instance is deployed in a data center.
                    /// </summary>
                    [NameInMap("InstanceArea")]
                    [Validation(Required=false)]
                    public string InstanceArea { get; set; }

                    /// <summary>
                    /// The instance type.
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// The instance ID.
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// The memory capacity of the database that is deployed on the instance. Unit: MB.
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// The network type of the instance.
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// The ID of the node on the instance.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// The ID of the region in which the instance resides.
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// The storage space of the instance. Unit: GB.
                    /// </summary>
                    [NameInMap("Storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    /// <summary>
                    /// The unique identifier of the instance.
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// The ID of the virtual private cloud (VPC) in which the instance is deployed.
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// The inspection scores of the instance.
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// The scores that are deducted for the instance.
                /// </summary>
                [NameInMap("ScoreMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> ScoreMap { get; set; }

                /// <summary>
                /// The start time of the inspection and scoring task. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// The state of the inspection and scoring task. Valid values:
                /// 
                /// * **0**: The task is waiting for execution.
                /// * **1**: The task is in progress.
                /// * **2**: The task is complete.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public int? State { get; set; }

                /// <summary>
                /// The mode in which the inspection and scoring task was initiated. Valid values:
                /// 
                /// * **0**: automatic mode
                /// * **1**: manual mode
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

            /// <summary>
            /// The page number. The value returned is a positive integer. Default value: 1.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page. Default value: 10.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
