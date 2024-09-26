// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesByOutputResponseBody : TeaModel {
        /// <summary>
        /// <para>The nodes returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNodesByOutputResponseBodyData> Data { get; set; }
        public class ListNodesByOutputResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the nodes returned.</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<ListNodesByOutputResponseBodyDataNodeList> NodeList { get; set; }
            public class ListNodesByOutputResponseBodyDataNodeList : TeaModel {
                /// <summary>
                /// <para>The baseline ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1235667</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps_first</para>
                /// </summary>
                [NameInMap("Connection")]
                [Validation(Required=false)]
                public string Connection { get; set; }

                /// <summary>
                /// <para>The CRON expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00 00 00 * * ?</para>
                /// </summary>
                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                /// <summary>
                /// <para>The description of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The table and partition filter expression in Data Quality that are associated with the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;projectName&quot;:&quot;ztjy_dim&quot;,&quot;tableName&quot;:&quot;dim_user_agent_manage_area_a&quot;,&quot;partition&quot;:&quot;ds\u003d$[yyyy-mm-dd-1]&quot;}]</para>
                /// </summary>
                [NameInMap("DqcDescription")]
                [Validation(Required=false)]
                public string DqcDescription { get; set; }

                /// <summary>
                /// <para>Indicates whether the node is associated with a monitoring rule in Data Quality. Valid values: 0 and 1. The value 0 indicates that the node is associated with a monitoring rule in Data Quality. The value 1 indicates that the node is not associated with a monitoring rule in Data Quality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DqcType")]
                [Validation(Required=false)]
                public int? DqcType { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <para>6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3)</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("FileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>125677</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liux_test_n****</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The owner ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19337906836551</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <para>The scheduling parameters of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a=b</para>
                /// </summary>
                [NameInMap("ParamValues")]
                [Validation(Required=false)]
                public string ParamValues { get; set; }

                /// <summary>
                /// <para>The priority of the node. Valid values: 1, 3, 5, 7, and 8. A greater value indicates a higher priority. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The node type. This parameter is deprecated. For more information about node types, see valid values of the FileType parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS_SQL</para>
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public string ProgramType { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33671</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The ID of the workflow to which the node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1235655464</para>
                /// </summary>
                [NameInMap("RelatedFlowId")]
                [Validation(Required=false)]
                public long? RelatedFlowId { get; set; }

                /// <summary>
                /// <para>The interval at which the node is rerun after the node fails to run.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("RepeatInterval")]
                [Validation(Required=false)]
                public int? RepeatInterval { get; set; }

                /// <summary>
                /// <para>Indicates whether the node can be rerun.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Repeatability")]
                [Validation(Required=false)]
                public bool? Repeatability { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// </summary>
                [NameInMap("ResGroupName")]
                [Validation(Required=false)]
                public string ResGroupName { get; set; }

                /// <summary>
                /// <para>The scheduling type of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: The node is an auto triggered node. The scheduling system regularly runs the node.</description></item>
                /// <item><description>MANUAL: The node is a manually triggered node. The scheduling system does not regularly run the node.</description></item>
                /// <item><description>PAUSE: The node is a frozen node. The scheduling system regularly runs the node but sets the status of the node to failed when the scheduling system starts to run the node.</description></item>
                /// <item><description>SKIP: The node is a dry-run node. The scheduling system regularly runs the node but sets the status of the node to successful when the scheduling system starts to run the node.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

            }

            /// <summary>
            /// <para>The output name of the current node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_0709_1.630003556_out</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SDFSDFSDF-asdfDFSDF-SDFSDf-SDfSFD</para>
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
