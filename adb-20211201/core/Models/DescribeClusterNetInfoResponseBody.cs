// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeClusterNetInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The network type of the cluster. The value is always <b>VPC</b>, as this is the only supported network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ClusterNetworkType")]
        [Validation(Required=false)]
        public string ClusterNetworkType { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeClusterNetInfoResponseBodyItems Items { get; set; }
        public class DescribeClusterNetInfoResponseBodyItems : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public List<DescribeClusterNetInfoResponseBodyItemsAddress> Address { get; set; }
            public class DescribeClusterNetInfoResponseBodyItemsAddress : TeaModel {
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

                [NameInMap("Ports")]
                [Validation(Required=false)]
                public DescribeClusterNetInfoResponseBodyItemsAddressPorts Ports { get; set; }
                public class DescribeClusterNetInfoResponseBodyItemsAddressPorts : TeaModel {
                    [NameInMap("ports")]
                    [Validation(Required=false)]
                    public List<DescribeClusterNetInfoResponseBodyItemsAddressPortsPorts> Ports { get; set; }
                    public class DescribeClusterNetInfoResponseBodyItemsAddressPortsPorts : TeaModel {
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public string Port { get; set; }

                        [NameInMap("Protocol")]
                        [Validation(Required=false)]
                        public string Protocol { get; set; }

                    }

                }

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
        /// <para>69A29B65-CD0C-52B1-BE42-8B454569747F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
