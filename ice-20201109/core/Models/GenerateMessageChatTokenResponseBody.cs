// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GenerateMessageChatTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The AppID of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application signature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>H4sIAAAAAAAE******************</para>
        /// </summary>
        [NameInMap("AppSign")]
        [Validation(Required=false)]
        public string AppSign { get; set; }

        /// <summary>
        /// <para>The nonce used to generate the token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AK-***********</para>
        /// </summary>
        [NameInMap("Nonce")]
        [Validation(Required=false)]
        public string Nonce { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req_1234567890abcdef</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The role used to generate the token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The expiration time. Unit: seconds. Expiration time = Current time + Validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000</para>
        /// </summary>
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public long? TimeStamp { get; set; }

        /// <summary>
        /// <para>The generated token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acet**********</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The ID of the user for joining the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YOURUSERID</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
