// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateAppGroupRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcExHZviLcl****</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DocTest</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The application type.</para>
        /// <list type="bullet">
        /// <item><description><para><c>1</c>: Standard application.</para>
        /// </description></item>
        /// <item><description><para><c>2</c>: Kubernetes (K8s) application.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public int? AppType { get; set; }

        /// <summary>
        /// <para>The application version. Valid values: <c>1</c> (Basic Edition) and <c>2</c> (Professional Edition).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public int? AppVersion { get; set; }

        /// <summary>
        /// <para>The application description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable logging.</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enable logging.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disable logging.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLog")]
        [Validation(Required=false)]
        public bool? EnableLog { get; set; }

        /// <summary>
        /// <para>The ID of the application group. You can find this ID on the <b>Application Management</b> page in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The maximum number of jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxJobs")]
        [Validation(Required=false)]
        public int? MaxJobs { get; set; }

        /// <summary>
        /// <para>Specifies the alert notification configuration as a JSON string. The string can contain the following properties: <c>sendChannel</c>, <c>alarmType</c>, and <c>webhookIsAtAll</c>.</para>
        /// <remarks>
        /// <para>For more information, see the <b>Additional information about request parameters</b> section.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;sendChannel&quot;: &quot;ding,sms,mail,phone&quot;,
        ///     &quot;alarmType&quot;: &quot;Contacts&quot;,
        ///     &quot;webhookIsAtAll&quot;: false
        /// }</para>
        /// </summary>
        [NameInMap("MonitorConfigJson")]
        [Validation(Required=false)]
        public string MonitorConfigJson { get; set; }

        /// <summary>
        /// <para>The alert contacts. This can include individual contacts and contact groups.</para>
        /// <remarks>
        /// <para>For more information, see the <b>Additional information about request parameters</b> section.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///     {&quot;name&quot;: &quot;Alice Johnson&quot;},
        ///     {&quot;name&quot;: &quot;Lee Smith&quot;}
        /// ]</para>
        /// </summary>
        [NameInMap("MonitorContactsJson")]
        [Validation(Required=false)]
        public string MonitorContactsJson { get; set; }

        /// <summary>
        /// <para>The ID of the namespace. You can find this ID on the <b>Namespace</b> page in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>This parameter is currently unsupported and can be left unspecified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <para>The notification policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-workday-notification</para>
        /// </summary>
        [NameInMap("NotificationPolicyName")]
        [Validation(Required=false)]
        public string NotificationPolicyName { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to schedule jobs on a busy worker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ScheduleBusyWorkers")]
        [Validation(Required=false)]
        public bool? ScheduleBusyWorkers { get; set; }

    }

}
