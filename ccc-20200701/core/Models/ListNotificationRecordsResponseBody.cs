// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListNotificationRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNotificationRecordsResponseBodyData> Data { get; set; }
        public class ListNotificationRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The notification content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;agentId&quot;: &quot;agent@ccc-test&quot;,
            ///     &quot;callType&quot;: &quot;OUTBOUND&quot;,
            ///     &quot;callee&quot;: &quot;13<b><b>00&quot;,
            ///     &quot;caller&quot;: &quot;05</b></b>81&quot;,
            ///     &quot;channelId&quot;: &quot;ch-user-13<b><b>00-05</b></b>81-1772619731285-job-<em><b><b>&quot;,
            ///     &quot;contactId&quot;: &quot;job-</b></b></em>&quot;,
            ///     &quot;eventTime&quot;: &quot;2026-03-04T10:22:11.309Z&quot;,
            ///     &quot;eventType&quot;: &quot;Dialing&quot;,
            ///     &quot;instanceId&quot;: &quot;ccc-test&quot;,
            ///     &quot;mediaType&quot;: &quot;AUDIO&quot;,
            ///     &quot;skillGroupId&quot;: &quot;skill@ccc-test&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The notification key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-468a63a2-<b><b>-</b></b>-****-b1ecf726d4be</para>
            /// </summary>
            [NameInMap("NotificationKey")]
            [Validation(Required=false)]
            public string NotificationKey { get; set; }

            /// <summary>
            /// <para>The message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dialing</para>
            /// </summary>
            [NameInMap("NotificationType")]
            [Validation(Required=false)]
            public string NotificationType { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of invalid parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0630E5DF-CEB0-445B-8626-D5C7481181C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
