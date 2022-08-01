// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EncryptUserCmkConf : TeaModel {
        [NameInMap("arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("cmk_key_id")]
        [Validation(Required=false)]
        public string CmkKeyId { get; set; }

        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
