// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class IvrCallRequest : TeaModel {
        /// <summary>
        /// <para>The end voice.</para>
        /// <list type="bullet">
        /// <item><description>If you use a voice notification file, this parameter specifies the voice ID. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b>, and then click the <b>Voice Notification Files</b> tab to view the voice ID.</description></item>
        /// <item><description>If you use a TTS template, this parameter specifies the template ID. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b>, and then click the <b>TTS Template</b> tab to view the template ID.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The value of the ByeCode parameter must be of the same type as the value of the StartCode parameter. This means that both parameters must specify voice IDs or TTS template IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TTS_1234****</para>
        /// </summary>
        [NameInMap("ByeCode")]
        [Validation(Required=false)]
        public string ByeCode { get; set; }

        /// <summary>
        /// <para>The variables in the TTS template, in the JSON format.</para>
        /// <remarks>
        /// <para>This parameter is required when the ByeCode parameter is set to the ID of a TTS template that contains variables.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;xxx&quot;,&quot;code&quot;:&quot;123&quot;}</para>
        /// </summary>
        [NameInMap("ByeTtsParams")]
        [Validation(Required=false)]
        public string ByeTtsParams { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// <para>Only phone numbers in the Chinese mainland are supported. Each request supports only one called number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1590****000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// <para>The value must be a number you purchased. Each request supports only one calling number. In most cases, a calling number is configured with the maximum number of concurrent requests. New requests fail if the maximum number of concurrent requests is reached. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a> and choose <b>Real Number Service &gt; Real Number Management</b> to view the number you purchased.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571****5678</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <para>The information about the key pressed by the subscriber.</para>
        /// </summary>
        [NameInMap("MenuKeyMap")]
        [Validation(Required=false)]
        public List<IvrCallRequestMenuKeyMap> MenuKeyMap { get; set; }
        public class IvrCallRequestMenuKeyMap : TeaModel {
            /// <summary>
            /// <para>The voice that corresponds to the key specified by the <b>MenuKeyMap.N.Key</b> parameter.</para>
            /// <list type="bullet">
            /// <item><description>If you use a voice notification file, this parameter specifies the voice ID. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b>, and then click the <b>Voice Notification Files</b> tab to view the voice ID.</description></item>
            /// <item><description>If you use a TTS template, this parameter specifies the template ID. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b>, and then click the <b>TTS Template</b> tab to view the template ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TTS_1235****</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The key that can be pressed by the subscriber.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The variables in the TTS template, in the JSON format.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter specifies the substitution relationship of the variables in the TTS template if the value of the <b>MenuKeyMap.N.Code</b> parameter is set to the ID of the TTS template.</para>
            /// </description></item>
            /// <item><description><para>This parameter is required if the value of the <b>MenuKeyMap.N.Code</b> parameter is set to the ID of a TTS template that contains variables.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;xxx&quot;,&quot;code&quot;:&quot;123&quot;}</para>
            /// </summary>
            [NameInMap("TtsParams")]
            [Validation(Required=false)]
            public string TtsParams { get; set; }

        }

        /// <summary>
        /// <para>The ID that is reserved for the caller of the operation. This ID is returned to the caller in a receipt message.</para>
        /// <para>The value is of the STRING type and must be 1 to 15 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PR0210428****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of replay times. Valid values: 1 to 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The voice that is played when the call begins.</para>
        /// <list type="bullet">
        /// <item><description>If you use a voice notification file, this parameter specifies the voice ID. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; Voice Notifications, and then click the <b>Voice Notification Files</b> tab to view the voice ID.</description></item>
        /// <item><description>If you use a text-to-speech (TTS) template, this parameter specifies the template ID. You can log on to the <a href="https://dyvms.console.aliyun.com/overview/home">Voice Messaging Service console</a>, choose <b>Voice Messages</b> &gt; <b>Voice Notifications</b>, and then click the <b>TTS Template</b> tab to view the template ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TTS_1234****</para>
        /// </summary>
        [NameInMap("StartCode")]
        [Validation(Required=false)]
        public string StartCode { get; set; }

        /// <summary>
        /// <para>The variables in the TTS template, in the JSON format.</para>
        /// <remarks>
        /// <para>This parameter is required when the StartCode parameter is set to the ID of a TTS template that contains variables.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;xxx&quot;,&quot;code&quot;:&quot;123&quot;}</para>
        /// </summary>
        [NameInMap("StartTtsParams")]
        [Validation(Required=false)]
        public string StartTtsParams { get; set; }

        /// <summary>
        /// <para>The timeout period for the subscriber to press a key. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
