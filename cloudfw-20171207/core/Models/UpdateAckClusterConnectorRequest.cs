// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class UpdateAckClusterConnectorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACK cluster connector. You can call the <a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a> operation to query the list of ACK cluster connectors.</para>
        /// <list type="bullet">
        /// <item><description><a href="~~DescribeAckClusterConnectors~~">DescribeAckClusterConnectors</a>: Queries a list of ACK cluster connectors.</description></item>
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
        /// <para>The name of the ACK cluster connector. The name must be 1 to 64 characters in length and can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-cluster-connector-name</para>
        /// </summary>
        [NameInMap("ConnectorName")]
        [Validation(Required=false)]
        public string ConnectorName { get; set; }

        /// <summary>
        /// <para>The synchronization interval for the ACK cluster connector. Valid values: 2 to 60. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public string Ttl { get; set; }

    }

}
