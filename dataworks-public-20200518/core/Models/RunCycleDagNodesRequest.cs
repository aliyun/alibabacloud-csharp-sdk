// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunCycleDagNodesRequest : TeaModel {
        /// <summary>
        /// <para>The alert notification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SMS: Text message.</description></item>
        /// <item><description>MAIL: Email.</description></item>
        /// <item><description>SMS_MAIL: Text message and email.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SMS</para>
        /// </summary>
        [NameInMap("AlertNoticeType")]
        [Validation(Required=false)]
        public string AlertNoticeType { get; set; }

        /// <summary>
        /// <para>The alert type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUCCESS: Alerts on success.</description></item>
        /// <item><description>FAILURE: Alerts on failure.</description></item>
        /// <item><description>SUCCESS_FAILURE: Alerts on both success and failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAILURE</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The start time of the task. This parameter is required only for tasks scheduled by hour. Specify the time in the HH:mm:ss format. Valid values: 00:00:00 to 23:59:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("BizBeginTime")]
        [Validation(Required=false)]
        public string BizBeginTime { get; set; }

        /// <summary>
        /// <para>The end time of the task. This parameter is required only for tasks scheduled by hour. Specify the time in the HH:mm:ss format. Valid values: 00:00:00 to 23:59:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01:00:00</para>
        /// </summary>
        [NameInMap("BizEndTime")]
        [Validation(Required=false)]
        public string BizEndTime { get; set; }

        /// <summary>
        /// <para>The number of tasks that can run in parallel. Valid values: 2 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ConcurrentRuns")]
        [Validation(Required=false)]
        public int? ConcurrentRuns { get; set; }

        /// <summary>
        /// <para>The end business date for data backfill. Specify the time in the yyyy-MM-dd 00:00:00 format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-21 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizDate")]
        [Validation(Required=false)]
        public string EndBizDate { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes that do not require data backfill. Dry-run instances are generated for the nodes in this list. After a dry-run instance is scheduled, it directly succeeds without executing the script content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234,123465</para>
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes for data backfill. If you backfill data for multiple nodes, separate the node IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to obtain the node IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74324,74325</para>
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// <para>The name of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xm_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The node parameters configured as a JSON string. The key is the node ID, and the value is the actual value of the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;74324&quot;:&quot;a=123 b=456&quot;}</para>
        /// </summary>
        [NameInMap("NodeParams")]
        [Validation(Required=false)]
        public string NodeParams { get; set; }

        /// <summary>
        /// <para>Specifies whether tasks for multiple business dates can run in parallel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public bool? Parallelism { get; set; }

        /// <summary>
        /// <para>The workspace environment. Valid values: PROD for the production environment and DEV for the development environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The ID of the start node for data backfill. You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to obtain the node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("RootNodeId")]
        [Validation(Required=false)]
        public long? RootNodeId { get; set; }

        /// <summary>
        /// <para>The start business date for data backfill. Specify the time in the yyyy-MM-dd 00:00:00 format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-20 00:00:00</para>
        /// </summary>
        [NameInMap("StartBizDate")]
        [Validation(Required=false)]
        public string StartBizDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately run instances whose scheduled time is later than the current time. If this parameter is set to true, these instances run immediately. Otherwise, they wait until their scheduled time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StartFutureInstanceImmediately")]
        [Validation(Required=false)]
        public bool? StartFutureInstanceImmediately { get; set; }

    }

}
