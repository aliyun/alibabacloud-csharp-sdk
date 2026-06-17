// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterProxyResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of network instances loaded by the Cloud Enterprise Network (CEN) instance.</para>
        /// </summary>
        [NameInMap("ChildInstances")]
        [Validation(Required=false)]
        public List<DescribeDBClusterProxyResponseBodyChildInstances> ChildInstances { get; set; }
        public class DescribeDBClusterProxyResponseBodyChildInstances : TeaModel {
            /// <summary>
            /// <para>The node specifications. For more information, see the following documents:</para>
            /// <list type="bullet">
            /// <item><description><para>PolarDB for MySQL: <a href="https://help.aliyun.com/document_detail/102542.html">Compute node specifications</a>.</para>
            /// </description></item>
            /// <item><description><para>PolarDB for Oracle: <a href="https://help.aliyun.com/document_detail/207921.html">Compute node specifications</a>.</para>
            /// </description></item>
            /// <item><description><para>PolarDB for PostgreSQL: <a href="https://help.aliyun.com/document_detail/209380.html">Compute node specifications</a>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>polar.mysql.g4.medium</para>
            /// </summary>
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }

            /// <summary>
            /// <para>The private IP address of the database cluster node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.*.*10</para>
            /// </summary>
            [NameInMap("DBNodeIP")]
            [Validation(Required=false)]
            public string DBNodeIP { get; set; }

            /// <summary>
            /// <para>The ID of the database cluster node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-wz97h479y364g9du7</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The port of the database cluster node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2450</para>
            /// </summary>
            [NameInMap("DBNodePort")]
            [Validation(Required=false)]
            public string DBNodePort { get; set; }

            /// <summary>
            /// <para>The status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The node is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Running</b>: The node is running.</para>
            /// </description></item>
            /// <item><description><para><b>Deleting</b>: The node is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>Rebooting</b>: The node is being restarted.</para>
            /// </description></item>
            /// <item><description><para><b>DBNodeCreating</b>: A node is being added.</para>
            /// </description></item>
            /// <item><description><para><b>DBNodeDeleting</b>: A node is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>ClassChanging</b>: The node specifications are being changed.</para>
            /// </description></item>
            /// <item><description><para><b>NetAddressCreating</b>: A network connection is being created.</para>
            /// </description></item>
            /// <item><description><para><b>NetAddressDeleting</b>: A network connection is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>NetAddressModifying</b>: A network connection is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>MinorVersionUpgrading</b>: The minor version is being upgraded.</para>
            /// </description></item>
            /// <item><description><para><b>Maintaining</b>: The instance is being maintained.</para>
            /// </description></item>
            /// <item><description><para><b>Switching</b>: A switchover is in progress.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBNodeStatus")]
            [Validation(Required=false)]
            public string DBNodeStatus { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sh-lsf01-144-37</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

        }

        /// <summary>
        /// <para>The proxy cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pe-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBProxyClusterId")]
        [Validation(Required=false)]
        public string DBProxyClusterId { get; set; }

        /// <summary>
        /// <para>The number of proxy nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBProxyClusterNum")]
        [Validation(Required=false)]
        public long? DBProxyClusterNum { get; set; }

        /// <summary>
        /// <para>The status of the proxy cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClassChanging</para>
        /// </summary>
        [NameInMap("DBProxyClusterStatus")]
        [Validation(Required=false)]
        public string DBProxyClusterStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30E11ED2-C922-5B96-BCC6-11EE8C484AC6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
