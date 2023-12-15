// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class ChainPurposeInfoAli : TeaModel {
        [NameInMap("ChainPurposeExtend")]
        [Validation(Required=false)]
        public string ChainPurposeExtend { get; set; }

        [NameInMap("ChainPurposeItem")]
        [Validation(Required=false)]
        public string ChainPurposeItem { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Purpose")]
        [Validation(Required=false)]
        public string Purpose { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
