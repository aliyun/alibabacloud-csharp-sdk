// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConfigCentersResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ConfigCentersList")]
        [Validation(Required=false)]
        public ListConfigCentersResponseBodyConfigCentersList ConfigCentersList { get; set; }
        public class ListConfigCentersResponseBodyConfigCentersList : TeaModel {
            [NameInMap("ListConfigCenters")]
            [Validation(Required=false)]
            public List<ListConfigCentersResponseBodyConfigCentersListListConfigCenters> ListConfigCenters { get; set; }
            public class ListConfigCentersResponseBodyConfigCentersListListConfigCenters : TeaModel {
                public string AppName { get; set; }
                public string DataId { get; set; }
                public string Id { get; set; }
                public string Group { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
