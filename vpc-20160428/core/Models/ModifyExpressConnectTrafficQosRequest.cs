// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressConnectTrafficQosRequest : TeaModel {
        [NameInMap("AddInstanceList")]
        [Validation(Required=false)]
        public List<ModifyExpressConnectTrafficQosRequestAddInstanceList> AddInstanceList { get; set; }
        public class ModifyExpressConnectTrafficQosRequestAddInstanceList : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("QosDescription")]
        [Validation(Required=false)]
        public string QosDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        [NameInMap("QosName")]
        [Validation(Required=false)]
        public string QosName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RemoveInstanceList")]
        [Validation(Required=false)]
        public List<ModifyExpressConnectTrafficQosRequestRemoveInstanceList> RemoveInstanceList { get; set; }
        public class ModifyExpressConnectTrafficQosRequestRemoveInstanceList : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
