// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTasksRequest : TeaModel {
        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b> (default)</description></item>
        /// <item><description><b>asc</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The name of the handling entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <para>The type of the handling entity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ip</b></description></item>
        /// <item><description><b>file</b></description></item>
        /// <item><description><b>process</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("EntityUuid")]
        [Validation(Required=false)]
        public string EntityUuid { get; set; }

        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the result.</para>
        /// <remarks>
        /// <para> You can obtain the field from the response result.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. If you do not specify the PageSize parameter, 10 entries are returned by default.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The handling entity, handling scenario, or handling parameter that is used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.x.x.x</para>
        /// </summary>
        [NameInMap("ParamContent")]
        [Validation(Required=false)]
        public string ParamContent { get; set; }

        /// <summary>
        /// <para>The end of the time range for a handling task. The value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessActionEnd")]
        [Validation(Required=false)]
        public long? ProcessActionEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for a handling task. The value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessActionStart")]
        [Validation(Required=false)]
        public long? ProcessActionStart { get; set; }

        /// <summary>
        /// <para>The end of the time range for an unblocking task. The value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessRemoveEnd")]
        [Validation(Required=false)]
        public long? ProcessRemoveEnd { get; set; }

        /// <summary>
        /// <para>The beginning of the time range for an unblocking task. The value is a 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessRemoveStart")]
        [Validation(Required=false)]
        public long? ProcessRemoveStart { get; set; }

        /// <summary>
        /// <para>The UUID of the handling policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2584440.html">ListDisposeStrategy</a> operation to query the UUID of the handling policy.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>92af3c79-1754-4646-9366-9ddbd1e45536_xxxx</para>
        /// </summary>
        [NameInMap("ProcessStrategyUuid")]
        [Validation(Required=false)]
        public string ProcessStrategyUuid { get; set; }

        /// <summary>
        /// <para>The scenario code of the handling task.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeEnumItems~~">DescribeEnumItems</a> operation to query the scenario code of the handling task. This parameter is available when you set <b>EnumType</b> to <b>process</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>event_xxx_whole_process</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is specified in the handling task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125xxxxx9870</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The triggering source of the handling task. The value is a string array. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>system</b>: triggered when you manually handle an event</description></item>
        /// <item><description><b>custom</b>: triggered by an event based on an automatic response rule</description></item>
        /// <item><description><b>custom_alert</b>: triggered by an alert based on an automatic response rule</description></item>
        /// <item><description><b>soar-manual</b>: triggered when you use SOAR to manually run a playbook</description></item>
        /// <item><description><b>soar-mdr</b>: triggered by Managed Security Service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;system&quot;]</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The unique identifier of the handling task.</para>
        /// <remarks>
        /// <para> This parameter is used to query a specific task. You can obtain the value from the response result.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>150xxxxxxxxx95066</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The status of the handling task. The value is a string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>11</b>: being handled</description></item>
        /// <item><description><b>21</b>: being blocked</description></item>
        /// <item><description><b>22</b>: being quarantined</description></item>
        /// <item><description><b>23</b>: completed</description></item>
        /// <item><description><b>24</b>: added to the whitelist</description></item>
        /// <item><description><b>20</b>: successful</description></item>
        /// <item><description><b>90</b>: failed</description></item>
        /// <item><description><b>91</b>: unblocking failed</description></item>
        /// <item><description><b>92</b>: restoring quarantined files failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;11&quot;,&quot;21&quot;]</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        [NameInMap("TriggerSource")]
        [Validation(Required=false)]
        public string TriggerSource { get; set; }

        /// <summary>
        /// <para>The cloud service that is associated with the handling task. The value is a string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WAF</b>: Web Application Firewall (WAF)</description></item>
        /// <item><description><b>CFW</b>: Cloud Firewall</description></item>
        /// <item><description><b>Aegis</b>: Security Center</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;WAF&quot;]</para>
        /// </summary>
        [NameInMap("YunCode")]
        [Validation(Required=false)]
        public string YunCode { get; set; }

    }

}
