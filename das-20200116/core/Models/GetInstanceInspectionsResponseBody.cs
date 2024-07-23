// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetInstanceInspectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceInspectionsResponseBodyData Data { get; set; }
        public class GetInstanceInspectionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The detailed information.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetInstanceInspectionsResponseBodyDataList> List { get; set; }
            public class GetInstanceInspectionsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the autonomy service is enabled.</para>
                /// </summary>
                [NameInMap("AutoFunction")]
                [Validation(Required=false)]
                public GetInstanceInspectionsResponseBodyDataListAutoFunction AutoFunction { get; set; }
                public class GetInstanceInspectionsResponseBodyDataListAutoFunction : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the feature of automatically creating and deleting indexes is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// <item><description><b>2</b>: not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AutoIndex")]
                    [Validation(Required=false)]
                    public int? AutoIndex { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the automatic throttling feature is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// <item><description><b>2</b>: not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AutoLimitedSql")]
                    [Validation(Required=false)]
                    public int? AutoLimitedSql { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the automatic fragment recycling feature is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// <item><description><b>2</b>: not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AutoResourceOptimize")]
                    [Validation(Required=false)]
                    public int? AutoResourceOptimize { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the auto scaling feature is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// <item><description><b>2</b>: not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AutoScale")]
                    [Validation(Required=false)]
                    public int? AutoScale { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the event subscription feature is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>0</b>: disabled.</description></item>
                    /// <item><description><b>1</b>: enabled.</description></item>
                    /// <item><description><b>2</b>: not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("EventSubscription")]
                    [Validation(Required=false)]
                    public int? EventSubscription { get; set; }

                }

                /// <summary>
                /// <para>The data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;data&quot;: { &quot;hasDeadLock&quot;: false, &quot;exceptionTableMap&quot;: {}, &quot;bigTransactionCount&quot;: 0, &quot;cpu&quot;: 4, &quot;isRds&quot;: true, &quot;rdsEnable&quot;: true, &quot;enable&quot;: false, &quot;activeSessions&quot;: [], &quot;bigTransactionList&quot;: [], &quot;bigSessionList&quot;: [ { &quot;blockDuration&quot;: 0, &quot;active&quot;: false, &quot;Time&quot;: 0, &quot;db&quot;: &quot;&quot; },</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public Dictionary<string, object> Data { get; set; }

                /// <summary>
                /// <para>Indicates whether DAS Enterprise Edition is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: disabled.</description></item>
                /// <item><description><b>1</b>: enabled.</description></item>
                /// <item><description><b>2</b>: not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EnableDasPro")]
                [Validation(Required=false)]
                public int? EnableDasPro { get; set; }

                /// <summary>
                /// <para>The end time of the inspection and scoring task. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// <remarks>
                /// <para> The end time must be later than the start time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1608888296001</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The time when the task was created. The value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603247192000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The information about the instance.</para>
                /// </summary>
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public GetInstanceInspectionsResponseBodyDataListInstance Instance { get; set; }
                public class GetInstanceInspectionsResponseBodyDataListInstance : TeaModel {
                    /// <summary>
                    /// <para>The account ID. You can view the ID of the logon account by moving the pointer over the profile in the Alibaba Cloud management console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>108398049688****</para>
                    /// </summary>
                    [NameInMap("AccountId")]
                    [Validation(Required=false)]
                    public string AccountId { get; set; }

                    /// <summary>
                    /// <para>The connection mode of the instance. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>standard</b>: standard mode.</description></item>
                    /// <item><description><b>safe</b>: database proxy mode.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>standard</para>
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// <para>The CPU specification of the instance. For example, if a value of 8 is returned, the instance has eight CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public string Cpu { get; set; }

                    /// <summary>
                    /// <para>The database engine. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>MySQL</b></description></item>
                    /// <item><description><b>Redis</b></description></item>
                    /// <item><description><b>PolarDBMySQL</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("Engine")]
                    [Validation(Required=false)]
                    public string Engine { get; set; }

                    /// <summary>
                    /// <para>The version number of the database engine.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.0</para>
                    /// </summary>
                    [NameInMap("EngineVersion")]
                    [Validation(Required=false)]
                    public string EngineVersion { get; set; }

                    /// <summary>
                    /// <para>The instance name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-01</para>
                    /// </summary>
                    [NameInMap("InstanceAlias")]
                    [Validation(Required=false)]
                    public string InstanceAlias { get; set; }

                    /// <summary>
                    /// <para>The type of the instance on which the database is deployed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>RDS</b>: an Alibaba Cloud database instance.</description></item>
                    /// <item><description><b>ECS</b>: an Elastic Compute Service (ECS) instance on which a self-managed database is deployed.</description></item>
                    /// <item><description><b>IDC</b>: a self-managed database instance that is not deployed on Alibaba Cloud.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> The value IDC indicates that the instance is deployed in a data center.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RDS</para>
                    /// </summary>
                    [NameInMap("InstanceArea")]
                    [Validation(Required=false)]
                    public string InstanceArea { get; set; }

                    /// <summary>
                    /// <para>The instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rds.mysql.s2.xlarge</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-bp10usoc1erj7****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The memory capacity of the database that is deployed on the instance. Unit: MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32768</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public int? Memory { get; set; }

                    /// <summary>
                    /// <para>The network type of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>VPC</para>
                    /// </summary>
                    [NameInMap("NetworkType")]
                    [Validation(Required=false)]
                    public string NetworkType { get; set; }

                    /// <summary>
                    /// <para>The ID of the node on the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-bp10usoc1erj7****</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The region ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The storage space of the instance. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>150</para>
                    /// </summary>
                    [NameInMap("Storage")]
                    [Validation(Required=false)]
                    public int? Storage { get; set; }

                    /// <summary>
                    /// <para>The unique identifier of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hdm_3063db6792965c080a4bcb6e6304****</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                    /// <summary>
                    /// <para>The ID of the virtual private cloud (VPC) in which the instance is deployed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-bp1knt7m55z9exoo7****</para>
                    /// </summary>
                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The inspection score of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The scores that are deducted for the instance.</para>
                /// </summary>
                [NameInMap("ScoreMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> ScoreMap { get; set; }

                /// <summary>
                /// <para>The start time of the inspection and scoring task. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1608888296000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The state of the inspection and scoring task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The task is waiting for execution.</description></item>
                /// <item><description><b>1</b>: The task is in progress.</description></item>
                /// <item><description><b>2</b>: The task is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public int? State { get; set; }

                /// <summary>
                /// <para>The mode in which the inspection and scoring task was initiated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: automatic mode.</description></item>
                /// <item><description><b>1</b>: manual mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

            }

            /// <summary>
            /// <para>The page number. The value returned is a positive integer. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, Successful is returned. If the request failed, an error message such as an error code is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
