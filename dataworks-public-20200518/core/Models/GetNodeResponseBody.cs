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
            /// <para>The description of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// <para>The operation that you want to perform. Set the value to <b>GetNode</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public long? BusinessId { get; set; }

            /// <summary>
            /// <para>The environment of the workspace. Valid values: PROD and DEV.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps_first_dev</para>
            /// </summary>
            [NameInMap("Connection")]
            [Validation(Required=false)]
            public string Connection { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The environment of the workspace. Valid values: PROD and DEV.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00 00 00 * * ?</para>
            /// </summary>
            [NameInMap("CronExpress")]
            [Validation(Required=false)]
            public string CronExpress { get; set; }

            [NameInMap("DeployDate")]
            [Validation(Required=false)]
            public long? DeployDate { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the node. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to query the node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;projectName&quot;:&quot;test_0923001&quot;,&quot;tableName&quot;:&quot;test_table_001&quot;,&quot;partition&quot;:&quot;ds\u003d$[yyyymmdd]&quot;},{&quot;projectName&quot;:&quot;test_0923001&quot;,&quot;tableName&quot;:&quot;test_table_002&quot;,&quot;partition&quot;:&quot;NOTAPARTITIONTABLE&quot;}]</para>
            /// </summary>
            [NameInMap("DqcDescription")]
            [Validation(Required=false)]
            public string DqcDescription { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DqcType")]
            [Validation(Required=false)]
            public int? DqcType { get; set; }

            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public int? FileType { get; set; }

            [NameInMap("FileVersion")]
            [Validation(Required=false)]
            public int? FileVersion { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The HTTP status code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The scheduling type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NORMAL: The node is an auto triggered node.</description></item>
            /// <item><description>MANUAL: The node is a manually triggered node. Manually triggered nodes cannot be automatically triggered.</description></item>
            /// <item><description>PAUSE: The node is a paused node.</description></item>
            /// <item><description>SKIP: The node is a dry-run node. Dry-run nodes are started as scheduled but the system sets the status of the nodes to successful when it starts to run them.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>The ID of the baseline.</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17366294****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>The CRON expression returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a=b</para>
            /// </summary>
            [NameInMap("ParamValues")]
            [Validation(Required=false)]
            public string ParamValues { get; set; }

            /// <summary>
            /// <para>The HTTP status code returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ODPS_SQL</para>
            /// </summary>
            [NameInMap("ProgramType")]
            [Validation(Required=false)]
            public string ProgramType { get; set; }

            /// <summary>
            /// <para>Indicates whether the node can be rerun.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is associated with Data Quality. Valid values: 0 and 1. A value of 0 indicates that the node is associated with Data Quality. A value of 1 indicates that the node is not associated with Data Quality.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("RelatedFlowId")]
            [Validation(Required=false)]
            public long? RelatedFlowId { get; set; }

            /// <summary>
            /// <para>The ID of the workflow to which the node belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("RepeatInterval")]
            [Validation(Required=false)]
            public long? RepeatInterval { get; set; }

            [NameInMap("RepeatMode")]
            [Validation(Required=false)]
            public int? RepeatMode { get; set; }

            /// <summary>
            /// <para>The type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Repeatability")]
            [Validation(Required=false)]
            public string Repeatability { get; set; }

            [NameInMap("ResGroupIdentifier")]
            [Validation(Required=false)]
            public string ResGroupIdentifier { get; set; }

            /// <summary>
            /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The table and partition filter expression in Data Quality that are associated with the node.</para>
            /// </summary>
            [NameInMap("ResGroupName")]
            [Validation(Required=false)]
            public string ResGroupName { get; set; }

            /// <summary>
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("SchedulerType")]
            [Validation(Required=false)]
            public string SchedulerType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the node. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to query the node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The connection string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>GetNode</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Other parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
