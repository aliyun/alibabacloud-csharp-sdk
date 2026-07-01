// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeNotifyConfigResponseBody : TeaModel {
        [NameInMap("AudioOssPath")]
        [Validation(Required=false)]
        public string AudioOssPath { get; set; }

        /// <summary>
        /// <para>The URL where event callbacks are sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://customer.com/callback">http://customer.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("EnableAudioRecording")]
        [Validation(Required=false)]
        public bool? EnableAudioRecording { get; set; }

        /// <summary>
        /// <para>Indicates whether notifications are enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNotify")]
        [Validation(Required=false)]
        public bool? EnableNotify { get; set; }

        /// <summary>
        /// <para>The event types. If you do not specify this parameter, all event types are selected by default.</para>
        /// <list type="bullet">
        /// <item><description><para><c>agent_start</c>: The agent is ready.</para>
        /// </description></item>
        /// <item><description><para><c>agent_stop</c>: The agent is stopped.</para>
        /// </description></item>
        /// <item><description><para><c>error</c>: The task encountered an error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agent_start,agent_stop,error</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public string EventTypes { get; set; }

        /// <summary>
        /// <para>The unique identifier for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B117AF5-2A16-412C-B127-FA6175ED1AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The authentication token used to verify the callback. This token is included in the <c>Authorization</c> field of the request header for each event callback.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
