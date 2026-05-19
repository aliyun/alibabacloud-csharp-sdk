// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddFileProtectBindMachineRequest : TeaModel {
        [NameInMap("AlertUuids")]
        [Validation(Required=false)]
        public List<string> AlertUuids { get; set; }

        [NameInMap("BlockUuids")]
        [Validation(Required=false)]
        public List<string> BlockUuids { get; set; }

        [NameInMap("NoneUuids")]
        [Validation(Required=false)]
        public List<string> NoneUuids { get; set; }

    }

}
