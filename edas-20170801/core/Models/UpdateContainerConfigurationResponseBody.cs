// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateContainerConfigurationResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The configuration of the Tomcat container.
        /// </summary>
        [NameInMap("ContainerConfiguration")]
        [Validation(Required=false)]
        public UpdateContainerConfigurationResponseBodyContainerConfiguration ContainerConfiguration { get; set; }
        public class UpdateContainerConfigurationResponseBodyContainerConfiguration : TeaModel {
            /// <summary>
            /// The context path of the Tomcat container.
            /// </summary>
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }

            /// <summary>
            /// The application port number for the Tomcat container.
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
            /// The URI encoding scheme. Valid values: ISO-8859-1, GBK, GB2312, and UTF-8.
            /// </summary>
            [NameInMap("URIEncoding")]
            [Validation(Required=false)]
            public string URIEncoding { get; set; }

            /// <summary>
            /// Indicates whether useBodyEncodingForURI is enabled.
            /// </summary>
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }

        }

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

    }

}
