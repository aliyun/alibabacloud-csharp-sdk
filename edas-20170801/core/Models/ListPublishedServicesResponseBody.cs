// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListPublishedServicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PublishedServicesList")]
        [Validation(Required=false)]
        public ListPublishedServicesResponseBodyPublishedServicesList PublishedServicesList { get; set; }
        public class ListPublishedServicesResponseBodyPublishedServicesList : TeaModel {
            [NameInMap("ListPublishedServices")]
            [Validation(Required=false)]
            public List<ListPublishedServicesResponseBodyPublishedServicesListListPublishedServices> ListPublishedServices { get; set; }
            public class ListPublishedServicesResponseBodyPublishedServicesListListPublishedServices : TeaModel {
                public string AppId { get; set; }
                public bool? DockerApplication { get; set; }
                public string Group2Ip { get; set; }
                public ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesGroups Groups { get; set; }
                public class ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesGroups : TeaModel {
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public List<string> Group { get; set; }

                }
                public ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesIps Ips { get; set; }
                public class ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesIps : TeaModel {
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }
                public string Name { get; set; }
                public string Type { get; set; }
                public string Version { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
