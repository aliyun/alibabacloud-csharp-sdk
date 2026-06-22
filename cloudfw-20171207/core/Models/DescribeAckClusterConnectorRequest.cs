// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAckClusterConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACK cluster connector. You can obtain the value from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a>: Lists ACK cluster connectors.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-7c1bad6c3cc84c33baab</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <para>The language in which the health status error reason of the ACK cluster connector is displayed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
