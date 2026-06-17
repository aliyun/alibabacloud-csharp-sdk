// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAccessInstanceRegionListRequest : TeaModel {
        /// <summary>
        /// <para>The status of the synchronization node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ready</para>
        /// </summary>
        [NameInMap("AccessInstanceStatus")]
        [Validation(Required=false)]
        public string AccessInstanceStatus { get; set; }

        /// <summary>
        /// <para>The type of the synchronization node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PrivateDns</b>: private DNS.</para>
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
