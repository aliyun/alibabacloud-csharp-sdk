// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateInstanceRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StorageMaxDays")]
        [Validation(Required=false)]
        public int? StorageMaxDays { get; set; }

        [NameInMap("StorageMaxSize")]
        [Validation(Required=false)]
        public int? StorageMaxSize { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("AdminRamId")]
        [Validation(Required=false)]
        public List<string> AdminRamId { get; set; }

        [NameInMap("PhoneNumbers")]
        [Validation(Required=false)]
        public List<string> PhoneNumbers { get; set; }

        [NameInMap("UserObject")]
        [Validation(Required=false)]
        public List<string> UserObject { get; set; }

    }

}
