// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RtcSipInviteMemberRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eo85****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>000qaaasas……b</para>
        /// </summary>
        [NameInMap("AppToken")]
        [Validation(Required=false)]
        public string AppToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>055112345678</para>
        /// </summary>
        [NameInMap("CallNumber")]
        [Validation(Required=false)]
        public string CallNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mcu</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Registered")]
        [Validation(Required=false)]
        public bool? Registered { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>47.116.80.180</para>
        /// </summary>
        [NameInMap("ServerAddress")]
        [Validation(Required=false)]
        public string ServerAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ceo</para>
        /// </summary>
        [NameInMap("SipDisplayName")]
        [Validation(Required=false)]
        public string SipDisplayName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SipRoomId")]
        [Validation(Required=false)]
        public string SipRoomId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30.240.160.66:5060;transport=tcp</para>
        /// </summary>
        [NameInMap("SipUri")]
        [Validation(Required=false)]
        public string SipUri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pstn</para>
        /// </summary>
        [NameInMap("SipUserAgent")]
        [Validation(Required=false)]
        public string SipUserAgent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SipUserId")]
        [Validation(Required=false)]
        public string SipUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("SipUserPassword")]
        [Validation(Required=false)]
        public string SipUserPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>taskId</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
