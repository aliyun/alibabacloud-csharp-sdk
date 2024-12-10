// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class SendCustomEventResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Interface return data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SendCustomEventResponseBodyData Data { get; set; }
        public class SendCustomEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Service UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1601097845544644</para>
            /// </summary>
            [NameInMap("CustomerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            /// <summary>
            /// <para>Customer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>天津瑞鹏昇科技发展有限公司</para>
            /// </summary>
            [NameInMap("CustomerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// <para>Alert ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c0dc71d1-8a1d-4043-9767-f6c420e34901-81bd</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>Alert type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUSP_CUSTOM_WAF</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>Work order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1914348</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Owner ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>352675</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Owner name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>乐牙</para>
            /// </summary>
            [NameInMap("OwnerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            /// <summary>
            /// <para>Work order name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22端口禁止任意IP访问</para>
            /// </summary>
            [NameInMap("WorkTaskName")]
            [Validation(Required=false)]
            public string WorkTaskName { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Return message. When the request is successful, it returns a success message; when the request fails, it returns the reason for the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>606EB377-155D-5AEB-AC4F-F013444A4C45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Call succeeded.</para>
        /// </description></item>
        /// <item><description><para>false: Call failed.</para>
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
