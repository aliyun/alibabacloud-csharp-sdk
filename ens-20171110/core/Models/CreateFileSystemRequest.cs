// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateFileSystemRequest : TeaModel {
        /// <summary>
        /// <para>The information about the orders.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public List<CreateFileSystemRequestOrderDetails> OrderDetails { get; set; }
        public class CreateFileSystemRequestOrderDetails : TeaModel {
            /// <summary>
            /// <para>The billing method of the NAS file system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrePaid: subscription. This billing method is not supported.</description></item>
            /// <item><description>PostPaid: pay-as-you-go.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The ID of the edge node.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-suzhou-telecom</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The name of the file system. The name must be 1 to 80 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nasFile</para>
            /// </summary>
            [NameInMap("FileSystemName")]
            [Validation(Required=false)]
            public string FileSystemName { get; set; }

            /// <summary>
            /// <para>The name of the mount target. The name must be 1 to 80 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nasMount</para>
            /// </summary>
            [NameInMap("MountTargetDomain")]
            [Validation(Required=false)]
            public string MountTargetDomain { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-xxx</para>
            /// </summary>
            [NameInMap("NetworkId")]
            [Validation(Required=false)]
            public string NetworkId { get; set; }

            /// <summary>
            /// <para>The type of the order. Set the value to BUY.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUY</para>
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// <para>The storage protocol. Set the value to nfs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nfs</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The storage type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Capacity.</description></item>
            /// <item><description>Performance.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>capacity</para>
            /// </summary>
            [NameInMap("StorgeType")]
            [Validation(Required=false)]
            public string StorgeType { get; set; }

        }

    }

}
