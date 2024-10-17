// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeBlackListClientsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of clients and the status of each client. This parameter contains a JSON object, for example, {&quot;client1&quot;: &quot;EVICTING&quot;,&quot;client2&quot;:&quot;EVICTED&quot;}.</para>
        /// <para>Available client statuses include:</para>
        /// <list type="bullet">
        /// <item><description>EVICTING indicates that a client is being removed</description></item>
        /// <item><description>EVICTED indicates that a client is removed</description></item>
        /// <item><description>ACCEPTING indicates that the write access to the file system is being granted to a client</description></item>
        /// <item><description>ACCEPTABLE indicates that the write access to the file system is granted to a client</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;client1&quot;: &quot;EVICTING&quot;,&quot;client2&quot;:&quot;EVICTED&quot;}</para>
        /// </summary>
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public string Clients { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A70BEE5D-76D3-49FB-B58F-1F398211A5C3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
