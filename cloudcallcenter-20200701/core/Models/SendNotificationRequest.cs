// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class SendNotificationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;eventType&quot;: &quot;VnRecordingReady&quot;,   &quot;eventTime&quot;: &quot;2025-11-05T01:51:20.974Z&quot;,    &quot;instanceId&quot;: &quot;ccc-test&quot;,                    &quot;scenarioId&quot;: &quot;scenario-xxxx&quot;,               &quot;contactId&quot;: &quot;job-xxxxxx&quot;,                   &quot;duration&quot;: 59,                              &quot;startTime&quot;: &quot;2025-11-05T01:50:04.732Z&quot;,    &quot;endTime&quot;: &quot;2025-11-05T01:51:02.822Z&quot;,      &quot;fileName&quot;: &quot;xxxxxxx.wav&quot;,                   &quot;downloadURL&quot;: &quot;<a href="https://ccc-v2-online.oss-cn-shanghai.aliyuncs.com/ccc-record-mixed/xxxxxxx.wav?Expires=1762393880">https://ccc-v2-online.oss-cn-shanghai.aliyuncs.com/ccc-record-mixed/xxxxxxx.wav?Expires=1762393880</a>&quot; }</para>
        /// </summary>
        [NameInMap("MessageBody")]
        [Validation(Required=false)]
        public string MessageBody { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOMER</para>
        /// </summary>
        [NameInMap("NotificationTarget")]
        [Validation(Required=false)]
        public string NotificationTarget { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VnRecordingReady</para>
        /// </summary>
        [NameInMap("NotificationType")]
        [Validation(Required=false)]
        public string NotificationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-xxxxxx</para>
        /// </summary>
        [NameInMap("ShardingKey")]
        [Validation(Required=false)]
        public string ShardingKey { get; set; }

    }

}
