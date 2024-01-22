// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListStaticsQueryResponse : TeaModel {
        [NameInMap("length")]
        [Validation(Required=false)]
        public long? Length { get; set; }

        [NameInMap("sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("statics")]
        [Validation(Required=false)]
        public List<StaticsInfo> Statics { get; set; }

    }

}
