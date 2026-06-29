// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Request error code. OK indicates a normal request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Backend response HTTP code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Request error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Paginated result</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyPageResult PageResult { get; set; }
        public class ListInstancesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>Paginated records</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyPageResultData> Data { get; set; }
            public class ListInstancesResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>Business Date</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <para>Schedule Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 16:47:13</para>
                /// </summary>
                [NameInMap("DueTime")]
                [Validation(Required=false)]
                public string DueTime { get; set; }

                /// <summary>
                /// <para>Running duration, in seconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>60s</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>Execution End Time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 16:47:13</para>
                /// </summary>
                [NameInMap("EndExecuteTime")]
                [Validation(Required=false)]
                public long? EndExecuteTime { get; set; }

                /// <summary>
                /// <para>Node extended information: specific information for instances from different business systems, such as pipeline fileId, whether the logical table has hierarchical dimensions, mid node information, and instance output name</para>
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
                /// <para>Hourly/Minutely instance sequence number</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>Node Details</para>
                /// </summary>
                [NameInMap("NodeInfo")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyPageResultDataNodeInfo NodeInfo { get; set; }
                public class ListInstancesResponseBodyPageResultDataNodeInfo : TeaModel {
                    /// <summary>
                    /// <para>Business Unit</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <para>Creation Time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-30 16:47:13</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>Node Creator</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public ListInstancesResponseBodyPageResultDataNodeInfoCreator Creator { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoCreator : TeaModel {
                        /// <summary>
                        /// <para>User ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>Username</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx测试</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>Node Description</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx 测试</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Whether to dry run</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DryRun")]
                    [Validation(Required=false)]
                    public bool? DryRun { get; set; }

                    /// <summary>
                    /// <para>Node Source</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DATA_PROCES</para>
                    /// </summary>
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public string From { get; set; }

                    /// <summary>
                    /// <para>Whether a development environment exists</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasDev")]
                    [Validation(Required=false)]
                    public bool? HasDev { get; set; }

                    /// <summary>
                    /// <para>Whether a production environment exists</para>
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
                    /// <para>n_132331</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Last Modified Time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-30 16:47:13</para>
                    /// </summary>
                    [NameInMap("LastModifiedTime")]
                    [Validation(Required=false)]
                    public string LastModifiedTime { get; set; }

                    /// <summary>
                    /// <para>Modifier</para>
                    /// </summary>
                    [NameInMap("Modifier")]
                    [Validation(Required=false)]
                    public ListInstancesResponseBodyPageResultDataNodeInfoModifier Modifier { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoModifier : TeaModel {
                        /// <summary>
                        /// <para>Username</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>Username</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx测试</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>Node Name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Owner</para>
                    /// </summary>
                    [NameInMap("OwnerList")]
                    [Validation(Required=false)]
                    public List<ListInstancesResponseBodyPageResultDataNodeInfoOwnerList> OwnerList { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoOwnerList : TeaModel {
                        /// <summary>
                        /// <para>User ID</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>Username</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx测试</para>
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
                    /// <para>Running Resource Group</para>
                    /// </summary>
                    [NameInMap("ResourceGroupList")]
                    [Validation(Required=false)]
                    public List<string> ResourceGroupList { get; set; }

                    /// <summary>
                    /// <para>Whether scheduling is paused</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SchedulePaused")]
                    [Validation(Required=false)]
                    public bool? SchedulePaused { get; set; }

                    /// <summary>
                    /// <para>Schedule Period</para>
                    /// </summary>
                    [NameInMap("SchedulePeriodList")]
                    [Validation(Required=false)]
                    public List<string> SchedulePeriodList { get; set; }

                    /// <summary>
                    /// <para>Sub-business Type</para>
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
                    /// <para>Node Business Type</para>
                    /// <list type="bullet">
                    /// <item><description>SCRIPT: Script</description></item>
                    /// <item><description>LOGICAL_TABLE: Logical Table</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DATA_PROCES</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Execution start time</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 16:46:13</para>
                /// </summary>
                [NameInMap("StartExecuteTime")]
                [Validation(Required=false)]
                public long? StartExecuteTime { get; set; }

                /// <summary>
                /// <para>Instance Status</para>
                /// </summary>
                [NameInMap("StatusList")]
                [Validation(Required=false)]
                public List<string> StatusList { get; set; }

            }

            /// <summary>
            /// <para>Total number of records</para>
            /// 
            /// <b>Example:</b>
            /// <para>107</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
        /// <para>Whether the request was successful</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
