// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Schedulerx220190430.Models
{
    public class GetAppGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the application group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAppGroupResponseBodyData Data { get; set; }
        public class GetAppGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AppKey of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QI4lWMZ+xk1rNB67jFUhaw==</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DocTest</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The application version. 1: Basic version, 2: Professional version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>The number of jobs that are configured for the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurJobs")]
            [Validation(Required=false)]
            public int? CurJobs { get; set; }

            /// <summary>
            /// <para>The description of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EnableLog")]
            [Validation(Required=false)]
            public bool? EnableLog { get; set; }

            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testSchedulerx.defaultGroup</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The maximum number of jobs that can be configured for the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxJobs")]
            [Validation(Required=false)]
            public int? MaxJobs { get; set; }

            /// <summary>
            /// <para>The alert notification configurations.</para>
            /// <remarks>
            /// <para> For more information about this parameter, see the following <b>additional information about request parameters</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sendChannel&quot;:&quot;sms,mail,ding&quot;}</para>
            /// </summary>
            [NameInMap("MonitorConfigJson")]
            [Validation(Required=false)]
            public string MonitorConfigJson { get; set; }

            /// <summary>
            /// <para>The alert contact configurations.</para>
            /// <remarks>
            /// <para> For more information about this parameter, see the following <b>additional information about request parameters</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[ {&quot;name&quot;: &quot;Peter&quot;}, {&quot;name&quot;: &quot;Paul&quot;} ]</para>
            /// </summary>
            [NameInMap("MonitorContactsJson")]
            [Validation(Required=false)]
            public string MonitorContactsJson { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
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

        }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app is not existed, groupId=xxxx, namesapce=xxxx</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
