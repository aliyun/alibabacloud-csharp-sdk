// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RtcSendSipDtmfRequest : TeaModel {
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
        /// <para>The ID of an existing channel. Only a single ID is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The user ID (sipUserId) in the target OneRTC SIP call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("ChannelUserId")]
        [Validation(Required=false)]
        public string ChannelUserId { get; set; }

        /// <summary>
        /// <para>The device type of the third-party Session Initiation Protocol (SIP) device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sip_device</description></item>
        /// <item><description>mcu</description></item>
        /// <item><description>phone</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcu</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>The keys to be sent. Supported keys include 0-9, A-D, a-d, *, #, W or w (wait), and F or f (flash). The keys are sent in the original order and case.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12#W3f</para>
        /// </summary>
        [NameInMap("Digits")]
        [Validation(Required=false)]
        public string Digits { get; set; }

    }

}
