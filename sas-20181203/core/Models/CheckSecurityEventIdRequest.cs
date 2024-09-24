// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckSecurityEventIdRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of alert events. You can specify up to 100 IDs. If you do not specify this parameter, the value of the response parameter <b>Data</b> is <b>false</b>. The value false indicates that no alert events are generated on the server.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to query the IDs of alert events.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1234567&quot;,&quot;98765432&quot;]</para>
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<string> SecurityEventIds { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96ad2473-bc60-45ba-ad1c-932e2866****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
