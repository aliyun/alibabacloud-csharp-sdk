// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class UpdateAppGroupRequest : TeaModel {
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
        /// <para>The ID of the application. You can obtain the application ID on the <b>Application Management</b> page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSchedulerx.defaultGroup</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent instances. Default value: 1. A value of 1 specifies that if the last triggered instance is running, the next instance is not triggered even if the scheduled point in time for running the next instance is reached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxConcurrency")]
        [Validation(Required=false)]
        public int? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>The configuration of the alert. The value is a JSON string. For more information about this parameter, see <b>Additional information about request parameters</b>.</para>
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
        /// <para>The configuration of alert contacts. The value is a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;userName&quot;:&quot;Tom&quot;,&quot;userPhone&quot;:&quot;89756******&quot;},{&quot;userName&quot;:&quot;Bob&quot;,&quot;ding&quot;:&quot;<a href="http://www.example.com%22%7D%5D">http://www.example.com&quot;}]</a></para>
        /// </summary>
        [NameInMap("MonitorContactsJson")]
        [Validation(Required=false)]
        public string MonitorContactsJson { get; set; }

        /// <summary>
        /// <para>The ID of the namespace. You can obtain the ID of the namespace on the Namespace page in the SchedulerX console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-workday-notification</para>
        /// </summary>
        [NameInMap("NotificationPolicyName")]
        [Validation(Required=false)]
        public string NotificationPolicyName { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
