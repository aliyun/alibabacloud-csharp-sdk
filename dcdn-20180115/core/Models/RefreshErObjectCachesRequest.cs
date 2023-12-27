// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class RefreshErObjectCachesRequest : TeaModel {
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        [NameInMap("MergeDomainName")]
        [Validation(Required=false)]
        public string MergeDomainName { get; set; }

        [NameInMap("ObjectPath")]
        [Validation(Required=false)]
        public string ObjectPath { get; set; }

        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        [NameInMap("RoutineId")]
        [Validation(Required=false)]
        public string RoutineId { get; set; }

    }

}
