// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class SendMessageWithTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1**************3</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <para>The details about the mobile phone number of the recipient.</para>
        /// </summary>
        [NameInMap("NumberDetail")]
        [Validation(Required=false)]
        public SendMessageWithTemplateResponseBodyNumberDetail NumberDetail { get; set; }
        public class SendMessageWithTemplateResponseBodyNumberDetail : TeaModel {
            /// <summary>
            /// <para>The carrier that owns the mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China Mobile</para>
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
            /// <para>Nanjing, Jiangsu</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8D23D6</para>
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
        /// <para>The number of messages that incurred fees.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Segments")]
        [Validation(Required=false)]
        public string Segments { get; set; }

        /// <summary>
        /// <para>The mobile phone number to which the message was sent. The dialing code was added to the beginning of the mobile phone number. Example: 861503871\<em>\</em>\<em>\</em>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>861503871****</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public string To { get; set; }

    }

}
