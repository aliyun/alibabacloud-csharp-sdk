// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RtcCancelSipInviteRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Create and find this ID in the console. Specify only one ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of an existing channel. Specify only one ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$rtc_channelid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The type of the third-party SIP device:</para>
        /// <list type="bullet">
        /// <item><description><para>sip_device</para>
        /// </description></item>
        /// <item><description><para>mcu</para>
        /// </description></item>
        /// <item><description><para>phone</para>
        /// </description></item>
        /// </list>
        /// <para>Note: Only the phone type is supported at this stage.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>phone</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$rtc_userid</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
