// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteCompliancePacksRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CompliancePackIds")]
        [Validation(Required=false)]
        public string CompliancePackIds { get; set; }

        [NameInMap("DeleteRule")]
        [Validation(Required=false)]
        public bool? DeleteRule { get; set; }

    }

}
