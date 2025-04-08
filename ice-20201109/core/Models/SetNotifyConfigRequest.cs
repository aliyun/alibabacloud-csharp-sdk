// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AI agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        [NameInMap("AudioOssPath")]
        [Validation(Required=false)]
        public string AudioOssPath { get; set; }

        /// <summary>
        /// <para>The URL for receiving callback notifications. By default, this parameter is left empty.</para>
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
        /// <para>Specifies whether to enable event notifications.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNotify")]
        [Validation(Required=false)]
        public bool? EnableNotify { get; set; }

        /// <summary>
        /// <para>The event types. If you do not specify this parameter, all event types are selected.</para>
        /// <list type="bullet">
        /// <item><description>agent_start</description></item>
        /// <item><description>agent_stop</description></item>
        /// <item><description>error</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agent_start,agent_stop,error</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public string EventTypes { get; set; }

        /// <summary>
        /// <para>The authentication token for callback. The token is carried in the Authorization header of a callback request. By default, this parameter is left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
