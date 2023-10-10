// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetContainerConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The Tomcat configuration.
        /// </summary>
        [NameInMap("ContainerConfiguration")]
        [Validation(Required=false)]
        public GetContainerConfigurationResponseBodyContainerConfiguration ContainerConfiguration { get; set; }
        public class GetContainerConfigurationResponseBodyContainerConfiguration : TeaModel {
            /// <summary>
            /// The context path of the Tomcat container.
            /// </summary>
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }

            /// <summary>
            /// The application port number for the Tomcat container. The value specified in the application configuration is returned.
            /// </summary>
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            /// <summary>
            /// The maximum number of threads in the Tomcat container.
            /// 
            /// *   If no instance group is specified, the configuration of the application is returned.
            /// *   If no application is specified, the default configuration is returned.
            /// </summary>
            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public int? MaxThreads { get; set; }

            /// <summary>
            /// The Uniform Resource Identifier (URI) encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8.
            /// 
            /// *   If no instance group is specified, the configuration of the application is returned.
            /// *   If no application is specified, the default configuration is returned.
            /// </summary>
            [NameInMap("URIEncoding")]
            [Validation(Required=false)]
            public string URIEncoding { get; set; }

            /// <summary>
            /// Indicates whether useBodyEncodingForURI is enabled in the Tomcat container.
            /// 
            /// *   If no instance group is specified, the configuration of the application is returned.
            /// *   If no application is specified, the default configuration is returned.
            /// </summary>
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

        }

        /// <summary>
        /// The message returned for the request.
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
