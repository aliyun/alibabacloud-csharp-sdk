// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class QueryMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DELIVERED</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorDescription")]
        [Validation(Required=false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// <para>The content of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hello!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1008030xxx3003</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The details about the mobile phone number.</para>
        /// </summary>
        [NameInMap("NumberDetail")]
        [Validation(Required=false)]
        public QueryMessageResponseBodyNumberDetail NumberDetail { get; set; }
        public class QueryMessageResponseBodyNumberDetail : TeaModel {
            /// <summary>
            /// <para>The carrier that owns the mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CMI</para>
            /// </summary>
            [NameInMap("Carrier")]
            [Validation(Required=false)]
            public string Carrier { get; set; }

            /// <summary>
            /// <para>The country to which the mobile phone number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China</para>
            /// </summary>
            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            /// <summary>
            /// <para>The region to which the mobile phone number belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HongKong</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The time when the delivery receipt was received from the carrier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mon, 24 Dec 2018 16:58:22 +0800</para>
        /// </summary>
        [NameInMap("ReceiveDate")]
        [Validation(Required=false)]
        public string ReceiveDate { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8D28D0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code of the delivery request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResponseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// <para>The description of the delivery request status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The SMS Send Request was accepted</para>
        /// </summary>
        [NameInMap("ResponseDescription")]
        [Validation(Required=false)]
        public string ResponseDescription { get; set; }

        /// <summary>
        /// <para>The time when the message was sent to the carrier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mon, 24 Dec 2018 16:58:22 +0800</para>
        /// </summary>
        [NameInMap("SendDate")]
        [Validation(Required=false)]
        public string SendDate { get; set; }

        /// <summary>
        /// <para>The delivery status of the message.</para>
        /// <list type="bullet">
        /// <item><description>1: The message was sent.</description></item>
        /// <item><description>2: The message failed to be sent.</description></item>
        /// <item><description>3: The message is being sent.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The mobile phone number to which the message was sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6581xxx810</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
