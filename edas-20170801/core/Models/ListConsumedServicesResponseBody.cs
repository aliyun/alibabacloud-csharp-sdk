// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConsumedServicesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The information about consumed services.
        /// </summary>
        [NameInMap("ConsumedServicesList")]
        [Validation(Required=false)]
        public ListConsumedServicesResponseBodyConsumedServicesList ConsumedServicesList { get; set; }
        public class ListConsumedServicesResponseBodyConsumedServicesList : TeaModel {
            [NameInMap("ListConsumedServices")]
            [Validation(Required=false)]
            public List<ListConsumedServicesResponseBodyConsumedServicesListListConsumedServices> ListConsumedServices { get; set; }
            public class ListConsumedServicesResponseBodyConsumedServicesListListConsumedServices : TeaModel {
                /// <summary>
                /// The ID of the application.
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// Indicates whether the application runs in a Docker container. Valid values:
                /// 
                /// *   true: The application runs in a Docker container.
                /// *   false: The application does not run in a Docker container.
                /// </summary>
                [NameInMap("DockerApplication")]
                [Validation(Required=false)]
                public bool? DockerApplication { get; set; }

                /// <summary>
                /// A reserved parameter.
                /// </summary>
                [NameInMap("Group2Ip")]
                [Validation(Required=false)]
                public string Group2Ip { get; set; }

                [NameInMap("Groups")]
                [Validation(Required=false)]
                public ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesGroups Groups { get; set; }
                public class ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesGroups : TeaModel {
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public List<string> Group { get; set; }

                }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesIps Ips { get; set; }
                public class ListConsumedServicesResponseBodyConsumedServicesListListConsumedServicesIps : TeaModel {
                    [NameInMap("ip")]
                    [Validation(Required=false)]
                    public List<string> Ip { get; set; }

                }

                /// <summary>
                /// The name of the consumed service.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the consumed service.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The version of the consumed service.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
