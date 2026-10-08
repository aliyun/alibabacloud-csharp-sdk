// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListPublishedServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
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
                public ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesGroups Groups { get; set; }
                public class ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesGroups : TeaModel {
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public List<string> Group { get; set; }

                }

                [NameInMap("Ips")]
                [Validation(Required=false)]
                public ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesIps Ips { get; set; }
                public class ListPublishedServicesResponseBodyPublishedServicesListListPublishedServicesIps : TeaModel {
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
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D6FC-4307-4583-BA6F-215F3857E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
