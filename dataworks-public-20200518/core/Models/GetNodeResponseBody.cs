// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the node.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNodeResponseBodyData Data { get; set; }
        public class GetNodeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The baseline ID. The baseline ID configured for the node as a leaf node is returned. If no baseline is configured, a workspace default value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// <para>The ID of the workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public long? BusinessId { get; set; }

            /// <summary>
            /// <para>The connection string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps_source_dev</para>
            /// </summary>
            [NameInMap("Connection")]
            [Validation(Required=false)]
            public string Connection { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <para>The value is a 13-digit number, such as <c>1727280000000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727280000000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            /// <para>The deployment date.</para>
            /// <para>The value is a 13-digit number, such as <c>1727280000000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727280000000</para>
            /// </summary>
            [NameInMap("DeployDate")]
            [Validation(Required=false)]
            public long? DeployDate { get; set; }

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
            /// <para>The DQC partitioning rule string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;projectName&quot;:&quot;test_0923001&quot;,&quot;tableName&quot;:&quot;test_table_001&quot;,&quot;partition&quot;:&quot;ds\u003d$[yyyymmdd]&quot;},{&quot;projectName&quot;:&quot;test_0923001&quot;,&quot;tableName&quot;:&quot;test_table_002&quot;,&quot;partition&quot;:&quot;NOTAPARTITIONTABLE&quot;}]</para>
            /// </summary>
            [NameInMap("DqcDescription")]
            [Validation(Required=false)]
            public string DqcDescription { get; set; }

            /// <summary>
            /// <para>The DQC type. A value of 0 indicates that no DQC rule is associated. A value of 1 indicates that a DQC rule is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DqcType")]
            [Validation(Required=false)]
            public int? DqcType { get; set; }

            /// <summary>
            /// <para>The file ID. <warning>This field is deprecated.</warning></para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// <para>The file type. Different file types have different codes. For more information, see <a href="https://help.aliyun.com/document_detail/600169.html">DataWorks nodes</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FileType")]
            [Validation(Required=false)]
            public int? FileType { get; set; }

            /// <summary>
            /// <para>The file version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FileVersion")]
            [Validation(Required=false)]
            public int? FileVersion { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// <para>The value is a 13-digit number, such as <c>1727280000000</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1727280000000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sql_node</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The ID of the node owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17366294****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The additional parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a=b</para>
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// <para>The priority of the node. Valid values: 1, 3, 5, 7, and 8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The ID of the associated workflow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("RelatedFlowId")]
            [Validation(Required=false)]
            public long? RelatedFlowId { get; set; }

            /// <summary>
            /// <para>The interval at which the node is rescheduled after a failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RepeatInterval")]
            [Validation(Required=false)]
            public long? RepeatInterval { get; set; }

            /// <summary>
            /// <para>The rerun mode. A value of 0 indicates that the node can be rerun only upon failure. A value of 1 indicates that the node can be rerun in all cases. A value of 2 indicates that the node cannot be rerun in any case.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatMode")]
            [Validation(Required=false)]
            public int? RepeatMode { get; set; }

            /// <summary>
            /// <para>Indicates whether the node can be rerun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Repeatability")]
            [Validation(Required=false)]
            public string Repeatability { get; set; }

            /// <summary>
            /// <para>The unique identifier of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group_123</para>
            /// </summary>
            [NameInMap("ResGroupIdentifier")]
            [Validation(Required=false)]
            public string ResGroupIdentifier { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default Resource Group</para>
            /// </summary>
            [NameInMap("ResGroupName")]
            [Validation(Required=false)]
            public string ResGroupName { get; set; }

            /// <summary>
            /// <para>The scheduling type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: normal scheduling node.</description></item>
            /// <item><description>MANUAL: manual node that is not scheduled on a regular basis.</description></item>
            /// <item><description>PAUSE: paused node.</description></item>
            /// <item><description>SKIP: dry-run node that is scheduled on a regular basis but is directly set to successful when scheduling starts.</description></item>
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
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
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
