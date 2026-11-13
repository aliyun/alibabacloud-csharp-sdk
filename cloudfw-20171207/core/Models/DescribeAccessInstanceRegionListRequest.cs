// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAccessInstanceRegionListRequest : TeaModel {
        /// <summary>
        /// <para>The status of the synchronization node. This parameter is used to filter by status.</para>
        /// <remarks>
        /// <para>Currently, only the &quot;created&quot; status is supported for filtering. Specifying other values (such as &quot;ready&quot;) will cause the request to fail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>created</para>
        /// </summary>
        [NameInMap("AccessInstanceStatus")]
        [Validation(Required=false)]
        public string AccessInstanceStatus { get; set; }

        /// <summary>
        /// <para>The type of the synchronization node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrivateDns</b>: Private DNS. If this parameter is not specified, the default value is PrivateDns.</para>
        /// </description></item>
        /// <item><description><para><b>AckClusterConnector</b>: ACK cluster connector.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AckClusterConnector</para>
        /// </summary>
        [NameInMap("AccessInstanceType")]
        [Validation(Required=false)]
        public string AccessInstanceType { get; set; }

    }

}
