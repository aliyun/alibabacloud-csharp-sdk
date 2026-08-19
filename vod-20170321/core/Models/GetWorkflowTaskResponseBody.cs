// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetWorkflowTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned when transcoding fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when transcoding fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ErrorMessage</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The time when the task was completed. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-08-19T02:28:22Z</para>
        /// </summary>
        [NameInMap("FinishTimeUtc")]
        [Validation(Required=false)]
        public string FinishTimeUtc { get; set; }

        /// <summary>
        /// <para>The time when the task was created. The time is in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-28T02:17:26Z</para>
        /// </summary>
        [NameInMap("GmtCreateUtc")]
        [Validation(Required=false)]
        public string GmtCreateUtc { get; set; }

        /// <summary>
        /// <para>The node results of the workflow task. The value is in JSON format and varies based on the workflow configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("NodeResults")]
        [Validation(Required=false)]
        public string NodeResults { get; set; }

        /// <summary>
        /// <para>The output information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>63E8B7C7-4812-46*****AD-0FA56029AC86</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of this review. This indicates the current manual review result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>running</b>: Running.</description></item>
        /// <item><description><b>stopped</b>: Stopped.</description></item>
        /// <item><description><b>failed</b>: Failed.</description></item>
        /// <item><description><b>partial-succeeded</b>: Partially succeeded.</description></item>
        /// <item><description><b>succeeded</b>: Succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>succeeded</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID used to query the refresh status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70422****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The custom information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The workflow ID. You can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Workflow Management</b> to view the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>613efff3887ec34af685714cc461****</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public string WorkflowId { get; set; }

    }

}
