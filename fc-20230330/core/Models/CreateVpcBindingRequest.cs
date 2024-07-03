// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CreateVpcBindingRequest : TeaModel {
        /// <summary>
        /// The configurations of the virtual private cloud (VPC) binding.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateVpcBindingInput Body { get; set; }

    }

}
