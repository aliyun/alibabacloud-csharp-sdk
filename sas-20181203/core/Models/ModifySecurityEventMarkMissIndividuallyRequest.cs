// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySecurityEventMarkMissIndividuallyRequest : TeaModel {
        [NameInMap("DeleteMarkMissParam")]
        [Validation(Required=false)]
        public string DeleteMarkMissParam { get; set; }

        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        [NameInMap("InsertMarkMissParam")]
        [Validation(Required=false)]
        public string InsertMarkMissParam { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
