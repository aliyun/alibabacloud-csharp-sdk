// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListWorkflowExecutionsRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-13 16:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for this request. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that specifies the position from which the query starts. An empty value indicates that all data has been read. You do not need to specify this parameter for the first query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eCKqVlS5FKF5EWGGOo8EgQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-27 02:15:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The workflow execution status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: unknown</description></item>
        /// <item><description>1: waiting</description></item>
        /// <item><description>2: queued</description></item>
        /// <item><description>3: running</description></item>
        /// <item><description>4: success</description></item>
        /// <item><description>5: failed</description></item>
        /// <item><description>6: killed</description></item>
        /// <item><description>7: held</description></item>
        /// <item><description>8: mark_success</description></item>
        /// <item><description>9: skipped</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The workflow instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("WorkflowExecutionId")]
        [Validation(Required=false)]
        public long? WorkflowExecutionId { get; set; }

        /// <summary>
        /// <para>The workflow ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("WorkflowId")]
        [Validation(Required=false)]
        public long? WorkflowId { get; set; }

        /// <summary>
        /// <para>The workflow name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myWorkflow</para>
        /// </summary>
        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

    }

}
