// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The network type of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        /// <summary>
        /// <para>The queried network information about the cluster.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoResponseBodyItems Items { get; set; }
        public class DescribeDBClusterNetInfoResponseBodyItems : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoResponseBodyItemsAddress> Address { get; set; }
            public class DescribeDBClusterNetInfoResponseBodyItemsAddress : TeaModel {
                /// <summary>
                /// <para>The endpoint of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am-bpxxxxxxxx.ads.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>The prefix of the cluster endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am-bpxxxxxxxx89k51380</para>
                /// </summary>
                [NameInMap("ConnectionStringPrefix")]
                [Validation(Required=false)]
                public string ConnectionStringPrefix { get; set; }

                /// <summary>
                /// <para>The IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.x.x</para>
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// <para>The network type of the cluster. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Public</b>: public endpoint.</description></item>
                /// <item><description><b>VPC</b>: Virtual Private Cloud (VPC) endpoint.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                /// <summary>
                /// <para>The port number that is used to connect to the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The VPC ID.</para>
                /// <remarks>
                /// <para> If NetType is set to Public, an empty string is returned for this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxxxxx</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// <remarks>
                /// <para> If NetType is set to Public, an empty string is returned for this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxxx</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
