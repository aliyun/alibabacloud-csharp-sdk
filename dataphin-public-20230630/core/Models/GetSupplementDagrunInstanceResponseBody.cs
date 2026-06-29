// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSupplementDagrunInstanceResponseBody : TeaModel {
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
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<GetSupplementDagrunInstanceResponseBodyInstanceList> InstanceList { get; set; }
        public class GetSupplementDagrunInstanceResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The business date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-01</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public long? BizDate { get; set; }

            /// <summary>
            /// <para>The scheduled date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-02</para>
            /// </summary>
            [NameInMap("DueTime")]
            [Validation(Required=false)]
            public long? DueTime { get; set; }

            /// <summary>
            /// <para>The execution duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The end time of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-12 00:25:02</para>
            /// </summary>
            [NameInMap("EndExecuteTime")]
            [Validation(Required=false)]
            public long? EndExecuteTime { get; set; }

            /// <summary>
            /// <para>The extended information. This field contains information specific to instances of different business systems, such as the fileId of a pipeline, whether a logical table is a hierarchy dimension table, mid-node information, and instance output names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;a&quot;:&quot;b&quot;}</para>
            /// </summary>
            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_239496_20210411_246982077481</para>
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
            /// <para>The details of the node associated with the instance.</para>
            /// </summary>
            [NameInMap("NodeInfo")]
            [Validation(Required=false)]
            public GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfo NodeInfo { get; set; }
            public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfo : TeaModel {
                /// <summary>
                /// <para>The business unit.</para>
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
                /// <para>2024-01-30 10:08:49</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator of the node.</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoCreator Creator { get; set; }
                public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoCreator : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1001012</para>
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
                /// <para>The node description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the node is a dry run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DryRun")]
                [Validation(Required=false)]
                public bool? DryRun { get; set; }

                /// <summary>
                /// <para>The source business system. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: code development.</description></item>
                /// <item><description>BLACK_BOX: black box.</description></item>
                /// <item><description>ONE_ID: extraction.</description></item>
                /// <item><description>PIPELINE: pipeline.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DATA_PROCESS</para>
                /// </summary>
                [NameInMap("From")]
                [Validation(Required=false)]
                public string From { get; set; }

                /// <summary>
                /// <para>Indicates whether the node exists in the development environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasDev")]
                [Validation(Required=false)]
                public bool? HasDev { get; set; }

                /// <summary>
                /// <para>Indicates whether the node exists in the production environment.</para>
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
                /// <para>n_239496</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The last modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-30 10:08:49</para>
                /// </summary>
                [NameInMap("LastModifiedTime")]
                [Validation(Required=false)]
                public string LastModifiedTime { get; set; }

                /// <summary>
                /// <para>The modifier.</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoModifier Modifier { get; set; }
                public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoModifier : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1001012</para>
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
                /// <para>The owners of the node.</para>
                /// </summary>
                [NameInMap("OwnerList")]
                [Validation(Required=false)]
                public List<GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoOwnerList> OwnerList { get; set; }
                public class GetSupplementDagrunInstanceResponseBodyInstanceListNodeInfoOwnerList : TeaModel {
                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1001012</para>
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
                /// <para>The priority. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HIGHEST</description></item>
                /// <item><description>HIGH</description></item>
                /// <item><description>MIDDLE</description></item>
                /// <item><description>LOW</description></item>
                /// <item><description>LOWEST.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("PriorityList")]
                [Validation(Required=false)]
                public List<string> PriorityList { get; set; }

                /// <summary>
                /// <para>The schedule resource groups.</para>
                /// </summary>
                [NameInMap("ResourceGroupList")]
                [Validation(Required=false)]
                public List<string> ResourceGroupList { get; set; }

                /// <summary>
                /// <para>Indicates whether the node is paused.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SchedulePaused")]
                [Validation(Required=false)]
                public bool? SchedulePaused { get; set; }

                /// <summary>
                /// <para>The scheduling period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MINUTELY</description></item>
                /// <item><description>HOURLY</description></item>
                /// <item><description>DAILY</description></item>
                /// <item><description>WEEKLY</description></item>
                /// <item><description>MONTHLY</description></item>
                /// <item><description>QUARTERLY.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("SchedulePeriodList")]
                [Validation(Required=false)]
                public List<string> SchedulePeriodList { get; set; }

                /// <summary>
                /// <para>The node subtype.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHELL</para>
                /// </summary>
                [NameInMap("SubDetailType")]
                [Validation(Required=false)]
                public string SubDetailType { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DATA_PROCESS: code node.</description></item>
                /// <item><description>BBOX_LOGIC_TABLE_NODE: black box logical table node.</description></item>
                /// <item><description>ONE_ID_LABEL: extraction label node.</description></item>
                /// <item><description>ONE_ID_RULE: extraction label node.</description></item>
                /// <item><description>PIPELINE_NODE: pipeline node.</description></item>
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
            /// <para>The start time of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-12 00:00:00</para>
            /// </summary>
            [NameInMap("StartExecuteTime")]
            [Validation(Required=false)]
            public long? StartExecuteTime { get; set; }

            /// <summary>
            /// <para>The list of instance statuses. A physical instance list contains only one status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NIT: init.</description></item>
            /// <item><description>WATING: waiting.</description></item>
            /// <item><description>RUNNING: running.</description></item>
            /// <item><description>SUCCESS: succeeded.</description></item>
            /// <item><description>FAILED: failed.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("StatusList")]
            [Validation(Required=false)]
            public List<string> StatusList { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: periodic instance.</description></item>
            /// <item><description>SUPPLEMENT: data backfill instance.</description></item>
            /// <item><description>MANUAL: manual instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUPPLEMENT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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
