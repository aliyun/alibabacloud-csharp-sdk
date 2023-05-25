// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks whether your AccessKey pair is valid, whether RAM users are granted permissions, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to restore the instance to its initial health state. This parameter is applicable to instances of instance families that are equipped with local disks, such as d1, i1, and i2 instances. If a local disk of a d1, i1, or i2 instance fails, you can use this parameter to restore the instance to its initial health state on startup. Valid values:
        /// 
        /// *   true: restores the instance to its initial health state on startup. After the instance is restored to its initial health state, data stored on the local disks of the instance is lost.
        /// *   false: does not restore the instance to its initial health state upon startup. The instance remains in its current state.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("InitLocalDisk")]
        [Validation(Required=false)]
        public bool? InitLocalDisk { get; set; }

        /// <summary>
        /// The ID of the instance that you want to start.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

    }

}
