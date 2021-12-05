// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateFullNatEntryRequest : TeaModel {
        /// <summary>
        /// 需要进行转发的后端IP
        /// </summary>
        [NameInMap("AccessIp")]
        [Validation(Required=false)]
        public string AccessIp { get; set; }

        /// <summary>
        /// 需要进行端口转发的内部端口，取值范围：1~65535。
        /// </summary>
        [NameInMap("AccessPort")]
        [Validation(Required=false)]
        public string AccessPort { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("FullNatEntryDescription")]
        [Validation(Required=false)]
        public string FullNatEntryDescription { get; set; }

        /// <summary>
        /// FULLNAT规则的名称。 长度为2~128个字符，必须以大小写字母或中文开头，但不能以http://或https://开头。
        /// </summary>
        [NameInMap("FullNatEntryName")]
        [Validation(Required=false)]
        public string FullNatEntryName { get; set; }

        /// <summary>
        /// FullNAT条目所属的FullNAT列表的ID。
        /// </summary>
        [NameInMap("FullNatTableId")]
        [Validation(Required=false)]
        public string FullNatTableId { get; set; }

        /// <summary>
        /// 协议类型，取值： • TCP：转发TCP协议的报文。 • UDP：转发UDP协议的报文。
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// 提供入方向访问的IP地址，该公网IP需要是当前VpcNat下的NatIP
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// 需要进行端口转发的外部端口，取值范围：1~65535。
        /// </summary>
        [NameInMap("NatIpPort")]
        [Validation(Required=false)]
        public string NatIpPort { get; set; }

        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
