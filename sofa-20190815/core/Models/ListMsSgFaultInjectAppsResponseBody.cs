// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListMsSgFaultInjectAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartIndex")]
        [Validation(Required=false)]
        public long? StartIndex { get; set; }

        [NameInMap("TotalSize")]
        [Validation(Required=false)]
        public long? TotalSize { get; set; }

        [NameInMap("AppNames")]
        [Validation(Required=false)]
        public List<ListMsSgFaultInjectAppsResponseBodyAppNames> AppNames { get; set; }
        public class ListMsSgFaultInjectAppsResponseBodyAppNames : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("RuleNum")]
            [Validation(Required=false)]
            public long? RuleNum { get; set; }

        }

    }

}
