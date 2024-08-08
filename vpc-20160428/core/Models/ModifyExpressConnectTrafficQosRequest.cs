// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyExpressConnectTrafficQosRequest : TeaModel {
        /// <summary>
        /// The instances to be added. Ignore this parameter if no instances are to be added.
        /// </summary>
        [NameInMap("AddInstanceList")]
        [Validation(Required=false)]
        public List<ModifyExpressConnectTrafficQosRequestAddInstanceList> AddInstanceList { get; set; }
        public class ModifyExpressConnectTrafficQosRequestAddInstanceList : TeaModel {
            /// <summary>
            /// The ID of the instance to be associated.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of instance to be associated. Set the value to **PHYSICALCONNECTION**.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The description of the QoS policy.
        /// </summary>
        [NameInMap("QosDescription")]
        [Validation(Required=false)]
        public string QosDescription { get; set; }

        /// <summary>
        /// The ID of the QoS policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// The name of the QoS policy.
        /// </summary>
        [NameInMap("QosName")]
        [Validation(Required=false)]
        public string QosName { get; set; }

        /// <summary>
        /// The region ID of the resource.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The instances to be removed. Ignore this parameter if no instances are to be removed.
        /// </summary>
        [NameInMap("RemoveInstanceList")]
        [Validation(Required=false)]
        public List<ModifyExpressConnectTrafficQosRequestRemoveInstanceList> RemoveInstanceList { get; set; }
        public class ModifyExpressConnectTrafficQosRequestRemoveInstanceList : TeaModel {
            /// <summary>
            /// The ID of the associated instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the associated instance. Set the value to **PHYSICALCONNECTION**.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
