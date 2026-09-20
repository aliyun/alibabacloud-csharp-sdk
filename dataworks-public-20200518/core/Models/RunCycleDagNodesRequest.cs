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
        /// <item><description>SMS: text message.</description></item>
        /// <item><description>MAIL: email.</description></item>
        /// <item><description>SMS_MAIL: text message and email.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SMS</para>
        /// </summary>
        [NameInMap("AlertNoticeType")]
        [Validation(Required=false)]
        public string AlertNoticeType { get; set; }

        /// <summary>
        /// <para>The Alarm Metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SUCCESS: Alerting on success.</description></item>
        /// <item><description>FAILURE: Alerting on failed.</description></item>
        /// <item><description>SUCCESS_FAILURE: Alerting on success or failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FAILURE</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The start time of the node. This parameter is required only for hourly scheduled nodes. Format: HH:mm:ss. Valid values: 00:00:00 to 23:59:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00:00</para>
        /// </summary>
        [NameInMap("BizBeginTime")]
        [Validation(Required=false)]
        public string BizBeginTime { get; set; }

        /// <summary>
        /// <para>The end time of the node. This parameter is required only for hourly scheduled nodes. Format: HH:mm:ss. Valid values: 00:00:00 to 23:59:59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01:00:00</para>
        /// </summary>
        [NameInMap("BizEndTime")]
        [Validation(Required=false)]
        public string BizEndTime { get; set; }

        /// <summary>
        /// <para>The number of concurrent nodes. Valid values: 2 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ConcurrentRuns")]
        [Validation(Required=false)]
        public int? ConcurrentRuns { get; set; }

        /// <summary>
        /// <para>The end business date for data backfill. Format: yyyy-MM-dd 00:00:00.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-21 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizDate")]
        [Validation(Required=false)]
        public string EndBizDate { get; set; }

        /// <summary>
        /// <para>The list of node IDs that do not require data backfill. Nodes in this list generate dry-run instances. After a dry-run instance is scheduled, it directly succeeds without executing the script content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234,123465</para>
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// <para>The node IDs for data backfill. Separate multiple node IDs with commas (,). You can call the <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> operation to obtain node IDs.</para>
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
        /// <para>A JSON string in which the key is the node ID and the value is the actual parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;74324&quot;:&quot;a=123 b=456&quot;}</para>
        /// </summary>
        [NameInMap("NodeParams")]
        [Validation(Required=false)]
        public string NodeParams { get; set; }

        /// <summary>
        /// <para>Specifies whether nodes across multiple business dates can run in parallel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public bool? Parallelism { get; set; }

        /// <summary>
        /// <para>The environment of the workspace. PROD indicates the production environment. DEV indicates the development environment.</para>
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
        /// <para>The start business date for data backfill. Format: yyyy-MM-dd 00:00:00.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-20 00:00:00</para>
        /// </summary>
        [NameInMap("StartBizDate")]
        [Validation(Required=false)]
        public string StartBizDate { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately run instances whose scheduling time is in the future. If this parameter is set to true, instances with a scheduling time later than the current time run immediately. Otherwise, the instances wait until the scheduling time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("StartFutureInstanceImmediately")]
        [Validation(Required=false)]
        public bool? StartFutureInstanceImmediately { get; set; }

    }

}
