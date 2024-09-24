// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DescribeNotifyConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://customer.com/callback">http://customer.com/callback</a></para>
        /// </summary>
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
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
        /// <para>7B117AF5-2A16-412C-B127-FA6175ED1AD0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJhcHBpZCI6ICIxMjM0MTIzNxxxxx</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
