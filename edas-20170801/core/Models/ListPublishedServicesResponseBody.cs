// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListPublishedServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The message that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The published services.</para>
        /// </summary>
        [NameInMap("PublishedServicesList")]
        [Validation(Required=false)]
        public ListPublishedServicesResponseBodyPublishedServicesList PublishedServicesList { get; set; }
        public class ListPublishedServicesResponseBodyPublishedServicesList : TeaModel {
            [NameInMap("ListPublishedServices")]
            [Validation(Required=false)]
            public List<ListPublishedServicesResponseBodyPublishedServicesListListPublishedServices> ListPublishedServices { get; set; }
            public class ListPublishedServicesResponseBodyPublishedServicesListListPublishedServices : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECD1D6FC-4307-4583-BA6F-215F3857E****</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>Indicates whether the application runs in a Docker container. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The application runs in a Docker container.</description></item>
                /// <item><description>false: The application does not run in a Docker container.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DockerApplication")]
                [Validation(Required=false)]
                public bool? DockerApplication { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
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

                /// <summary>
                /// <para>The name of the published service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>providers:com.****</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the published service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RESTful</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the published services.</para>
                /// 
                /// <b>Example:</b>
                /// <para>--</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D6FC-4307-4583-BA6F-215F3857E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
