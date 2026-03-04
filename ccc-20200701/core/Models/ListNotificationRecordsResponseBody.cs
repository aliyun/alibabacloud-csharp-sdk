// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListNotificationRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNotificationRecordsResponseBodyData> Data { get; set; }
        public class ListNotificationRecordsResponseBodyData : TeaModel {
            /// <summary>
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
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-468a63a2-<b><b>-</b></b>-****-b1ecf726d4be</para>
            /// </summary>
            [NameInMap("NotificationKey")]
            [Validation(Required=false)]
            public string NotificationKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Dialing</para>
            /// </summary>
            [NameInMap("NotificationType")]
            [Validation(Required=false)]
            public string NotificationType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0630E5DF-CEB0-445B-8626-D5C7481181C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
