// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConsumedServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
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
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("DockerApplication")]
                [Validation(Required=false)]
                public bool? DockerApplication { get; set; }

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

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5281053-08e4-47a5-b2ab-5c0323de7b5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
