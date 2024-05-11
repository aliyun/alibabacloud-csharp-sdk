// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ValidateVpcConnectivityRequest : TeaModel {
        /// <summary>
        /// The ID of the API Gateway instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the VPC access authorization.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcAccessId")]
        [Validation(Required=false)]
        public string VpcAccessId { get; set; }

    }

}
