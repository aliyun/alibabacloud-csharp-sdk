// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ImportLinkedeploycoreDeploycoreAppserviceRequest : TeaModel {
        [NameInMap("ApplyOwner")]
        [Validation(Required=false)]
        public string ApplyOwner { get; set; }

        [NameInMap("AppServicesRepeatList")]
        [Validation(Required=false)]
        public List<string> AppServicesRepeatList { get; set; }

        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("IterationId")]
        [Validation(Required=false)]
        public string IterationId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
