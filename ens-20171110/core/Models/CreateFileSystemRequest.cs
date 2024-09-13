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
        /// 
        /// This parameter is required.
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
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// The ID of the edge node.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// The name of the file system. The name must be 1 to 80 characters in length and can contain letters, digits, hyphens (-), and underscores (_).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// The name of the mount target. The name must be 1 to 80 characters in length and can contain letters, digits, hyphens (-), and underscores (_).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// The ID of the VPC.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// The type of the order. Set the value to BUY.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// The storage protocol. Valid values: nsf and smb.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The storage type. Valid values:
            /// 
            /// *   Capacity.
            /// *   Performance.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("StorgeType")]
            [Validation(Required=false)]
            public string StorgeType { get; set; }

        }

    }

}
