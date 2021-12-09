// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class ExtendBucketWormRequest : TeaModel {
        [NameInMap("extendWormConfiguration")]
        [Validation(Required=false)]
        public ExtendWormConfiguration ExtendWormConfiguration { get; set; }

        [NameInMap("wormId")]
        [Validation(Required=false)]
        public string WormId { get; set; }

    }

}
