// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceNetworkTypeRequest : TeaModel {
        /// <summary>
        /// The retention period of the original classic network address when you change the network type to VPC. Valid values: **14**, **30**, **60**, and **120**. Unit: days.
        /// 
        /// > This parameter is required when the **NetworkType** parameter is set to **VPC** and the **RetainClassic** parameter is set to **True**.
        /// </summary>
        [NameInMap("ClassicExpiredDays")]
        [Validation(Required=false)]
        public int? ClassicExpiredDays { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The network type to switch to. Valid value:
        /// 
        /// *   **VPC**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to retain the original classic network address when you change the network type to VPC. Valid values:
        /// 
        /// *   **True**: retains the original classic network address.
        /// *   **False**: does not retain the original classic network address.
        /// 
        /// > 
        /// 
        /// *   This parameter is required when the **NetworkType** parameter is set to **VPC**.
        /// 
        /// *   If you set this parameter to **True**, you must also specify the **ClassicExpiredDays** parameter.
        /// </summary>
        [NameInMap("RetainClassic")]
        [Validation(Required=false)]
        public string RetainClassic { get; set; }

        /// <summary>
        /// The ID of the vSwitch in the VPC.
        /// 
        /// > This parameter is required when the **NetworkType** parameter is set to **VPC**.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// 
        /// > This parameter is required when the **NetworkType** parameter is set to **VPC**.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// 可用区ID，您可以通过调用[DescribeRegions](https://help.aliyun.com/document_detail/61933.html)接口查询可用区ID。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
