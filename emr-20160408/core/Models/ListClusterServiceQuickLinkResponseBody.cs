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
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("QuickLinkAddress")]
                [Validation(Required=false)]
                public string QuickLinkAddress { get; set; }

                [NameInMap("ServiceDisplayName")]
                [Validation(Required=false)]
                public string ServiceDisplayName { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
