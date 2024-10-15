// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SingleCallByVoiceRequest : TeaModel {
        /// <summary>
        /// <para>The number for receiving voice notifications.</para>
        /// <para>Number format:</para>
        /// <list type="bullet">
        /// <item><description><para>In the Chinese mainland:</para>
        /// <list type="bullet">
        /// <item><description>Mobile phone number, for example, 159\<em>\</em>\*\*0000.</description></item>
        /// <item><description>Landline number, for example, 0571\<em>\</em>\*\*5678.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Outside the Chinese mainland: country code + phone number, for example, 85200\<em>\</em>\*\*00.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can specify only one called number for a request. For more information, see <a href="https://help.aliyun.com/document_detail/150016.html">How to use voice notifications in the Chinese mainland</a> or <a href="https://help.aliyun.com/document_detail/268810.html">How to use voice notifications in regions outside the Chinese mainland</a>.</para>
        /// </description></item>
        /// <item><description><para>Voice notifications are sent to a called number at the following frequency: one time per minute, five times per hour, and 20 times per 24 hours.</para>
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
        /// <item><description>You do not need to specify this parameter if you use a voice notification file that uses the common outbound call mode. For more information, see <a href="https://help.aliyun.com/document_detail/172104.html">FAQ about the common outbound call mode</a>.</description></item>
        /// <item><description>If you use a voice notification file that uses the dedicated outbound call mode, you must specify a number that you purchased. You can specify only one number. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a> and choose <b>Real Number Service</b> &gt; <b>Real Number Management</b> to view the number that you purchased.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0571****5678</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>The ID reserved for the caller. This ID is returned to the caller in a receipt message.</para>
        /// <para>The value must be of the STRING type and 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22596****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of times the voice notification file is played. Valid values: 1 to 3.</para>
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
        /// <para>The playback speed of the voice notification file. Valid values: -500 to 500.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// <para>The voice ID of the voice notification file.</para>
        /// <para>You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b> or <b>Voice File Management</b>, and then click the <b>Voice Notification Files</b> tab to view the <b>voice ID</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d4c-4e78-8d2a-afbb06cf****.wav</para>
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// <para>The playback volume of the voice notification file. Valid values: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
