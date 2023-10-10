// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetWebContainerConfigResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
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

        /// <summary>
        /// The Tomcat configurations of the application.
        /// </summary>
        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public GetWebContainerConfigResponseBodyWebContainerConfig WebContainerConfig { get; set; }
        public class GetWebContainerConfigResponseBodyWebContainerConfig : TeaModel {
            /// <summary>
            /// The type of the context path.
            /// </summary>
            [NameInMap("ContextInputType")]
            [Validation(Required=false)]
            public string ContextInputType { get; set; }

            /// <summary>
            /// The context path.
            /// </summary>
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }

            /// <summary>
            /// The HTTP service port.
            /// </summary>
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }

            /// <summary>
            /// The maximum number of threads.
            /// </summary>
            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public int? MaxThreads { get; set; }

            /// <summary>
            /// The content of the server.xml file customized by using advanced configurations.
            /// </summary>
            [NameInMap("ServerXml")]
            [Validation(Required=false)]
            public string ServerXml { get; set; }

            /// <summary>
            /// The URI encoding scheme.
            /// </summary>
            [NameInMap("UriEncoding")]
            [Validation(Required=false)]
            public string UriEncoding { get; set; }

            /// <summary>
            /// Indicates whether advanced configurations are used to customize the server.xml file.
            /// </summary>
            [NameInMap("UseAdvancedServerXml")]
            [Validation(Required=false)]
            public bool? UseAdvancedServerXml { get; set; }

            /// <summary>
            /// Indicates whether the encoding scheme specified in the request body is used for uniform resource identifier (URI) query parameters.
            /// </summary>
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

            /// <summary>
            /// Indicates whether the default configurations are used.
            /// </summary>
            [NameInMap("UseDefaultConfig")]
            [Validation(Required=false)]
            public bool? UseDefaultConfig { get; set; }

        }

    }

}
