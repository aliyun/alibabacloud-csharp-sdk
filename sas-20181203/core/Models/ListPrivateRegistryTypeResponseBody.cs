// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListPrivateRegistryTypeResponseBody : TeaModel {
        [NameInMap("RegistryTypeInfos")]
        [Validation(Required=false)]
        public List<ListPrivateRegistryTypeResponseBodyRegistryTypeInfos> RegistryTypeInfos { get; set; }
        public class ListPrivateRegistryTypeResponseBodyRegistryTypeInfos : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
