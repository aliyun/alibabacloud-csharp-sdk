// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ChangeCheckCustomConfigRequest : TeaModel {
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        [NameInMap("CustomConfigs")]
        [Validation(Required=false)]
        public List<ChangeCheckCustomConfigRequestCustomConfigs> CustomConfigs { get; set; }
        public class ChangeCheckCustomConfigRequestCustomConfigs : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
