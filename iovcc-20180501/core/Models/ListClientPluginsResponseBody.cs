// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListClientPluginsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientPlugins")]
        [Validation(Required=false)]
        public List<ListClientPluginsResponseBodyClientPlugins> ClientPlugins { get; set; }
        public class ListClientPluginsResponseBodyClientPlugins : TeaModel {
            [NameInMap("PkgName")]
            [Validation(Required=false)]
            public string PkgName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
