// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterServiceQuickLinkResponseBody : TeaModel {
        [NameInMap("QuickLinkList")]
        [Validation(Required=false)]
        public ListClusterServiceQuickLinkResponseBodyQuickLinkList QuickLinkList { get; set; }
        public class ListClusterServiceQuickLinkResponseBodyQuickLinkList : TeaModel {
            [NameInMap("QuickLink")]
            [Validation(Required=false)]
            public List<ListClusterServiceQuickLinkResponseBodyQuickLinkListQuickLink> QuickLink { get; set; }
            public class ListClusterServiceQuickLinkResponseBodyQuickLinkListQuickLink : TeaModel {
                public string Port { get; set; }
                public string Protocol { get; set; }
                public string QuickLinkAddress { get; set; }
                public string ServiceDisplayName { get; set; }
                public string ServiceName { get; set; }
                public string Type { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
