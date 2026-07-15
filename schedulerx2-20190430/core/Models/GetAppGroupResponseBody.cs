// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetAppGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The details of the App Group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAppGroupResponseBodyData Data { get; set; }
        public class GetAppGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application\&quot;s AppKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QI4lWMZ+xk1rNB67jFUhaw==</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DocTest</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application version. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The number of jobs currently configured for the App Group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurJobs")]
            [Validation(Required=false)]
            public int? CurJobs { get; set; }

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
            /// <para>Specifies whether to enable log collection. The default value is false.</para>
            /// </summary>
            [NameInMap("EnableLog")]
            [Validation(Required=false)]
            public bool? EnableLog { get; set; }

            /// <summary>
            /// <para>The App Group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSchedulerx.defaultGroup</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The maximum number of jobs that can be configured for the App Group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxJobs")]
            [Validation(Required=false)]
            public int? MaxJobs { get; set; }

            /// <summary>
            /// <para>The alarm notification configuration.</para>
            /// <remarks>
            /// <para>For more information, see the <b>MonitorConfigJson</b> section below.</para>
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
            /// <para>The alarm contact configuration.</para>
            /// <remarks>
            /// <para>For more information, see the <b>MonitorContactsJson</b> section below.</para>
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
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>adcfc35d-e2fe-4fe9-bbaa-20e90ffc****</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The name of the notification policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-workday-notification</para>
            /// </summary>
            [NameInMap("NotificationPolicyName")]
            [Validation(Required=false)]
            public string NotificationPolicyName { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app is not existed, groupId=xxxx, namesapce=xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39090022-1F3B-4797-8518-6B61095F1AF0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
