// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTDependenciesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<ListDSTDependenciesResponseBodyDependencies> Dependencies { get; set; }
        public class ListDSTDependenciesResponseBodyDependencies : TeaModel {
            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Info")]
            [Validation(Required=false)]
            public List<ListDSTDependenciesResponseBodyDependenciesInfo> Info { get; set; }
            public class ListDSTDependenciesResponseBodyDependenciesInfo : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
