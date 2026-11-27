// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RtcSipInviteMemberRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. You can create and query the ID in the console. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The meeting token. For code generation, refer to <a href="https://help.aliyun.com/document_detail/2689025.html">https://help.aliyun.com/document_detail/2689025.html</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>000qaaasas……b</para>
        /// </summary>
        [NameInMap("AppToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <para>The custom line number in PSTN scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>055112345678</para>
        /// </summary>
        [NameInMap("CallNumber")]
        [Validation(Required=false)]
        public string CallNumber { get; set; }

        /// <summary>
        /// <para>The channel ID. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$rtc_channelid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The type of the device used to call the third-party SIP endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sip_device</description></item>
        /// <item><description>mcu</description></item>
        /// <item><description>phone</description></item>
        /// </list>
        /// <para>Note: Currently, only the phone type is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>phone</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the third-party meeting system requires registration for inbound calls.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Registered")]
        [Validation(Required=false)]
        public bool? Registered { get; set; }

        /// <summary>
        /// <ol>
        /// <item><description>The IP address of the nearest RTC SIP server.</description></item>
        /// <item><description>You can resolve the domain name rtcsip.dingtalk.com locally to obtain the nearest access address.
        /// For example, run dig rtcsip.dingtalk.com to obtain the address.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>39.101.232.13</para>
        /// </summary>
        [NameInMap("ServerAddress")]
        [Validation(Required=false)]
        public string ServerAddress { get; set; }

        /// <summary>
        /// <para>The username displayed on the third-party system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdevice</para>
        /// </summary>
        [NameInMap("SipDisplayName")]
        [Validation(Required=false)]
        public string SipDisplayName { get; set; }

        /// <summary>
        /// <ol>
        /// <item><description>When the device is mcu, it indicates the channel number of the third-party meeting system to be called.</description></item>
        /// <item><description>When the device is sip_device, it indicates the registration number of the registered device to be invited.</description></item>
        /// <item><description>When the device is phone, it indicates the called phone number.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18512514528</para>
        /// </summary>
        [NameInMap("SipRoomId")]
        [Validation(Required=false)]
        public string SipRoomId { get; set; }

        /// <summary>
        /// <ol>
        /// <item><description>When the device is mcu, it indicates the address information of the third-party meeting system in the format of ip:port;transport=tcp/udp/tls.
        /// Example: &quot;30.240.160.66:5060;transport=tcp&quot;</description></item>
        /// <item><description>When the device is sip_device, it indicates the registration address of the registered device to be invited.
        /// Example: 39.101.232.13</description></item>
        /// <item><description>When the device is phone, it indicates the address information of the telephone gateway.
        /// Example: &quot;30.240.160.66:5060;transport=tcp&quot;</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>30.240.160.66:5060;transport=tcp</para>
        /// </summary>
        [NameInMap("SipUri")]
        [Validation(Required=false)]
        public string SipUri { get; set; }

        /// <summary>
        /// <para>The brand and model of the third-party SIP endpoint being called, such as polycom, cisco, tencent, zoom, or pstn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pstn</para>
        /// </summary>
        [NameInMap("SipUserAgent")]
        [Validation(Required=false)]
        public string SipUserAgent { get; set; }

        /// <summary>
        /// <ol>
        /// <item><description>When DeviceType is mcu, it represents the third-party meeting system.</description></item>
        /// <item><description>When DeviceType is sip_device, it represents the registered device.</description></item>
        /// <item><description>If the third-party meeting system requires registration for inbound calls, it is the account provided by the third-party system to create an account.</description></item>
        /// <item><description>If registration is not required, it is the SIP username or RTC user ID for calling the third-party system.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$reg_userid</para>
        /// </summary>
        [NameInMap("SipUserId")]
        [Validation(Required=false)]
        public string SipUserId { get; set; }

        /// <summary>
        /// <para>The registration password that matches the SipUserId if the third-party system requires registration for inbound calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>654321</para>
        /// </summary>
        [NameInMap("SipUserPassword")]
        [Validation(Required=false)]
        public string SipUserPassword { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>taskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$rtc_userid</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
