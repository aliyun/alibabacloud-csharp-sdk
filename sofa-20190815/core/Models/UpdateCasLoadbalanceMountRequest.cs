// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateCasLoadbalanceMountRequest : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("MountMap")]
        [Validation(Required=false)]
        public List<UpdateCasLoadbalanceMountRequestMountMap> MountMap { get; set; }
        public class UpdateCasLoadbalanceMountRequestMountMap : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public long? Value { get; set; }

        }

    }

}
