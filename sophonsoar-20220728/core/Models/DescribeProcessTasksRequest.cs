// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTasksRequest : TeaModel {
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public string AlertId { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>desc</b>: Descending (default).</description></item>
        /// <item><description><b>asc</b>: Ascending.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The name of the entity to be disposed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("EntityName")]
        [Validation(Required=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// <para>The type of the entity to be disposed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ip</b>: IP address entity.</description></item>
        /// <item><description><b>file</b>: File entity.</description></item>
        /// <item><description><b>process</b>: Process entity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The UUID of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69d189e2-ec17-4676-a2fe-02969234****</para>
        /// </summary>
        [NameInMap("EntityUuid")]
        [Validation(Required=false)]
        public string EntityUuid { get; set; }

        /// <summary>
        /// <para>The UUID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1020ce1-d6a5-11e8-8298-00163e10****</para>
        /// </summary>
        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        [NameInMap("ExecuteUuid")]
        [Validation(Required=false)]
        public string ExecuteUuid { get; set; }

        /// <summary>
        /// <para>The field used to sort the results.</para>
        /// <remarks>
        /// <para>You can obtain the sort field from the response of this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: 1, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page for paging queries. Default value: 20. If the PageSize parameter is left empty, 10 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The fuzzy match content. This parameter queries the entity, disposal scene, and disposal parameter fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12.x.x.x</para>
        /// </summary>
        [NameInMap("ParamContent")]
        [Validation(Required=false)]
        public string ParamContent { get; set; }

        /// <summary>
        /// <para>The end time of the query range for the disposal time. Format: 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessActionEnd")]
        [Validation(Required=false)]
        public long? ProcessActionEnd { get; set; }

        /// <summary>
        /// <para>The start time of the query range for the disposal time. Format: 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessActionStart")]
        [Validation(Required=false)]
        public long? ProcessActionStart { get; set; }

        /// <summary>
        /// <para>The end time of the query range for the unblocking time. Format: 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessRemoveEnd")]
        [Validation(Required=false)]
        public long? ProcessRemoveEnd { get; set; }

        /// <summary>
        /// <para>The start time of the query range for the unblocking time. Format: 13-digit timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700031183572</para>
        /// </summary>
        [NameInMap("ProcessRemoveStart")]
        [Validation(Required=false)]
        public long? ProcessRemoveStart { get; set; }

        /// <summary>
        /// <para>The UUID of the disposal strategy.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2584440.html">ListDisposeStrategy</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>92af3c79-1754-4646-9366-9ddbd1e45536_****</para>
        /// </summary>
        [NameInMap("ProcessStrategyUuid")]
        [Validation(Required=false)]
        public string ProcessStrategyUuid { get; set; }

        /// <summary>
        /// <para>The trigger ID of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b73d0b08-f1bd-4e8f-967a-8e2982c9****</para>
        /// </summary>
        [NameInMap("ReqUuid")]
        [Validation(Required=false)]
        public string ReqUuid { get; set; }

        [NameInMap("ResponseRuleId")]
        [Validation(Required=false)]
        public string ResponseRuleId { get; set; }

        /// <summary>
        /// <para>The scene code of the disposal task.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeEnumItems~~">DescribeEnumItems</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>event_xxx_whole_process</para>
        /// </summary>
        [NameInMap("SceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID for the disposal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>125xxxxx9870</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The trigger source of the disposal task, in array string format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>system</b>: Triggered by manual event disposal.</description></item>
        /// <item><description><b>custom</b>: Triggered by an automatic response rule based on an event.</description></item>
        /// <item><description><b>custom_alert</b>: Triggered by an automatic response rule based on an alert.</description></item>
        /// <item><description><b>soar-manual</b>: Triggered by manually invoking a SOAR playbook.</description></item>
        /// <item><description><b>soar-mdr</b>: Triggered by the Managed Security Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;system&quot;]</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The unique identifier of the disposal task.</para>
        /// <remarks>
        /// <para>This parameter is used to query a specific task. You can obtain the value from the response of this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>150xxxxxxxxx95066</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The status list of the disposal task, in data string format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>11</b>: Disposing.</description></item>
        /// <item><description><b>21</b>: Blocking.</description></item>
        /// <item><description><b>22</b>: Isolating.</description></item>
        /// <item><description><b>23</b>: Ended.</description></item>
        /// <item><description><b>24</b>: Whitelisted.</description></item>
        /// <item><description><b>20</b>: Succeeded.</description></item>
        /// <item><description><b>90</b>: Failed.</description></item>
        /// <item><description><b>91</b>: Unblocking failed.</description></item>
        /// <item><description><b>92</b>: Unisolation failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;11&quot;,&quot;21&quot;]</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The trigger source of the disposal task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>system</b>: Triggered by manual event disposal.</description></item>
        /// <item><description><b>custom</b>: Triggered by an automatic response rule based on an event.</description></item>
        /// <item><description><b>custom_alert</b>: Triggered by an automatic response rule based on an alert.</description></item>
        /// <item><description><b>soar-manual</b>: Triggered by manually invoking a SOAR playbook.</description></item>
        /// <item><description><b>soar-mdr</b>: Triggered by the Managed Security Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("TriggerSource")]
        [Validation(Required=false)]
        public string TriggerSource { get; set; }

        /// <summary>
        /// <para>The cloud product associated with the disposal task, in data string format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WAF</b>: Web Application Firewall.</description></item>
        /// <item><description><b>CFW</b>: Cloud Firewall.</description></item>
        /// <item><description><b>Aegis</b>: Security Center.</description></item>
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
