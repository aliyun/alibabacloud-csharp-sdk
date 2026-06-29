// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListNodesResponseBody : TeaModel {
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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paging query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListNodesResponseBodyPageResult PageResult { get; set; }
        public class ListNodesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of nodes on the current page.</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyPageResultNodeList> NodeList { get; set; }
            public class ListNodesResponseBodyPageResultNodeList : TeaModel {
                /// <summary>
                /// <para>The name of the business unit to which the node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
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
                /// <para>The creator.</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPageResultNodeListCreator Creator { get; set; }
                public class ListNodesResponseBodyPageResultNodeListCreator : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23222</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies whether to perform a dry run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>The extended information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;xx&quot;:&quot;zz&quot;}</para>
                /// </summary>
                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public string ExtendInfo { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <para>Indicates whether a development environment exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasDev")]
                [Validation(Required=false)]
                public bool? HasDev { get; set; }

                /// <summary>
                /// <para>Indicates whether a production environment exists.</para>
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
                /// <para>n_31111</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The last modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-30 16:47:13</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                /// <summary>
                /// <para>The user who last modified the node.</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPageResultNodeListModifier Modifier { get; set; }
                public class ListNodesResponseBodyPageResultNodeListModifier : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>311131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner.</para>
                /// </summary>
                [NameInMap("OwnerList")]
                [Validation(Required=false)]
                public List<ListNodesResponseBodyPageResultNodeListOwnerList> OwnerList { get; set; }
                public class ListNodesResponseBodyPageResultNodeListOwnerList : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23222</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The priority.</para>
                /// </summary>
                [NameInMap("PriorityList")]
                [Validation(Required=false)]
                public List<string> PriorityList { get; set; }

                /// <summary>
                /// <para>The project to which the node belongs.</para>
                /// </summary>
                [NameInMap("ProjectInfo")]
                [Validation(Required=false)]
                public ListNodesResponseBodyPageResultNodeListProjectInfo ProjectInfo { get; set; }
                public class ListNodesResponseBodyPageResultNodeListProjectInfo : TeaModel {
                    /// <summary>
                    /// <para>The project ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1121321</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The project name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether scheduling is paused.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <para>The sub-business types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MAX_COMPUTE_SQL</description></item>
                /// <item><description>HIVE_SQL</description></item>
                /// <item><description>SHELL</description></item>
                /// <item><description>PYTHON</description></item>
                /// <item><description>ONE_SERVICE_SQL</description></item>
                /// <item><description>DATABASE_SQL.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SHELL</para>
                /// </summary>
                [NameInMap("SubDetailType")]
                [Validation(Required=false)]
                public string SubDetailType { get; set; }

                /// <summary>
                /// <para>The node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
