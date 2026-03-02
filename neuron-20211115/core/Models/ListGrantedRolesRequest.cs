// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListGrantedRolesRequest : TeaModel {
        [NameInMap("authorizerId")]
        [Validation(Required=false)]
        public string AuthorizerId { get; set; }

        [NameInMap("authorizerType")]
        [Validation(Required=false)]
        public string AuthorizerType { get; set; }

        [NameInMap("enterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
