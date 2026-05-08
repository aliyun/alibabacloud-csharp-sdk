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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBClusterNetInfoResponseBodyItems Items { get; set; }
        public class DescribeDBClusterNetInfoResponseBodyItems : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeDBClusterNetInfoResponseBodyItemsAddress> Address { get; set; }
            public class DescribeDBClusterNetInfoResponseBodyItemsAddress : TeaModel {
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                [NameInMap("ConnectionStringPrefix")]
                [Validation(Required=false)]
                public string ConnectionStringPrefix { get; set; }

                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

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
