// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class CreateAppGroupRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey for the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcExHZviLcl****</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DocTest</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The type of application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>TRACE</c>: Application Monitoring</description></item>
        /// <item><description><c>EBPF</c>: Application Monitoring eBPF Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public int? AppType { get; set; }

        /// <summary>
        /// <para>The application version. 1: Basic version, 2: Professional version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public int? AppVersion { get; set; }

        /// <summary>
        /// <para>The description of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable logging. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enabled</description></item>
        /// <item><description><c>false</c>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLog")]
        [Validation(Required=false)]
        public bool? EnableLog { get; set; }

        /// <summary>
        /// <para>The application ID. You can obtain the application ID on the Application Management page in the SchedulerX console.</para>
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
        /// <para>The configuration of the alert. The value is a JSON string. For more information about this parameter, see <b>Additional information about request parameters</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sendChannel&quot;:&quot;sms,ding&quot;}</para>
        /// </summary>
        [NameInMap("MonitorConfigJson")]
        [Validation(Required=false)]
        public string MonitorConfigJson { get; set; }

        /// <summary>
        /// <para>The configuration of alert contacts. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;userName&quot;:&quot;Tom&quot;,&quot;userPhone&quot;:&quot;89756******&quot;},{&quot;userName&quot;:&quot;Bob&quot;,&quot;ding&quot;:&quot;<a href="http://www.example.com%22%7D%5D">http://www.example.com&quot;}]</a></para>
        /// </summary>
        [NameInMap("MonitorContactsJson")]
        [Validation(Required=false)]
        public string MonitorContactsJson { get; set; }

        /// <summary>
        /// <para>The namespace ID. You can obtain the namespace ID on the Namespace page in the SchedulerX console.</para>
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
        /// <para>This parameter is not supported. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>schedulerx</para>
        /// </summary>
        [NameInMap("NamespaceSource")]
        [Validation(Required=false)]
        public string NamespaceSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-workday-notification</para>
        /// </summary>
        [NameInMap("NotificationPolicyName")]
        [Validation(Required=false)]
        public string NotificationPolicyName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to schedule a busy worker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ScheduleBusyWorkers")]
        [Validation(Required=false)]
        public bool? ScheduleBusyWorkers { get; set; }

    }

}
