// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class PrivilegeResource : TeaModel {
        [NameInMap("Access")]
        [Validation(Required=false)]
        public string Access { get; set; }

        [NameInMap("MetaResource")]
        [Validation(Required=false)]
        public MetaResource MetaResource { get; set; }

    }

}
