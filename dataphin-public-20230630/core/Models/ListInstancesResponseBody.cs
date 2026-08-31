// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paginated result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyPageResult PageResult { get; set; }
        public class ListInstancesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paginated records.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyPageResultData> Data { get; set; }
            public class ListInstancesResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>The business date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <para>The scheduling time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 16:47:13</para>
                /// </summary>
                [NameInMap("DueTime")]
                [Validation(Required=false)]
                public string DueTime { get; set; }

                /// <summary>
                /// <para>The execution duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60s</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// <para>The execution end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 16:47:13</para>
                /// </summary>
                [NameInMap("EndExecuteTime")]
                [Validation(Required=false)]
                public long? EndExecuteTime { get; set; }

                /// <summary>
                /// <para>The extended node information, which contains properties specific to different business system instances, such as the fileId of a pipeline, whether a logical table uses hierarchy dimensions, mid node information, and instance output names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public string ExtendInfo { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_23231</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The sequence number of the hourly or minutely instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                /// <summary>
                /// <para>The node details.</para>
                /// </summary>
                [NameInMap("NodeInfo")]
                [Validation(Required=false)]
                public ListInstancesResponseBodyPageResultDataNodeInfo NodeInfo { get; set; }
                public class ListInstancesResponseBodyPageResultDataNodeInfo : TeaModel {
                    /// <summary>
                    /// <para>The business unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx_test</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-30 16:47:13</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <para>The creator of the node.</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public ListInstancesResponseBodyPageResultDataNodeInfoCreator Creator { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoCreator : TeaModel {
                        /// <summary>
                        /// <para>The user ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx_test</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The description of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx test</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the node is a dry run.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DryRun")]
                    [Validation(Required=false)]
                    public bool? DryRun { get; set; }

                    /// <summary>
                    /// <para>The source of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DATA_PROCES</para>
                    /// </summary>
                    [NameInMap("From")]
                    [Validation(Required=false)]
                    public string From { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the node has a development environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("HasDev")]
                    [Validation(Required=false)]
                    public bool? HasDev { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the node has a production environment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasProd")]
                    [Validation(Required=false)]
                    public bool? HasProd { get; set; }

                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>n_132331</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The modification time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-05-30 16:47:13</para>
                    /// </summary>
                    [NameInMap("LastModifiedTime")]
                    [Validation(Required=false)]
                    public string LastModifiedTime { get; set; }

                    /// <summary>
                    /// <para>The modifier of the node.</para>
                    /// </summary>
                    [NameInMap("Modifier")]
                    [Validation(Required=false)]
                    public ListInstancesResponseBodyPageResultDataNodeInfoModifier Modifier { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoModifier : TeaModel {
                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx_test</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx_test</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The owner.</para>
                    /// </summary>
                    [NameInMap("OwnerList")]
                    [Validation(Required=false)]
                    public List<ListInstancesResponseBodyPageResultDataNodeInfoOwnerList> OwnerList { get; set; }
                    public class ListInstancesResponseBodyPageResultDataNodeInfoOwnerList : TeaModel {
                        /// <summary>
                        /// <para>The user ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>21313112</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The username.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx_test</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The priority. Valid values:</para>
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
                    /// <para>The schedule resource groups for execution.</para>
                    /// </summary>
                    [NameInMap("ResourceGroupList")]
                    [Validation(Required=false)]
                    public List<string> ResourceGroupList { get; set; }

                    /// <summary>
                    /// <para>Specifies whether scheduling is paused.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("SchedulePaused")]
                    [Validation(Required=false)]
                    public bool? SchedulePaused { get; set; }

                    /// <summary>
                    /// <para>The scheduling period.</para>
                    /// </summary>
                    [NameInMap("SchedulePeriodList")]
                    [Validation(Required=false)]
                    public List<string> SchedulePeriodList { get; set; }

                    /// <summary>
                    /// <para>The sub-business type. Valid values:</para>
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
                    /// <para>The business type of the node. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>SCRIPT: script.</description></item>
                    /// <item><description>LOGICAL_TABLE: logical table.</description></item>
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
                /// <para>The execution start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 16:46:13</para>
                /// </summary>
                [NameInMap("StartExecuteTime")]
                [Validation(Required=false)]
                public long? StartExecuteTime { get; set; }

                /// <summary>
                /// <para>The instance status.</para>
                /// </summary>
                [NameInMap("StatusList")]
                [Validation(Required=false)]
                public List<string> StatusList { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>107</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
