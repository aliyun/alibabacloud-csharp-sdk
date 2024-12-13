// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QuerySessionByClientIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the ApsaraMQ for MQTT client is connected to the ApsaraMQ for MQTT broker. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlineStatus")]
        [Validation(Required=false)]
        public bool? OnlineStatus { get; set; }

        /// <summary>
        /// <para>The request ID. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4581CCF-62AF-44D9-B5B4-D1DBBC0E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
