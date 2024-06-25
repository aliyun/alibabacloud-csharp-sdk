// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class UpdateSqlInstanceParamsRequest : TeaModel {
        [NameInMap("combineParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> CombineParam { get; set; }

        [NameInMap("dynamicParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> DynamicParam { get; set; }

        [NameInMap("kvpair")]
        [Validation(Required=false)]
        public Dictionary<string, object> Kvpair { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        [NameInMap("staticParam")]
        [Validation(Required=false)]
        public Dictionary<string, object> StaticParam { get; set; }

    }

}
