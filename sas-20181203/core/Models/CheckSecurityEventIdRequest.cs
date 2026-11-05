// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CheckSecurityEventIdRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the alert events to be verified. You can specify up to 100 alert event IDs. If this parameter is left empty, the verification result <b>Data</b> defaults to <b>false</b>, indicating that the events do not belong to the specified server.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to retrieve this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1234567&quot;,&quot;98765432&quot;]</para>
        /// </summary>
        [NameInMap("SecurityEventIds")]
        [Validation(Required=false)]
        public List<string> SecurityEventIds { get; set; }

        /// <summary>
        /// <para>The UUID of the server to be verified.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to retrieve this parameter.</para>
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
