// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetContainerConfigurationResponseBody : TeaModel {
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
        /// <para>The Tomcat configuration.</para>
        /// </summary>
        [NameInMap("ContainerConfiguration")]
        [Validation(Required=false)]
        public GetContainerConfigurationResponseBodyContainerConfiguration ContainerConfiguration { get; set; }
        public class GetContainerConfigurationResponseBodyContainerConfiguration : TeaModel {
            /// <summary>
            /// <para>The context path of the Tomcat container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }

            /// <summary>
            /// <para>The application port number for the Tomcat container. The value specified in the application configuration is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            /// <summary>
            /// <para>The maximum number of threads in the Tomcat container.</para>
            /// <list type="bullet">
            /// <item><description>If no instance group is specified, the configuration of the application is returned.</description></item>
            /// <item><description>If no application is specified, the default configuration is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>400</para>
            /// </summary>
            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public int? MaxThreads { get; set; }

            /// <summary>
            /// <para>The Uniform Resource Identifier (URI) encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8.</para>
            /// <list type="bullet">
            /// <item><description>If no instance group is specified, the configuration of the application is returned.</description></item>
            /// <item><description>If no application is specified, the default configuration is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ISO-8859-1</para>
            /// </summary>
            [NameInMap("URIEncoding")]
            [Validation(Required=false)]
            public string URIEncoding { get; set; }

            /// <summary>
            /// <para>Indicates whether useBodyEncodingForURI is enabled in the Tomcat container.</para>
            /// <list type="bullet">
            /// <item><description>If no instance group is specified, the configuration of the application is returned.</description></item>
            /// <item><description>If no application is specified, the default configuration is returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
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
        /// <para>34F8-FDG9-*****************</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
