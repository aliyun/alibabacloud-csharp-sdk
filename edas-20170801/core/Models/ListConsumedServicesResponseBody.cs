// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListConsumedServicesResponseBody : TeaModel {
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
        /// <para>The information about consumed services.</para>
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
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a5281053-08e4-47a5-b2ab-5c0323de7b5a</para>
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
                /// <para>true</para>
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
                /// <para>The name of the consumed service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>service</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The type of the consumed service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HSF</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The version of the consumed service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a5281053-08e4-47a5-b2ab-5c0323de7b5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
