// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPhysicalInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Instance details</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetPhysicalInstanceResponseBodyInstance Instance { get; set; }
        public class GetPhysicalInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>Business date</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-25</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>Scheduled time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-27 00:30:00</para>
            /// </summary>
            [NameInMap("DueTime")]
            [Validation(Required=false)]
            public string DueTime { get; set; }

            /// <summary>
            /// <para>Execution duration</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600s</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>End execution time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-27 02:30:00</para>
            /// </summary>
            [NameInMap("EndExecuteTime")]
            [Validation(Required=false)]
            public long? EndExecuteTime { get; set; }

            /// <summary>
            /// <para>Extended information</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_23231</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Running instance index</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }

            /// <summary>
            /// <para>Node details</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public GetPhysicalInstanceResponseBodyInstanceNodeInfo NodeInfo { get; set; }
            public class GetPhysicalInstanceResponseBodyInstanceNodeInfo : TeaModel {
                /// <summary>
                /// <para>Business unit name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <para>Creation time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-02 23:53:17</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Creator</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public GetPhysicalInstanceResponseBodyInstanceNodeInfoCreator Creator { get; set; }
                public class GetPhysicalInstanceResponseBodyInstanceNodeInfoCreator : TeaModel {
                    /// <summary>
                    /// <para>User ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2323111</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Username</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Description</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx 测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a dry run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>Source system of the node</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <para>Indicates whether the development environment exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasDev")]
                [Validation(Required=false)]
                public bool? HasDev { get; set; }

                /// <summary>
                /// <para>Indicates whether the production environment exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasProd")]
                [Validation(Required=false)]
                public bool? HasProd { get; set; }

                /// <summary>
                /// <para>Node ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_3232312</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Last modified time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-02-02 23:53:17</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                /// <summary>
                /// <para>Modifier</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public GetPhysicalInstanceResponseBodyInstanceNodeInfoModifier Modifier { get; set; }
                public class GetPhysicalInstanceResponseBodyInstanceNodeInfoModifier : TeaModel {
                    /// <summary>
                    /// <para>User ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2323111</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Username</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Node name</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Owner list</para>
                /// </summary>
                [NameInMap("OwnerList")]
                [Validation(Required=false)]
                public List<GetPhysicalInstanceResponseBodyInstanceNodeInfoOwnerList> OwnerList { get; set; }
                public class GetPhysicalInstanceResponseBodyInstanceNodeInfoOwnerList : TeaModel {
                    /// <summary>
                    /// <para>User ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2323111</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Username</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>zhangsan</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Priority</para>
                /// <list type="bullet">
                /// <item><description>HIGHEST</description></item>
                /// <item><description>HIGH</description></item>
                /// <item><description>MIDDLE</description></item>
                /// <item><description>LOW</description></item>
                /// <item><description>LOWEST</description></item>
                /// </list>
                /// </summary>
                [NameInMap("PriorityList")]
                [Validation(Required=false)]
                public List<string> PriorityList { get; set; }

                /// <summary>
                /// <para>Resource group list</para>
                /// </summary>
                [NameInMap("ResourceGroupList")]
                [Validation(Required=false)]
                public List<string> ResourceGroupList { get; set; }

                /// <summary>
                /// <para>Indicates whether scheduling is paused.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SchedulePaused")]
                [Validation(Required=false)]
                public bool? SchedulePaused { get; set; }

                /// <summary>
                /// <para>Scheduling period</para>
                /// <list type="bullet">
                /// <item><description>YEARLY</description></item>
                /// <item><description>MONTHLY</description></item>
                /// <item><description>WEEKLY</description></item>
                /// <item><description>DAILY</description></item>
                /// <item><description>HOURLY</description></item>
                /// <item><description>MINUTELY</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SchedulePeriodList")]
                [Validation(Required=false)]
                public List<string> SchedulePeriodList { get; set; }

                /// <summary>
                /// <para>Sub-business type</para>
                /// <list type="bullet">
                /// <item><description>MAX_COMPUTE_SQL</description></item>
                /// <item><description>HIVE_SQL</description></item>
                /// <item><description>SHELL</description></item>
                /// <item><description>PYTHON</description></item>
                /// <item><description>ONE_SERVICE_SQL</description></item>
                /// <item><description>DATABASE_SQL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SHELL</para>
                /// </summary>
                [NameInMap("SubDetailType")]
                [Validation(Required=false)]
                public string SubDetailType { get; set; }

                /// <summary>
                /// <para>Node type</para>
                /// <list type="bullet">
                /// <item><description>BBOX_LOGIC_TABLE_NODE: Logical table node</description></item>
                /// <item><description>BBOX_LOGIC_FIELD_NODE: Logical field node</description></item>
                /// <item><description>BBOX_LOGIC_FIELD_GROUP_NODE: Field group node</description></item>
                /// <item><description>BBOX_INNER_TEMP_NODE: Logical table temp node</description></item>
                /// <item><description>DATA_PROCESS: Code task</description></item>
                /// <item><description>STREAM_TASK_NODE: Real-time task</description></item>
                /// <item><description>PIPELINE_NODE: Pipeline node</description></item>
                /// <item><description>FLINK_BATCH: Flink batch task</description></item>
                /// <item><description>ODM_NODE: ODM node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Start execution time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-27 01:30:00</para>
            /// </summary>
            [NameInMap("StartExecuteTime")]
            [Validation(Required=false)]
            public long? StartExecuteTime { get; set; }

            /// <summary>
            /// <para>Status list</para>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

        }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
