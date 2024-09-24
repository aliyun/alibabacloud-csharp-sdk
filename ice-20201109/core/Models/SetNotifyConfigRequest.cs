// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SetNotifyConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("AIAgentId")]
        [Validation(Required=false)]
        public string AIAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://customer.com/callback">http://customer.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableNotify")]
        [Validation(Required=false)]
        public bool? EnableNotify { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent_start,agent_stop,error</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public string EventTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
