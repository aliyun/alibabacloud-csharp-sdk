// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeGroupEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Nzc5N2FhNTM4OTQ0YzBmYTIy<b><b>ZTUxN2NkYjg4MTJmMWQxZmY1</b></b></para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public DescribeGroupEndpointsResponseBodyEndpoints Endpoints { get; set; }
        public class DescribeGroupEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-26340kjxjx8l3r****</para>
            /// </summary>
            [NameInMap("BackendId")]
            [Validation(Required=false)]
            public string BackendId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PrivateGateway</para>
            /// </summary>
            [NameInMap("EndpointType")]
            [Validation(Required=false)]
            public string EndpointType { get; set; }

            [NameInMap("InternetEndpoints")]
            [Validation(Required=false)]
            public List<string> InternetEndpoints { get; set; }

            [NameInMap("IntranetEndpoints")]
            [Validation(Required=false)]
            public List<string> IntranetEndpoints { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Group</para>
            /// </summary>
            [NameInMap("PathType")]
            [Validation(Required=false)]
            public string PathType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9090</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>890772EF-3AD6-129A-8E15-8F349C944783</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
