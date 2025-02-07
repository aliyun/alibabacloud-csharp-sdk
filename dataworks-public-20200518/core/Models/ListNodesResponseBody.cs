// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The nodes.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNodesResponseBodyData Data { get; set; }
        public class ListNodesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<ListNodesResponseBodyDataNodes> Nodes { get; set; }
            public class ListNodesResponseBodyDataNodes : TeaModel {
                /// <summary>
                /// <para>The number of the page to return. Minimum value: 1. Maximum value: 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The operation that you want to perform. Set the value to <b>ListNodes</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// <para>The timestamp when the node was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00 00 00 * * ?</para>
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// <para>The timestamp when the node was deployed. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1734537600000</para>
                /// </summary>
                [NameInMap("DeployDate")]
                [Validation(Required=false)]
                public long? DeployDate { get; set; }

                /// <summary>
                /// <para>The priority for running the node. Valid values: 1, 3, 5, 7, and 8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;projectName&quot;:&quot;ztjy_dim&quot;,&quot;tableName&quot;:&quot;dim_user_agent_manage_area_a&quot;,&quot;partition&quot;:&quot;ds\u003d$[yyyy-mm-dd-1]&quot;}]</para>
                /// </summary>
                [NameInMap("DqcDescription")]
                [Validation(Required=false)]
                public string DqcDescription { get; set; }

                /// <summary>
                /// <para>The connection string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DqcType")]
                [Validation(Required=false)]
                public int? DqcType { get; set; }

                /// <summary>
                /// <para>The file ID. You can call the ListFiles operation to query the ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public long? FileId { get; set; }

                /// <summary>
                /// <para>Different file types have different codes. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks node collection</a>.
                /// You can also call the <a href="https://help.aliyun.com/document_detail/212428.html">ListFileType</a> interface to query the code type of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                /// <summary>
                /// <para>The latest version number of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public int? FileVersion { get; set; }

                /// <summary>
                /// <para>The timestamp when the node was modified. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593879116000</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                /// <summary>
                /// <para>The types of the nodes. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to query the type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The total number of nodes returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liux_test_n****</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The additional parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19337906836551</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a=b</para>
                /// </summary>
                [NameInMap("ParamValues")]
                [Validation(Required=false)]
                public string ParamValues { get; set; }

                /// <summary>
                /// <para>The ID of the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public string ProgramType { get; set; }

                /// <summary>
                /// <para>The information about the nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33671</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The table and partition filter expression in Data Quality that are associated with the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231123</para>
                /// </summary>
                [NameInMap("RelatedFlowId")]
                [Validation(Required=false)]
                public long? RelatedFlowId { get; set; }

                /// <summary>
                /// <para>The environment of the workspace. Valid values: PROD and DEV.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public long? RepeatInterval { get; set; }

                /// <summary>
                /// <para>The rerun mode. The value 0 indicates that rerun can be performed only if a failure occurs. The value 1 indicates that rerun can be performed in all cases. The value 2 indicates that rerun cannot be performed in all cases.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RepeatMode")]
                [Validation(Required=false)]
                public int? RepeatMode { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Repeatability")]
                [Validation(Required=false)]
                public bool? Repeatability { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group_123</para>
                /// </summary>
                [NameInMap("ResGroupIdentifier")]
                [Validation(Required=false)]
                public string ResGroupIdentifier { get; set; }

                /// <summary>
                /// <para>The ID of the workflow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The ID of the request. You can use the ID to query logs and troubleshoot issues.</para>
                /// </summary>
                [NameInMap("ResGroupName")]
                [Validation(Required=false)]
                public string ResGroupName { get; set; }

                /// <summary>
                /// <para>The types of the nodes. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to query the type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

            }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The cron expression returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The name of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The interval at which the node is rerun after the node fails to run.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the node can be rerun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
