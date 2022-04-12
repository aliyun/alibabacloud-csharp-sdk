// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConsumedServicesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ConsumedServicesList")]
        [Validation(Required=false)]
        public ListConsumedServicesResponseBodyConsumedServicesList ConsumedServicesList { get; set; }
        public class ListConsumedServicesResponseBodyConsumedServicesList : TeaModel {
            [NameInMap("ListConsumedServices")]
            [Validation(Required=false)]
            public List<ListConsumedServicesResponseBodyConsumedServicesListListConsumedServices> ListConsumedServices { get; set; }
            public class ListConsumedServicesResponseBodyConsumedServicesListListConsumedServices : TeaModel {
                public string AppId { get; set; }
                public bool? DockerApplication { get; set; }
                public string Group2Ip { get; set; }
                public ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesGroups Groups { get; set; }
                public class ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesGroups : TeaModel {
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public List<string> Group { get; set; }

                }
                public ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesIps Ips { get; set; }
                public class ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesIps : TeaModel {
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }
                public string Name { get; set; }
                public string Type { get; set; }
                public string Version { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
