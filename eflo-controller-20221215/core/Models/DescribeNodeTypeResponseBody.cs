// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of cloud disks that can be mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("DiskQuantity")]
        [Validation(Required=false)]
        public int? DiskQuantity { get; set; }

        /// <summary>
        /// <para>The maximum number of network interface controllers (NICs) in high-density mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("EniHighDenseQuantity")]
        [Validation(Required=false)]
        public int? EniHighDenseQuantity { get; set; }

        /// <summary>
        /// <para>The maximum number of IPv6 addresses supported by a NIC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("EniIpv6AddressQuantity")]
        [Validation(Required=false)]
        public int? EniIpv6AddressQuantity { get; set; }

        /// <summary>
        /// <para>The maximum number of IPv4 addresses supported by a NIC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("EniPrivateIpAddressQuantity")]
        [Validation(Required=false)]
        public int? EniPrivateIpAddressQuantity { get; set; }

        /// <summary>
        /// <para>The maximum number of elastic network interfaces (ENIs) supported, including primary and secondary ENIs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("EniQuantity")]
        [Validation(Required=false)]
        public int? EniQuantity { get; set; }

        /// <summary>
        /// <para>The number of Elastic RDMA Interfaces (ERIs) for the current specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("EriQuantity")]
        [Validation(Required=false)]
        public int? EriQuantity { get; set; }

        /// <summary>
        /// <para>The number of physical network interface controllers (NICs) supported by the instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NetworkCardQuantity")]
        [Validation(Required=false)]
        public int? NetworkCardQuantity { get; set; }

        /// <summary>
        /// <para>The list of physical network interface controllers (NICs), including the details of each physical NIC.</para>
        /// </summary>
        [NameInMap("NetworkCards")]
        [Validation(Required=false)]
        public List<DescribeNodeTypeResponseBodyNetworkCards> NetworkCards { get; set; }
        public class DescribeNodeTypeResponseBodyNetworkCards : TeaModel {
            /// <summary>
            /// <para>The index of the physical network interface controller (NIC), starting from 0. You can specify this index to attach elastic network interfaces (ENIs) to different underlying physical network interface controllers (NICs).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NetworkCardIndex")]
            [Validation(Required=false)]
            public int? NetworkCardIndex { get; set; }

        }

        /// <summary>
        /// <para>The default number of queues for the primary NIC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("PrimaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? PrimaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The number of queue pairs (QPs) for all Elastic RDMA Interfaces (ERIs) of the current specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("QueuePairNumber")]
        [Validation(Required=false)]
        public int? QueuePairNumber { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FD06DF0-9167-5C6F-A145-F30CA4A15D54</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The default number of queues for secondary elastic network interfaces (ENIs).</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("SecondaryEniQueueNumber")]
        [Validation(Required=false)]
        public int? SecondaryEniQueueNumber { get; set; }

        /// <summary>
        /// <para>The total queue quota for elastic network interface controllers (NICs) of the current specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("TotalEniQueueQuantity")]
        [Validation(Required=false)]
        public int? TotalEniQueueQuantity { get; set; }

    }

}
