// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SingleCallByTtsRequest : TeaModel {
        /// <summary>
        /// <para>The mobile phone number that receives voice notifications.</para>
        /// <list type="bullet">
        /// <item><description><para>Number format in the Chinese mainland:</para>
        /// <list type="bullet">
        /// <item><description>Mobile phone number, for example, 159\<em>\</em>\*\*0000.</description></item>
        /// <item><description>Landline number, for example, 0571\<em>\</em>\*\*5678.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Number format outside the Chinese mainland: country code + phone number, for example, 85200\<em>\</em>\*\*00.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Each request supports only one called number. For more information, see <a href="https://help.aliyun.com/document_detail/150016.html">How to use voice notifications in the Chinese mainland</a> or <a href="https://help.aliyun.com/document_detail/270044.html">How to use voice verification codes in regions outside the Chinese mainland</a>.</para>
        /// </description></item>
        /// <item><description><para>Voice verification codes are sent to a called number at the following frequency: one time per minute, five times per hour, and 20 times per 24 hours.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1590****000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The number displayed to the called party.</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter if you use the text-to-speech (TTS) notification template or voice verification code template for outbound calls in the common mode. For more information, see <a href="https://help.aliyun.com/document_detail/172104.html">FAQ about the common outbound call mode</a>.</description></item>
        /// <item><description>If you use the TTS notification template or voice verification code template for outbound calls in the dedicated mode, you must specify a number you purchased and only one number can be specified. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a> and choose <b>Voice Numbers</b> &gt; <b>Real Number Management</b> to view the number you purchased.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0571****5678</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>The custom ID that is reserved for the caller of the operation when the request is initiated. This ID is returned to the caller in a receipt message.</para>
        /// <para>The value is of the STRING type and must be 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>225869*****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of times a voice notification is played back in a call. Valid values: 1 to 3. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public int? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The playback speed. Valid value: -500 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// <para>The ID of the approved TTS notification template or voice verification code template.</para>
        /// <para>You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, and choose <b>Voice Messages</b> &gt; <b>Voice Verification Codes</b> or choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b> to view the <b>template ID</b>.</para>
        /// <remarks>
        /// <para>The account to which the TTS template belongs must be the same as the account that is used to call the SingleCallByTts operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TTS_100****</para>
        /// </summary>
        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        /// <summary>
        /// <para>The variables in the template, in the JSON format.</para>
        /// <remarks>
        /// <para>The variables in the template must be less than 250 characters in length. The length of each single variable is not limited. These variables do not support URLs. The variables in the verification code template support only digits and letters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AckNum&quot;:&quot;123456&quot;}</para>
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// <para>The playback volume of the voice notification. Valid values: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
