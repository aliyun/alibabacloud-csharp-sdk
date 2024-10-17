// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20180501.Models
{
    public class BatchSendMessageToGlobeResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of mobile phone numbers that failed to receive the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;931520581****&quot;,&quot;931530581****&quot;]</para>
        /// </summary>
        [NameInMap("FailedList")]
        [Validation(Required=false)]
        public string FailedList { get; set; }

        /// <summary>
        /// <para>The sender ID returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alicloud321</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The ID of the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;123****&quot;,&quot;124****&quot;]</para>
        /// </summary>
        [NameInMap("MessageIdList")]
        [Validation(Required=false)]
        public string MessageIdList { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8D28D3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code. If OK is returned, the request is successful. For more information, see <a href="https://www.alibabacloud.com/help/en/short-message-service/latest/error-codes">Error codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResponseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The SMS Send Request was accepted</para>
        /// </summary>
        [NameInMap("ResponseDescription")]
        [Validation(Required=false)]
        public string ResponseDescription { get; set; }

        /// <summary>
        /// <para>The number of mobile phone numbers that received the message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public string SuccessCount { get; set; }

    }

}
