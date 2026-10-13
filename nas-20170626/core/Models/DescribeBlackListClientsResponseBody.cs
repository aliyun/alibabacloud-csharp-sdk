// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeBlackListClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The eviction status of clients. The value is a JSON string in the map format: <c>{&quot;client1&quot;: &quot;EVICTING&quot;,&quot;client2&quot;:&quot;EVICTED&quot;}</c>.</para>
        /// <para>Valid values for client eviction status:</para>
        /// <list type="bullet">
        /// <item><description>EVICTING: The client is being evicted.</description></item>
        /// <item><description>EVICTED: The client has been evicted.</description></item>
        /// <item><description>ACCEPTING: The client is being resumed. </description></item>
        /// <item><description>ACCEPTABLE: The client has been resumed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;client1&quot;: &quot;EVICTING&quot;,&quot;client2&quot;:&quot;EVICTED&quot;}</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public string Clients { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A70BEE5D-76D3-49FB-B58F-1F398211A5C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
