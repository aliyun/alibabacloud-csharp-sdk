// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SaveNotificationRegistrationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;updatedTime&quot;: 1793206576425,
        ///     &quot;accessPoint&quot;: &quot;<a href="http://www.aliyun.com">http://www.aliyun.com</a>&quot;,
        ///     &quot;accessPointType&quot;: &quot;ENDPOINT&quot;,
        ///     &quot;instanceId&quot;: &quot;b3865dc3-4fa-4fd-9f4-dc7cda305a24&quot;,
        ///     &quot;createdTime&quot;: 1793206552000,
        ///     &quot;topic&quot;: &quot;TOPIC_WEBHOOK&quot;,
        ///     &quot;authType&quot;: &quot;USERNAME_PASSWORD&quot;,
        ///     &quot;mqType&quot;: &quot;WEBHOOK&quot;,
        ///     &quot;username&quot;: &quot;**************&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E85B7837-1E06-5180-B2AD-13B546D596D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
