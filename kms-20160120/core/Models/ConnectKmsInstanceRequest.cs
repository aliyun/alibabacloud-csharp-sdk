// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ConnectKmsInstanceRequest : TeaModel {
        /// <summary>
        /// The provider of the KMS instance. Set the value to Aliyun.
        /// </summary>
        [NameInMap("KMProvider")]
        [Validation(Required=false)]
        public string KMProvider { get; set; }

        /// <summary>
        /// The ID of the KMS instance that you want to enable.
        /// </summary>
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

        /// <summary>
        /// The vSwitch in the two zones. The vSwitch must have at least one available IP address.
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) that is associated with the KMS instance.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The two zones for the KMS instance. Dual-zone deployment improves service availability and disaster recovery capabilities.
        /// </summary>
        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public string ZoneIds { get; set; }

    }

}
