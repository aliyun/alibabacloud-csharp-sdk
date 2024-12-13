// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class SendMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique message ID that is returned by the ApsaraMQ for MQTT broker after the message is sent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B736D997B7F45FF54E61C1C1B58****</para>
        /// </summary>
        [NameInMap("MsgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

        /// <summary>
        /// <para>The unique ID that the system generates for the request. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>020F6A43-19E6-4B6E-B846-44EB31DF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
