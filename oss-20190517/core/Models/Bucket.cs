// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class Bucket : TeaModel {
        [NameInMap("CreationDate")]
        [Validation(Required=false)]
        public string CreationDate { get; set; }

        [NameInMap("ExtranetEndpoint")]
        [Validation(Required=false)]
        public string ExtranetEndpoint { get; set; }

        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
