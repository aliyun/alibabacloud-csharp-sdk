/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgx_dcap_server20200726.Models
{
    public class GetQeIdentityRequest : TeaModel {
        [NameInMap("AcsHost")]
        [Validation(Required=false)]
        public string AcsHost { get; set; }

        [NameInMap("ClientVpcId")]
        [Validation(Required=false)]
        public string ClientVpcId { get; set; }

    }

}
