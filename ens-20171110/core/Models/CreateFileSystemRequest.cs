// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemRequest : TeaModel {
        /// <summary>
        /// The information about the orders.
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public List<CreateFileSystemRequestOrderDetails> OrderDetails { get; set; }
        public class CreateFileSystemRequestOrderDetails : TeaModel {
            /// <summary>
            /// The billing method of the NAS file system. Valid values:
            /// 
            /// *   PrePaid: subscription. This billing method is not supported.
            /// *   PostPaid: pay-as-you-go.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The ID of the node.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The name of the file system.
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// The name of the mount target.
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// The type of the order.
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// The storage protocol. Valid values: nsf and smb.
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The type of the storage. Set the value to capacity.
            /// </summary>
            [NameInMap("StorgeType")]
            [Validation(Required=false)]
            public string StorgeType { get; set; }

        }

    }

}
