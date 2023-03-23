// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyVpcAccessAndUpdateApisRequest : TeaModel {
        /// <summary>
        /// The ID of the new instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the VPC authorization.
        /// 
        /// > 
        /// 
        /// *   The name of a VPC authorization cannot be changed. You cannot use this parameter to change the name of a VPC authorization.
        /// 
        /// *   You must set this parameter to the name of the current VPC authorization.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Specifies whether to update the associated API.
        /// 
        /// **
        /// 
        /// **Warning:** If you want to update the VPC authorization of a published API, you must set this parameter to true. Otherwise, the update will not be synchronized to the backend service of the API.
        /// </summary>
        [NameInMap("NeedBatchWork")]
        [Validation(Required=false)]
        public bool? NeedBatchWork { get; set; }

        /// <summary>
        /// The new port number.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Specifies whether to update the VPC authorization.
        /// 
        /// > 
        /// 
        /// *   If the ID of the instance in your VPC is changed but the IP address of the instance remains unchanged, you can set this parameter to true to update the VPC authorization.
        /// </summary>
        [NameInMap("Refresh")]
        [Validation(Required=false)]
        public bool? Refresh { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The token of the request.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The ID of the new VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The hostname of the backend service.
        /// </summary>
        [NameInMap("VpcTargetHostName")]
        [Validation(Required=false)]
        public string VpcTargetHostName { get; set; }

    }

}
